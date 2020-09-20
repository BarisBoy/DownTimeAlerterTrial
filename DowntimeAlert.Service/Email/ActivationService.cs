﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DowntimeAlert.Data.Models;
using DowntimeAlert.Repo;
using Microsoft.EntityFrameworkCore;

namespace DowntimeAlert.Service.Email
{
    public class ActivationService:IActivationService
    {
        private readonly IRepositoryBase<Data.Models.EmailValid> _repositoryBase;

        public ActivationService(IRepositoryBase<EmailValid> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public EmailValid GetByFilter(Expression<Func<EmailValid, bool>> filter)
        {
            return _repositoryBase.GetByFilter(filter);
        }

        public void Insert(EmailValid entity)
        {
            _repositoryBase.Insert(entity);
        }
        public void Delete(EmailValid entity)
        {
            _repositoryBase.Remove(entity);
        }
    }
}
