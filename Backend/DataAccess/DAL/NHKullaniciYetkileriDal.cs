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
    public class NHKullaniciYetkileriDal : RepositoryManager<KullaniciYetkileri>, IKullaniciYetkileriDal
    {
        private NHibarnateHelper _hibarnateHelper;
        public NHKullaniciYetkileriDal(NHibarnateHelper nHibarnateHelper) : base(nHibarnateHelper)
        {
            _hibarnateHelper= nHibarnateHelper;
        }

        public List<Personal> GetByPersonel(int yetkiID,int skip,int take)
        {//skip ve take kullanimi sayesinde sayfalama yapilabilir sekilde listelenecek
            using (var session=_hibarnateHelper.OpenSession())
            {
                var result=session.Query<KullaniciYetkileri>().Where(p=>p.yetkiId.Id==yetkiID)
                    .Select(p=>p.personalId).Skip(skip).Take(take).ToList();

                return result;
            }
        }
    }
}
