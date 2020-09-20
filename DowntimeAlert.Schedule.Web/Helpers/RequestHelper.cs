using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hangfire;
using Newtonsoft.Json;
using DowntimeAlert.Schedule.Web.Models;

namespace DowntimeAlert.Schedule.Web.Helpers
{
    public static class RequestHelper
    {
        [DisplayName("{0}")]
        [AutomaticRetry(Attempts = 3, OnAttemptsExceeded = AttemptsExceededAction.Fail)]
        public static string TriggerCallbackUrl(string displayName, ScheduleJobModel model)
        {
            var retVal = "";

            // If Job is passive, it is deleted.
            if (model.Data == (object)false)
            {
                RecurringJob.RemoveIfExists(model.FullName);
                return retVal;
            }

            var result = default(HttpStatusCode);

            if (WebRequest.Create(model.CallbackUrl) is HttpWebRequest request)
            {
                request.Method = string.IsNullOrEmpty(model.CallbackVerb) ? "GET" : model.CallbackVerb;
                request.UseDefaultCredentials = true;
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response != null)
                    {
                        result = response.StatusCode;
                        retVal = JsonConvert.SerializeObject(response);
                        response.Close();
                    }
                }
            }
            if (result != HttpStatusCode.OK)
                throw new Exception($"HTTP/{(int)result} mesajı alındı.");

            // If job is not recurring, it is deleted.
            if (model.ExactDate.HasValue)
                RecurringJob.RemoveIfExists(model.FullName);

            return retVal;
        }
    }
}
