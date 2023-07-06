using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class SatisMap:ClassMap<Satis>
    {
        public SatisMap()
        {
            Table("Satis");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            References(p=>p.productId).Column("Product").Not.LazyLoad();
            References(p=>p.personalId).Column("Personal").Not.LazyLoad();
            References(p=>p.musteriId).Column("Musteri").Not.LazyLoad();
            Map(p => p.Quantity).Column("Quantity");
            Map(p => p.Date).Column("Date");
        }
    }
}
