using System;
using System.Collections.Generic;

namespace DowntimeAlert.Data.Models
{
    public partial class AppResponseInfos
    {
        public int Id { get; set; }
        public int TargetAppId { get; set; }
        public int ResponseStatusCode { get; set; }
        public int ResponseTime { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
