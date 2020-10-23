using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TMS.Persistance
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TMSDataContext _context;
        public Repository(TMSDataContext context)
        {
            this._context = context;

        }

        public IEnumerable<T> GetAll()
        {
           return this._context.Set<T>();
        }
         public IEnumerable <T> Find(Expression<Func<T, bool>> predicate)
        {
            return this._context.Set<T>().Where(predicate);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return this._context.Set<T>().FirstOrDefault(predicate);
        }

        public T GetByid(int id)
        {
            return this._context.Set<T>().Find();
        }

        public void Add(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            this._context.Set<T>().Remove(entity);  
        }

        //public void update(t entity)
        //{
        //    this._context.set<t>().update(entity);
        //}
    }
}
