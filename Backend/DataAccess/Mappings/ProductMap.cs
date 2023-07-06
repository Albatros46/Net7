using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Product");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Name).Column("ProductName");
            References(p => p.categoryId).Column("Category").Not.LazyLoad();
            Map(p => p.Date).Column("Date");
            Map(p => p.Price).Column("Price");
        }
    }
}
