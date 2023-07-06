using Entities.Entities;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class KullaniciYetkileriMap : ClassMap<KullaniciYetkileri>
    {
        public KullaniciYetkileriMap()
        {
            Table("KullaniciYetkileri");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Password).Column("Password");
            References(p => p.personalId).Column("PersonalId").Not.LazyLoad();//References ile iliskili tablolardan veri cekip kullanilir.
            References(p => p.yetkiId).Column("YetkiId").Not.LazyLoad();//Not.LazyLoad ile seiclen objeye ait butun bilgileri getirebilir

        }
    }
}
