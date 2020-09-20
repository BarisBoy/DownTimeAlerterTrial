using DowntimeAlert.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DowntimeAlert.Web.Models.TargetAppModels
{
    public class TargetAppFormViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Url(ErrorMessage = "Url is invalid.")]
        [Required(ErrorMessage = "Url is required.")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Monitoring Interval is required.")]
        public int MonitoringInterval { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
