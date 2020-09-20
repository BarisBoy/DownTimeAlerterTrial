using System;
using System.Collections.Generic;

namespace DowntimeAlert.Data.Models
{
    public partial class TargetApps
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int MonitoringInterval { get; set; }
        public bool IsUp { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
