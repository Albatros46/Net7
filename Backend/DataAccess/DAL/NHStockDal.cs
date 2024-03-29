﻿using Base.DB.Helper;
using Base.DB.Manager;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class NHStockDal : RepositoryManager<Stock>, IStockDal
    {
        private NHibarnateHelper _hibarnateHelper;

        public NHStockDal(NHibarnateHelper nHibarnateHelper) : base(nHibarnateHelper)
        {
            _hibarnateHelper = nHibarnateHelper;

        }

        public List<Stock> Paging(int skip, int take)
        {
            using(var session=_hibarnateHelper.OpenSession())
            {
                return session.Query<Stock>().OrderBy(p=>p.Date).Skip(skip).Take(take).ToList();

            }
        }
    }
}
