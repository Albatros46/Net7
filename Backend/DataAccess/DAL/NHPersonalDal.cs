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
    public class NHPersonalDal : RepositoryManager<Personal>, IPersonelDal
    {
        private NHibarnateHelper _hibarnateHelper;

        public NHPersonalDal(NHibarnateHelper nHibarnateHelper) : base(nHibarnateHelper)
        {
            _hibarnateHelper = nHibarnateHelper;

        }
    }
}
