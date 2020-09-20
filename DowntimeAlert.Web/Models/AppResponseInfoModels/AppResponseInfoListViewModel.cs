using DowntimeAlert.Data.Models;
using DowntimeAlert.Web.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DowntimeAlert.Web.Models.AppResponseInfoModels
{
    public class AppResponseInfoListViewModel
    {
        public TargetApps TargetApp { get; set; }
        public IEnumerable<AppResponseInfos> AppResponseInfoList { get; set; }
    }
}
