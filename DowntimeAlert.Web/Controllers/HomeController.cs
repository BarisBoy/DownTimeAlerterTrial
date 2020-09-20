using DowntimeAlert.Data.Models;
using DowntimeAlert.Web.Models.UserModels;
using DowntimeAlert.Service.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using DowntimeAlert.Web.Helpers;
using DowntimeAlert.Service.Email;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace DowntimeAlert.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IActivationService _activationService;

        public HomeController(IUserService userService, IActivationService activationService)
        {
            _userService = userService;
            _activationService = activationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_userService.GetByFilter(i => i.Email == model.Email) != null)
                {
                    TempDataMessage("message", "danger", $"We have {model.Email},try again.");
                    return RedirectToAction("Index", "Home");
                }
                DowntimeAlert.Data.Models.Users user = new Users
                {
                    Password = new Helpers.PasswordEncode().Encoder(model.Password), // SHA256
                    Email = model.Email,
                    Name = model.Name,
                    Surname = model.Surname,
                    CreatedTime = DateTime.Now,
                };
                _userService.InsertUser(user);
                if (new EmailSender(_activationService).SendEmailActivation(model.Email).Result)
                {
                    TempDataMessage("message", "Success", $"Registration is successfully,you can login now");
                }
                else
                {
                    TempDataMessage("message", "info", $"Registration is successfully but activation mail did not send.");
                }

            }
            else
            {
                TempDataMessage("message","danger", $"Registration form datas is not valid");
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "TargetApp");
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                DowntimeAlert.Data.Models.Users user = _userService.GetByFilter(i => i.Email == model.Email && i.Password == new PasswordEncode().Encoder(model.Password));
                if (user == null)
                {
                    TempDataMessage("message","danger", $"Incorrect Password or Email.");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    if (!user.EmailValid)
                    {
                        TempDataMessage("message", "danger", $"Account is not valid ({user.Email}),please active it");
                        return RedirectToAction("Index", "Home");
                    }
                    var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, user.Id.ToString()), new Claim("Email", user.Email) }, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignOutAsync();
                    await HttpContext.SignInAsync(new ClaimsPrincipal(identity),
                        new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTimeOffset.MaxValue,
                            AllowRefresh = true
                        });
                }

            }
            else
            {
                TempDataMessage("message","danger", $"Login form datas is not valid");
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "TargetApp");
        }
        public void TempDataMessage(string key, string alert, string value)
        {
            try
            {
                TempData.Remove(key);
                TempData.Add(key, value);
                TempData.Add("alertType", alert);
            }
            catch
            {
                Debug.WriteLine("TempDataMessage Error");
            }

        }
    }
}
