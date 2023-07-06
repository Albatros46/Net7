using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class StockMap:ClassMap<Stock>
    {
        public StockMap()
        {
            Table("Stock");
            Id(p=>p.Id).Column("Id").GeneratedBy.Increment();
            References(p => p.productId).Column("Product").Not.LazyLoad();
            References(p => p.personalId).Column("Personal").Not.LazyLoad();
            Map(p => p.Date).Column("Date");
            Map(p => p.Quantity).Column("Quantity");
        }
    }
}
