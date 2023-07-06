using Base.DB.Helper;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;
//DERS 5
namespace DataAccess.Helpers
{
    public class PostgresHelper : NHibarnateHelper//Base.DB.Helper NHibarnateHelper implement ediyoruz
    {
        protected override ISessionFactory InitializeFactory()
        {//Veritabani yönetimi tanimlandi. FLuentNHibernate nin kullanim amaci
            var build = Fluently.Configure().Database(PostgreSQLConfiguration.PostgreSQL83.ConnectionString(""))
                .Mappings(p=>p.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
            return build;
        }
        private static void TreatConfiguration(Configuration configuration)
        {
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);//Eger veritabaninda tablolar yoksa olustur.
        }
    }
}
