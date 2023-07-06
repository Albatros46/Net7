using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class MusteriMap:ClassMap<Musteri>
    {
        public MusteriMap()
        {
            Table("Musteriler");
            Id(p=>p.Id).Column("Id").GeneratedBy.Increment();
            References(p => p.sehirId).Column("SehirId").Not.LazyLoad();
            Map(p => p.FullName).Column("FullName").Length(50);
            Map(p => p.Telefon).Column("Telefon").Length(20);
            Map(p => p.Email).Column("E_Mail").Length(150);
            Map(p => p.Adress).Column("Adress").CustomType("text");

        }
    }
}
