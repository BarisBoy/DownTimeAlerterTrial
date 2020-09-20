using DowntimeAlert.Repo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DowntimeAlert.Service.TargetApps
{
    public class TargetAppService : ITargetAppService
    {
        private readonly IRepositoryBase<Data.Models.TargetApps> _repositoryTargetApp;

        public TargetAppService(IRepositoryBase<Data.Models.TargetApps> repositoryTargetApp)
        {
            _repositoryTargetApp = repositoryTargetApp;
        }

        public Data.Models.TargetApps GetById(int id)
        {
            return _repositoryTargetApp.GetById(id);
        }

        public Data.Models.TargetApps GetByFilter(Expression<Func<Data.Models.TargetApps, bool>> filter)
        {
            return _repositoryTargetApp.GetByFilter(filter);
        }

        public IList<Data.Models.TargetApps> GetListByFilter(Expression<Func<Data.Models.TargetApps, bool>> filter)
        {
            return _repositoryTargetApp.GetListByFilter(filter);
        }

        public void InsertTargetApp(Data.Models.TargetApps targetApps)
        {
            _repositoryTargetApp.Insert(targetApps);
        }

        public void UpdateTargetApp(Data.Models.TargetApps targetApps)
        {
            _repositoryTargetApp.Update(targetApps);
        }

        public void DeleteTargetApp(Data.Models.TargetApps targetApps)
        {
            _repositoryTargetApp.Remove(targetApps);
        }
        public void SetTargetAppSchedule(Data.Models.TargetApps targetApps)
        {
            new ScheduleTask
            {
                Action = 1,
                Token = "DowntimeAlertSchedule", //targetApp.UserId.ToString(), //emailTemplate.Code,
                Job = targetApps.Id.ToString(),
                Data = targetApps.IsActive,
                CronExpression = $"*/{targetApps.MonitoringInterval} * * * *" // MonitoringInterval'a göre cronExp oluşturulacak!
            }.Schedule();
        }
        public void SetAllTargetAppsSchedule()
        {
            var targetAppList = _repositoryTargetApp.GetListByFilter(r => r.IsActive);
            foreach (var targetApp in targetAppList)
            {
                new ScheduleTask
                {
                    Action = 1,
                    Token = "DowntimeAlertSchedule", //targetApp.UserId.ToString(), //emailTemplate.Code,
                    Job = targetApp.Id.ToString(),
                    Data = targetApp.IsActive,
                    CronExpression = $"*/{targetApp.MonitoringInterval} * * * *" // MonitoringInterval'a göre cronExp oluşturulacak!
                }.Schedule();
            }
        }
    }
}
