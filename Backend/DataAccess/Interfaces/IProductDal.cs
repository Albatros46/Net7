using Base.DB.Interface;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IProductDal:IRepositoryService<Product>
    {
        List<Product> GetCategoryById(int catId,int skip,int take);
    }
}
