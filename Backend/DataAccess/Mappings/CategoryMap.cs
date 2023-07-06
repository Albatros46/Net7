using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {// ClassMap : generic yapida bir class
        public CategoryMap()
        {
            Table("Category");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p=>p.Name).Column("Name");
        }
    }
}
