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
    public class NHCategoryDal : RepositoryManager<Category>, ICategoryDal
    {
        private NHibarnateHelper _hibarnateHelper;
        public NHCategoryDal(NHibarnateHelper nHibarnateHelper) : base(nHibarnateHelper)
        {
            _hibarnateHelper= nHibarnateHelper;
        }

        public List<Category> Paging(int skip, int take)
        {
            using (var session=_hibarnateHelper.OpenSession())
            {
                return session.Query<Category>().OrderBy(p => p.Name).Skip(skip).Take(take).ToList();
            }
        }
    }
}
