using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.DB.Helper
{
    public abstract class NHibarnateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); /*EGer sessionFactory bos ise initiallizefactory calissin*/ }  
        }

        protected abstract ISessionFactory InitializeFactory();
        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
            /*
             Inser,update,delete islemleri yapildiginda Opensesion calistirildiginda eger sessionfactory 
            bos ise Initalize calistirilip SessionFactoryi  dolduruyor.
             */
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            /*
             burada bir section calisip kapanmadiginda bu dispose araciligi ile kapanmasi saglaniyor.
             */
        }
    }
}
