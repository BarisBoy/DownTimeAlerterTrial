using System;
using System.ComponentModel;
using System.Net;
using Hangfire;
using Hangfire.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NCrontab;
using Newtonsoft.Json;
using DowntimeAlert.Schedule.Web.Helpers;
using DowntimeAlert.Schedule.Web.Models;

namespace DowntimeAlert.Schedule.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        public ScheduleController(IHttpContextAccessor httpContextAccessor)
        {
        }

        [HttpPost]
        [Route("addOrUpdate")]
        public IActionResult AddOrUpdate([FromBody] ScheduleJobModel model)
        {
            if (string.IsNullOrEmpty(model.ProjectName))
                return BadRequest("Proje adı boş olamaz.");

            if (string.IsNullOrEmpty(model.JobName))
                return BadRequest("Job adı boş olamaz.");

            if (!model.CallbackUrl.StartsWith("http"))
                return BadRequest("CallbackUrl http ile başlamalıdır.");

            if (string.IsNullOrEmpty(model.CronExpression) && model.ExactDate == null)
                return BadRequest("CronExpression ve ExactDate aynı anda boş olamaz.");

            if (!string.IsNullOrEmpty(model.CronExpression) && CrontabSchedule.TryParse(model.CronExpression) == null)
                return BadRequest("CronExpression geçerli değil.");

            try
            {
                var manager = new RecurringJobManager();
                var job = Job.FromExpression(() => RequestHelper.TriggerCallbackUrl(model.FullName, model));

                manager.AddOrUpdate(model.FullName, job, model.CronExpression, TimeZoneInfo.Local);

                return Ok("Job başarıyla oluşturuldu");
            }
            catch (Exception e)
            {
                return BadRequest($"Job oluşturulurken hata oluştu. {e.Message}");
            }
        }
    }
}
