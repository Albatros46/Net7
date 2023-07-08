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
    public class SehirlerManager : ISerhirlerService
    {
        private ISehirlerDal _sehirlerDal;

        public SehirlerManager(ISehirlerDal sehirlerDal)
        {
            _sehirlerDal = sehirlerDal;
        }

        public Sehirler Add(Sehirler entity)
        {
            return _sehirlerDal.Add(entity);
        }

        public void Delete(Sehirler entity)
        {//Tekli silme islemi
            _sehirlerDal.Delete(entity);
        }

        public void DeleteList(List<Sehirler> sehirler)
        {//Coklu silme islemi icin
            _sehirlerDal.DeleteList(sehirler);
        }

        public List<Sehirler> ParentById(int parentId, int skip, int take)
        {
            return _sehirlerDal.ParentById(parentId, skip, take);
        }

        public Sehirler Update(Sehirler entity)
        {
            return _sehirlerDal.Update(entity);
        }
    }
}
