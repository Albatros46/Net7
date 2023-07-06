using Base.DB.Interface;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IKullaniciYetkileriDal:IRepositoryService<KullaniciYetkileri>
    {
        List<Personal> GetByPersonel(int yetkiID,int skip,int take);//skip baslama. take bitis
    }
}
