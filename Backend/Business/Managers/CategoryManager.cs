using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category Add(Category entity)
        {
            return _categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(p => p.Id == id);
        }

        public List<Category> Paging(int skip, int take)
        {
            return _categoryDal.Paging(skip, take);
        }

        public Category Update(Category entity)
        {
            return _categoryDal.Update(entity);
        }
    }
}
