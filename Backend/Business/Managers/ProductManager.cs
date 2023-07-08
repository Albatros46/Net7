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
    public class ProductManager: IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product entity)
        {
            return _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p=>p.Id == id);
        }

        public List<Product> GetCategoryById(int catId, int skip, int take)
        {
            return _productDal.GetCategoryById(catId,skip,take);
        }

        public Product Update(Product entity)
        {
           return _productDal.Update(entity);
        }
    }
}
