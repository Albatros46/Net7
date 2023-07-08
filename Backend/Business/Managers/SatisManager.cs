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
    public class SatisManager:ISatisService
    {
        private ISatisDal _satisDal;

        public SatisManager(ISatisDal satisDal)
        {
            _satisDal = satisDal;
        }

        public Satis Add(Satis entity)
        {
            return _satisDal.Add(entity);
        }

        public void Delete(Satis entity)
        {
            _satisDal.Delete(entity);
        }

        public List<Satis> GetAll()
        {
            return _satisDal.GetList();
        }

        public Satis GetById(int id)
        {
            return _satisDal.Get(p=>p.Id == id);
        }

        public List<Satis> Paging(int skip, int take)
        {
            return _satisDal.Paging(skip, take);
        }

        public Satis Update(Satis entity)
        {
            return _satisDal.Update(entity);
        }
    }
}
