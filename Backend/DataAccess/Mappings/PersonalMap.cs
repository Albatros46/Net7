using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class PersonalMap:ClassMap<Personal>
    {
        public PersonalMap()
        {
            Table("Personal");
            Id(a => a.Id).Column("Id").GeneratedBy.Increment();
            Map(p=>p.VollName).Column("FullName").Length(50);
            Map(p=>p.Telefon).Column("Telefon").Length(20);
            Map(p=>p.Email).Column("Email").Length(150);
            Map(p=>p.Adress).Column("Adress").CustomType("text");
            Map(p=>p.isActive).Column("Aktiv");
        }
    }
}
