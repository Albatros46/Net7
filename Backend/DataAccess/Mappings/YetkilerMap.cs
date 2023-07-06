using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class YetkilerMap:ClassMap<Yetkiler>
    {
        public YetkilerMap()
        {
            Table("Yetkiler");
            Id(x=> x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name).Column("Name").Length(20);
            Map(x => x.Description).Column("Description").Length(100);
        }
    }
}
