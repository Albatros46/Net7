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
    public class PersonalManager : IPersonelService

    {
        private IPersonelDal _personelDal;

        public PersonalManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public Personal Add(Personal entity)
        {
            return _personelDal.Add(entity);
        }

        public void Delete(Personal entity)
        {
            _personelDal.Delete(entity);
        }

        public List<Personal> GetAll()
        {
            return _personelDal.GetList();
        }

        public Personal GetById(int id)
        {
            return _personelDal.Get(p=>p.Id == id);
        }

        public Personal Update(Personal entity)
        {
            return _personelDal.Update(entity);
        }
    }
}
