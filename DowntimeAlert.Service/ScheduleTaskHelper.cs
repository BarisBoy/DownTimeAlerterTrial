using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace DowntimeAlert.Repo
{
    public class ScheduleTask
    {
        public int Action { get; set; }
        public string Job { get; set; }
        public string Token { get; set; }
        public object Data { get; set; }
        public DateTime? StartDate { get; set; }
        public string CronExpression { get; set; }
        public void Schedule()
        {
            ScheduleTaskHelper.Schedule(this);
        }
    }

    public static class ScheduleTaskHelper
    {
        private static readonly string HangfireEndpoint = "http://localhost:51441/"; //ConfigurationManager.AppSettings["_hangfireEndpoint"];
        private static readonly string HangfireCallbackUrl = "http://localhost:5725/trigger"; //ConfigurationManager.AppSettings["_hangfireCallbackUrl"];

        /// <summary>
        /// Hangfire'a zamanlanmış görev kaydı gönderir
        /// </summary>
        public static void Schedule(ScheduleTask task)
        {
            var jsonData = JsonConvert.SerializeObject(task);
            var callbackUrl = $"{HangfireCallbackUrl}/?actionId={task.Action}&data={jsonData}";
            var _jobName = task.Job;
            var jobName = $"{task.Action}-{_jobName}-{task.Token}";

            if (task.Data == null || task.Data == (object)false)
                return;

            var model = new
            {
                ProjectName = "DowntimeAlerter",
                JobName = jobName,
                CallbackUrl = callbackUrl,
                CallbackVerb = "POST",
                task.CronExpression,
                task.StartDate,
                task.Data,
            };
            SendToHangfire(model);
        }

        private static void SendToHangfire(object model)
        {
            if (string.IsNullOrEmpty(HangfireEndpoint))
                throw new Exception("hangfireEndpoint is undefined!");

            if (string.IsNullOrEmpty(HangfireCallbackUrl))
                throw new Exception("hangfireCallbackUrl is undefined!");

            var client = new RestClient(HangfireEndpoint);
            var request = new RestRequest("/api/schedule/addOrUpdate", Method.POST);
            request.Parameters.Clear();
            request.AddParameter("application/json", JsonConvert.SerializeObject(model), ParameterType.RequestBody);
            request.UseDefaultCredentials = true;

            var response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"An error occurred while assigning the scheduled task. HTTP/{response.StatusCode}");
        }
    }
}
