using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class KullaniciYetkileriManager : IKullaniciYetkileriService
    {
        private IKullaniciYetkileriDal _kullaniciYetkileriDal;

        public KullaniciYetkileriManager(IKullaniciYetkileriDal kullaniciYetkileriDal)
        {
            _kullaniciYetkileriDal = kullaniciYetkileriDal;
        }

        public KullaniciYetkileri Add(KullaniciYetkileri entity)
        {
            return _kullaniciYetkileriDal.Add(entity);
        }

        public void Delete(KullaniciYetkileri entity)
        {
           _kullaniciYetkileriDal.Delete(entity);
        }

        public List<KullaniciYetkileri> GetAll()
        {
            return _kullaniciYetkileriDal.GetList();
        }

        public KullaniciYetkileri GetById(int id)
        {
           return _kullaniciYetkileriDal.Get(p=>p.Id == id);
        }

        public List<Personal> GetByPersonel(int yetkiID, int skip, int take)
        {
            return _kullaniciYetkileriDal.GetByPersonel(yetkiID, skip, take);
        }

        public KullaniciYetkileri Update(KullaniciYetkileri entity)
        {
            return _kullaniciYetkileriDal.Update(entity);
        }
    }
}
