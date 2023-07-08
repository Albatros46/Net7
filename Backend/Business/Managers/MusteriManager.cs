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
    public class MusteriManager:IMusteriService
    {
        private IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public Musteri Add(Musteri entity)
        {
            return   _musteriDal.Add(entity);
        }

        public void Delete(Musteri entity)
        {
            _musteriDal.Delete(entity);
        }

        public List<Musteri> GetAll()
        {
            return _musteriDal.GetList();
        }

        public Musteri GetById(int id)
        {
            return _musteriDal.Get(p=>p.Id==id);
        }

        public List<Musteri> Paging(int skip, int take)
        {
            return _musteriDal.Paging(skip, take);
        }

        public Musteri Update(Musteri entity)
        {
            return _musteriDal.Update(entity);
        }
    }
}
