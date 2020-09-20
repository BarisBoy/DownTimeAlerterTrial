using DowntimeAlert.Repo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DowntimeAlert.Service.AppResponseInfos
{
    public class AppResponseInfosService : IAppResponseInfosService
    {
        private readonly IRepositoryBase<Data.Models.AppResponseInfos> _repositoryAppResponseInfo;

        public AppResponseInfosService(IRepositoryBase<Data.Models.AppResponseInfos> repositoryAppResponseInfo)
        {
            _repositoryAppResponseInfo = repositoryAppResponseInfo;
        }

        public Data.Models.AppResponseInfos GetById(int id)
        {
            return _repositoryAppResponseInfo.GetById(id);
        }

        public Data.Models.AppResponseInfos GetByFilter(Expression<Func<Data.Models.AppResponseInfos, bool>> filter)
        {
            return _repositoryAppResponseInfo.GetByFilter(filter);
        }

        public IList<Data.Models.AppResponseInfos> GetListByFilter(Expression<Func<Data.Models.AppResponseInfos, bool>> filter)
        {
            return _repositoryAppResponseInfo.GetListByFilter(filter);
        }

        public void InsertAppResponseInfo(Data.Models.AppResponseInfos appResponseInfos)
        {
            _repositoryAppResponseInfo.Insert(appResponseInfos);
        }

        public void UpdateAppResponseInfo(Data.Models.AppResponseInfos appResponseInfos)
        {
            _repositoryAppResponseInfo.Update(appResponseInfos);
        }

        public void DeleteAppResponseInfo(Data.Models.AppResponseInfos appResponseInfos)
        {
            _repositoryAppResponseInfo.Remove(appResponseInfos);
        }
    }
}
