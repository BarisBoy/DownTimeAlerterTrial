using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DowntimeAlert.Service.TargetApps
{
    public interface ITargetAppService
    {
        
        Data.Models.TargetApps GetById(int id);
        Data.Models.TargetApps GetByFilter(Expression<Func<Data.Models.TargetApps, bool>> filter);
        IList<Data.Models.TargetApps> GetListByFilter(Expression<Func<Data.Models.TargetApps, bool>> filter);
        void InsertTargetApp(Data.Models.TargetApps targetApps);
        void UpdateTargetApp(Data.Models.TargetApps targetApps);
        void DeleteTargetApp(Data.Models.TargetApps targetApps);
        void SetTargetAppSchedule(Data.Models.TargetApps targetApps);
        void SetAllTargetAppsSchedule();
    }

}
