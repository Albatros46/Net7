using Base.DB.Interface;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ISehirlerDal : IRepositoryService<Sehirler>
    {
        List<Sehirler> ParentById(int parentID,int skip,int take);
        void DeleteList(List<Sehirler> silinecekSehirler);//coklu silme islemi
    }
}
