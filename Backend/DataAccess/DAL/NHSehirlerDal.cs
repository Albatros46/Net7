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
    public class NHSehirlerDal : RepositoryManager<Sehirler>, ISehirlerDal
    {
        private NHibarnateHelper _hibarnateHelper;

        public NHSehirlerDal(NHibarnateHelper nHibarnateHelper) : base(nHibarnateHelper)
        {
            _hibarnateHelper = nHibarnateHelper;

        }

        public void DeleteList(List<Sehirler> silinecekSehirler)
        {
            using (var session=_hibarnateHelper.OpenSession())
            {
                foreach (var item in silinecekSehirler)
                {
                    session.Delete(item);
                }
                session.Flush();//islem onayla 
                session.Clear();//oturumu temizle
            }
        }

        public List<Sehirler> ParentById(int parentID, int skip, int take)
        {
            using (var session = _hibarnateHelper.OpenSession())
            {
                var result = session.Query<Sehirler>().Where(p => p.ParentId == parentID)
                    .OrderBy(p => p.Name).Skip(skip).Take(take).ToList();

                return result;
            }
        }
    }
}
