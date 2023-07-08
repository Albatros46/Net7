using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IKullaniciYetkileriService
    {
        List<Personal> GetByPersonel(int yetkiID, int skip, int take);//skip baslama. take bitis
        List<KullaniciYetkileri> GetAll();
        KullaniciYetkileri GetById(int id);
        KullaniciYetkileri Add(KullaniciYetkileri entity);
        KullaniciYetkileri Update(KullaniciYetkileri entity);
        void Delete(KullaniciYetkileri entity);

    }
}
