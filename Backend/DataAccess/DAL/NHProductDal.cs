using Base.DB.Helper;
using Base.DB.Manager;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class NHProductDal : RepositoryManager<Product>, IProductDal
    {
        private NHibarnateHelper _hibarnateHelper;

        public NHProductDal(NHibarnateHelper nHibarnateHelper) : base(nHibarnateHelper)
        {
            _hibarnateHelper = nHibarnateHelper;
        }

        public List<Product> GetCategoryById(int catId, int skip, int take)
        {
            using (var session = _hibarnateHelper.OpenSession())
            {
                var result = session.Query<Product>().Where(p => p.categoryId.Id == catId).OrderBy(p => p.Name).Skip(skip).Take(take).ToList(); 
                //Kategori id ler birbirine esit ise 0->dan take olana kadar listele
                
                return result;
            }

        }
    }
}
