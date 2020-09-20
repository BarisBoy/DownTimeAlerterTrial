using DowntimeAlert.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DowntimeAlert.Web.Models.TargetAppModels
{
    public class TargetAppListViewModel
    {
        public int UserId { get; set; }
        public IEnumerable<TargetApps> TargetAppList { get; set; }

        //[Required(ErrorMessage = "Name is required.")]
        //public string Name { get; set; }

        //[Required(ErrorMessage = "Url is required.")]
        //public string Url { get; set; }
        //public DateTime CreatedTime { get; set; }
    }
}
