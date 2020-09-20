using DowntimeAlert.Data.Models;
using DowntimeAlert.Service.Users;
using System;
using System.Diagnostics;
using DowntimeAlert.Service.Email;
using DowntimeAlert.Service.TargetApps;
using DowntimeAlert.Web.Models.TargetAppModels;
using DowntimeAlert.Service.AppResponseInfos;
using DowntimeAlert.Web.Models.AppResponseInfoModels;
using Microsoft.AspNetCore.Mvc;

namespace DowntimeAlert.Web.Controllers
{
    public class TargetAppController : Controller
    {
        private readonly IUserService _userService;
        private readonly IActivationService _activationService;
        private readonly ITargetAppService _targetAppService;
        private readonly IAppResponseInfosService _appResponseInfosService;

        public TargetAppController(IUserService userService, IActivationService activationService, ITargetAppService targetAppService, IAppResponseInfosService appResponseInfosService)
        {
            _userService = userService;
            _activationService = activationService;
            _targetAppService = targetAppService;
            _appResponseInfosService = appResponseInfosService;
        }

        public IActionResult Index()
        {
            var userId = 1; //int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = _userService.GetByFilter(i => i.Id == userId);
            if (!user.EmailValid)
            {
                TempDataMessage("message", "danger", $"Account is not valid ({user.Email}),please active it");
                return RedirectToAction("Index", "Home");
            }

            var targetAppListViewModel = new TargetAppListViewModel
            {
                UserId = userId
            };

            targetAppListViewModel.TargetAppList = _targetAppService.GetListByFilter(i => i.UserId == targetAppListViewModel.UserId && i.IsActive == true);

            return View(targetAppListViewModel);
        }

        [HttpGet]
        public IActionResult CreateTargetApp(int? id, int userId)
        {
            TargetAppFormViewModel targetAppFormViewModel = new TargetAppFormViewModel
            {
                UserId = userId
            };

            if (id > 0)
            {
                var targetApp = _targetAppService.GetByFilter(i => i.Id == id);
                if (targetApp == null)
                {
                    TempDataMessage("message", "danger", $"The app is not found!");
                    return RedirectToAction("Index", "TargetApp");
                }
                else
                {
                    targetAppFormViewModel.Id = targetApp.Id;
                    targetAppFormViewModel.Name = targetApp.Name;
                    targetAppFormViewModel.Url = targetApp.Url;
                    targetAppFormViewModel.MonitoringInterval = targetApp.MonitoringInterval;
                }
            }
            return View("CreateTargetApp", targetAppFormViewModel);
        }

        [HttpPost]
        public IActionResult CreateTargetApp(TargetAppFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                TargetApps targetApp = new TargetApps
                {
                    UserId = model.UserId,
                    Name = model.Name,
                    Url = model.Url,
                    MonitoringInterval = model.MonitoringInterval,
                    CreatedTime = DateTime.Now
                };
                try
                {
                    if (model.Id > 0)
                    {
                        _targetAppService.UpdateTargetApp(targetApp);
                    }
                    else
                    {
                        _targetAppService.InsertTargetApp(targetApp);
                    }
                    _targetAppService.SetTargetAppSchedule(targetApp);

                    TempDataMessage("message", "Success", $"Operation completed successfully!");
                }
                catch (Exception ex)
                {
                    TempDataMessage("message", "info", $"Operation isn't completed successfully! {ex}");
                }
            }
            else
            {
                TempDataMessage("message", "danger", $"Form datas is not valid!");
                return RedirectToAction("CreateTargetApp", "TargetApp");
            }
            return RedirectToAction("Index", "TargetApp");
        }

        [HttpDelete]
        public ActionResult DeleteTargetApp(int id)
        {
            var targetApp = _targetAppService.GetByFilter(r => r.Id == id);
            try
            {
                targetApp.IsActive = false;
                _targetAppService.UpdateTargetApp(targetApp);
                TempDataMessage("message", "Success", $"{targetApp.Name} is deleted successfully!");
            }
            catch (Exception ex)
            {
                TempDataMessage("message", "info", $"Operation isn't completed successfully! {ex}");
                return Json(false);
            }
            return Json(true);
        }

        public IActionResult Monitor(int id)
        {
            var targetApp = _targetAppService.GetByFilter(i => i.Id == id);
            var appResponseInfos = _appResponseInfosService.GetListByFilter(i => i.TargetAppId == id);

            var appResponseInfoListViewModel = new AppResponseInfoListViewModel
            {
                TargetApp = targetApp,
                AppResponseInfoList = appResponseInfos
            };

            return View(appResponseInfoListViewModel);
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
