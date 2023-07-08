using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IYetkilerService
    {
        List<Yetkiler> GetAll();
        Yetkiler GetById(int id);
        Yetkiler Add(Yetkiler entity);
        Yetkiler Update(Yetkiler entity);
        void Delete(Yetkiler entity);
    }
}
