using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetCategoryById(int catId, int skip, int take);
        Product GetById(int id);
        Product Add(Product entity);
        Product Update(Product entity);
        void Delete(Product entity);

    }
}
