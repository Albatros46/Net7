using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class SehirlerMap:ClassMap<Sehirler>
    {
        public SehirlerMap()
        {
            Table("Sehirler");
            Id(p=>p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Kod).Column("Code").Length(5);
            Map(p => p.Name).Column("Name").Length(50);
            Map(p => p.ParentId).Column("ParentId");
        }
    }
}
