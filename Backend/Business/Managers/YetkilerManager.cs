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
    public class YetkilerManager:IYetkilerService
    {
        private IYetkilerDal _yetkilerDal;

        public YetkilerManager(IYetkilerDal yetkilerDal)
        {
            _yetkilerDal = yetkilerDal;
        }

        public Yetkiler Add(Yetkiler entity)
        {
            return _yetkilerDal.Add(entity);
        }

        public void Delete(Yetkiler entity)
        {
             _yetkilerDal.Delete(entity);   
        }

        public List<Yetkiler> GetAll()
        {
            return _yetkilerDal.GetList();
        }

        public Yetkiler GetById(int id)
        {
            return _yetkilerDal.Get(p=>p.Id == id);
        }

        public Yetkiler Update(Yetkiler entity)
        {
            return _yetkilerDal.Update(entity);
        }
    }
}
