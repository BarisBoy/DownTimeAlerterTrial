using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DowntimeAlert.Data.Models;
using DowntimeAlert.Service.Email;
using DowntimeAlert.Service.Users;
using Microsoft.Extensions.DependencyInjection;

namespace DowntimeAlert.Web.Helpers
{
    public class EmailActivaitonKey
    {
        private readonly IActivationService _activationService;

        public EmailActivaitonKey(IActivationService activationService)
        {
            _activationService = activationService;
        }


        public string ActivationKey(string email)
        {
            string guid = Guid.NewGuid().ToString();
            while (_activationService.GetByFilter(i => i.ActivationKey == guid) != null)
            {
                guid = Guid.NewGuid().ToString();
            }
            string key = email + ":OSK:" + DateTime.Now + ":OSK:" + guid;
            EmailValid emailValid = new EmailValid
            {
                Email = email,
                Time = DateTime.Now,
                ActivationKey = guid
            };
            _activationService.Insert(emailValid);
            return new Helpers.AESEncryption().EncryptText(key);
        }
    }
}
