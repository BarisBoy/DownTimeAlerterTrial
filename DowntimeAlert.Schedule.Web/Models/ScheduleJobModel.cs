using System;
using DowntimeAlert.Schedule.Web.Helpers;

namespace DowntimeAlert.Schedule.Web.Models
{
    public class ScheduleJobModel
    {
        public string FullName => $"[{ProjectName.ToUrlFriendlyLower()}]-{JobName.ToUrlFriendlyLower()}";
        public string ProjectName { get; set; }
        public string JobName { get; set; }
        public string CallbackUrl { get; set; }
        public string CallbackVerb { get; set; }
        public DateTime? ExactDate { get; set; }
        public string CronExpression { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? StartDate { get; set; } 
        public object Data { get; set; }
    }
}
