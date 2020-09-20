using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DowntimeAlert.Service.AppResponseInfos
{
    public interface IAppResponseInfosService
    {        
        Data.Models.AppResponseInfos GetById(int id);
        Data.Models.AppResponseInfos GetByFilter(Expression<Func<Data.Models.AppResponseInfos, bool>> filter);
        IList<Data.Models.AppResponseInfos> GetListByFilter(Expression<Func<Data.Models.AppResponseInfos, bool>> filter);
        void InsertAppResponseInfo(Data.Models.AppResponseInfos appResponseInfos);
        void UpdateAppResponseInfo(Data.Models.AppResponseInfos appResponseInfos);
        void DeleteAppResponseInfo(Data.Models.AppResponseInfos appResponseInfos);
    }

}
