using Base.DB.Helper;
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
    public class NHSatisDal : RepositoryManager<Satis>, ISatisDal
    {
        private NHibarnateHelper _hibarnateHelper;

        public NHSatisDal(NHibarnateHelper nHibarnateHelper) : base(nHibarnateHelper)
        {
            _hibarnateHelper = nHibarnateHelper;

        }

        public List<Satis> Paging(int skip, int take)
        {
            using (var session = _hibarnateHelper.OpenSession())
            {//OrderByDescending =enson eklenene gore listele
                return session.Query<Satis>().OrderByDescending(p=>p.Id).Skip(skip).Take(take).ToList();
            }
        }
    }
}
