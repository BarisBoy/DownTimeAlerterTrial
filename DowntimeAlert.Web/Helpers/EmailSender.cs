using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Web;
using DowntimeAlert.Data.Models;
using DowntimeAlert.Web.Exceptions;
using DowntimeAlert.Repo;
using DowntimeAlert.Service.Email;
using Microsoft.EntityFrameworkCore;

namespace DowntimeAlert.Web.Helpers
{
    public class EmailSender
    {
        private readonly IActivationService _activationService;

        public EmailSender(IActivationService activationService)
        {
            _activationService = activationService;
        }

        public GeneralException SendEmailActivation(string email)
        {
            try
            {
                //Set mail SMTP settings
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("baris.boy@ogr.sakarya.edu.tr", "sabisboy94")
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("baris.boy@ogr.sakarya.edu.tr"),
                    Subject = "Downtime Alert Activation",
                    //Fix localhost port
                    Body = "Ready Downtime Alert Activation </br><a href='http://localhost:5725/Email/Activation?key=" + HttpUtility.UrlEncode(new EmailActivaitonKey(_activationService).ActivationKey(email)) + "'><h1>Click For Activation<h1><a>",
                    To = { email },
                    IsBodyHtml = true
                };

                client.Send(mailMessage);
                client.Dispose();
                return new GeneralException(true);
            }
            catch (Exception ex)
            {
                return new GeneralException(false, ex.Message);
            }

        }
    }
}
