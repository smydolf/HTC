using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HTC.DAL.Interface;

namespace HTC.DAL.EF
{


    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public HtcEfDbContext Context { get; set; }
        protected DbSet DbSet { get; set; }

        protected Repository(HtcEfDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public IEnumerable<T> QEntityQueryable
        {
            get { return Context.Set<T>(); }
        }

        public T AddEntity(T entity)
        {
            return DbSet.Add(entity) as T;
        }
        public void UpdateEntity(T entity)
        {
            DbSet.Attach(entity);
        }
        public T DeleteEntity(T entity)
        {

            return (T)DbSet.Remove(entity);
        }
        public IEnumerable<T> GetList()
        {
            IEnumerable<T> query = Context.Set<T>();
            return query;
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> query)
        {
            throw new NotImplementedException();//TODO
        }

        public T GetEntity(object primaryKey)
        {
            return (T)DbSet.Find(primaryKey);
        }

        public void SaveChange()
        {
            Context.SaveChanges();
        }
    }
}
