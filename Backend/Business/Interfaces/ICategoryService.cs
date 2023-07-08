using Entities.Entities;

namespace Business.Interfaces
{
    public interface ICategoryService
    {//Ders6
        List<Category> GetAll();
        List<Category> Paging(int skip, int take);//sayfalama islemi icin
        Category GetById(int id);
        Category Add(Category entity);
        Category Update(Category entity);
        void Delete(Category entity);
    }
}
