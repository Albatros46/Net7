using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IStockService
    {
        List<Stock> GetAll();
        List<Stock> Paging(int skip, int take);
        Stock GetById(int id);
        Stock Add(Stock entity);
        Stock Update(Stock entity);
        void Delete(Stock entity);
    }
}
