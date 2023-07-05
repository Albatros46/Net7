using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Base.DB.Interface
{
    public interface IRepositoryService<T> where T : class, IEntity, new()
    {//Veritabani nesnesi imzasi tasimayan hicbir class bu nu implement edemez.
        List<T> GetList(Expression<Func<T, bool>> filter = null);//Expression ve Func ile sorgu gondererek listeleme yapilabilir.
        T Get(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }

}
