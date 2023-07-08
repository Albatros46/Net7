using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IMusteriService
    {
        List<Musteri> Paging(int skip, int take);
        List<Musteri> GetAll();
        Musteri GetById(int id);
        Musteri Add(Musteri entity);
        Musteri Update(Musteri entity);
        void Delete(Musteri entity);
    }
}
