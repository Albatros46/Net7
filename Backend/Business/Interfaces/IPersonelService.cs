using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IPersonelService
    {
        List<Personal> GetAll();
        Personal GetById(int id);
        Personal Add(Personal entity);
        Personal Update(Personal entity);
        void Delete(Personal entity);
    }
}
