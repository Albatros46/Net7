using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISerhirlerService
    {
        List<Sehirler> ParentById(int parentId,int skip,int take);
        void DeleteList(List<Sehirler> sehirler);//Coklu silme islemi icin
        void Delete(Sehirler entity);
        Sehirler Add(Sehirler entity);
        Sehirler Update(Sehirler entity);//Tekli silme islemi
    }
}
