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
    public class NHMusteriDal : RepositoryManager<Musteri>, IMusteriDal
    {
        private NHibarnateHelper _hibarnateHelper;
        public NHMusteriDal(NHibarnateHelper nHibarnateHelper) : base(nHibarnateHelper)
        {
            _hibarnateHelper= nHibarnateHelper;
        }
    }
}
