using Entities.Entities;

namespace Business.Interfaces
{
    public interface ISatisService
    {
        List<Satis> GetAll();
        List<Satis> Paging(int skip,int take);
        Satis GetById(int id);
        Satis Add(Satis entity);
        Satis Update(Satis entity);
        void Delete(Satis entity);
    }
}
