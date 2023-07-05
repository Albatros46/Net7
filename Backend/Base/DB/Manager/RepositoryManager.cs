using Base.DB.Helper;
using Base.DB.Interface;
using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Base.DB.Manager
{
    public class RepositoryManager<T> : IRepositoryService<T> where T : class,IEntity, new()
    {//Inherite(miras alacak) olan class IEntity den olusacak ve bir class olacak
       
        private NHibarnateHelper _nHibarnateHelper;

        public RepositoryManager(NHibarnateHelper nHibarnateHelper)
        {
            _nHibarnateHelper = nHibarnateHelper;
        }

        public T Add(T entity)
        {
            using (var session = _nHibarnateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public  void Delete(T entity)
        {
            using (var session = _nHibarnateHelper.OpenSession())
            {
                session.Delete(entity);
                session.Flush();
                session.Clear();
            }
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            using (var session = _nHibarnateHelper.OpenSession())
            {
                return session.Query<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var session = _nHibarnateHelper.OpenSession())
            {
                return filter==null ? session.Query<T>().ToList():session.Query<T>().Where(filter).ToList();
             //asagidaki kodun kisa hali
            /*    if (filter==null)
                {
                    session.Query<T>().ToList();
                }
                else
                {
                    session.Query<T>().Where(filter).ToList();
                }
            */
            }
        }

        public T Update(T entity)
        {
            using (var session = _nHibarnateHelper.OpenSession())
            {
                session.Update(entity);
                session.Flush();
                session.Clear();
                return entity;
            }
        }
    }
}
