using DowntimeAlert.Data.Models;
using DowntimeAlert.Repo;
using DowntimeAlert.Service.AppResponseInfos;
using DowntimeAlert.Service.TargetApps;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace DowntimeAlert.Web.Controllers
{
    [AllowAnonymous]
    public class TriggerController : Controller
    {
        private readonly ITargetAppService _targetAppService;
        private readonly IAppResponseInfosService _appResponseInfosService;

        public TriggerController(ITargetAppService targetAppService, IAppResponseInfosService appResponseInfosService)
        {
            _targetAppService = targetAppService;
            _appResponseInfosService = appResponseInfosService;
        }

        [HttpGet()]
        [HttpPost()]
        public string Index(int actionId, string data)
        {
            var _data = HttpUtility.HtmlDecode(data);
            var taskData = JsonConvert.DeserializeObject<ScheduleTask>(_data);
            ProcessActions(taskData);

            return "OK";
        }

        private void ProcessActions(ScheduleTask taskData)
        {
            Task.Run(async () =>
            {
                var targetAppId = Int32.Parse(taskData.Job.ToString());
                var targetApp = _targetAppService.GetByFilter(i => i.Id == targetAppId);
                if (!targetApp.Url.StartsWith("http") && !targetApp.Url.StartsWith("https")) targetApp.Url = "http://" + targetApp.Url;

                //var request = HttpWebRequest.Create(targetApp.Url);
                //var response2 = request.GetResponse() as HttpWebResponse;

                var client = new HttpClient();

                DateTime beforeCall = DateTime.UtcNow;

                var response = await client.GetAsync(targetApp.Url);

                DateTime afterCall = DateTime.UtcNow;
                TimeSpan interval = afterCall - beforeCall;

                if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
                {
                    targetApp.IsUp = true;
                }
                else
                {
                    targetApp.IsUp = false;
                    // uyarı maili
                }
                _targetAppService.UpdateTargetApp(targetApp);

                var responseInfo = new AppResponseInfos
                {
                    TargetAppId = targetApp.Id,
                    ResponseTime = (int)interval.TotalMilliseconds,
                    ResponseStatusCode = (int)response.StatusCode,
                    CreatedTime = afterCall
                };
                _appResponseInfosService.InsertAppResponseInfo(responseInfo);

                // urllere istekler atılmalı sonuçlar DB'ye yazılmalı!
                // new DashboardJob().Start();
                //new QueueBusiness().AddDashboard();

                // Eğer site düşerse aşağıdakine benzer bir hatırlatma maili gönderilebilir.
                //new EmailBusiness().SendReminderMail(EmailCodes.PENDING_FLOW_REMINDER);
            });
        }
    }
}