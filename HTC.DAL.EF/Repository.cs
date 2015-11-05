using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HTC.DAL.Interface;

namespace HTC.DAL.EF
{


    public abstract class Repository<T> : IRepository<T> where T: class
    {
        public HtcEfDbContext Context { get; set; }
        protected DbSet DbSet { get; set; }

        protected Repository(HtcEfDbContext context)
        {
            Context = context;
            DbSet=Context.Set<T>();
        }


        public void AddEntity(T entity)
        {
            DbSet.Add(entity);
            
        }

        public void UpdateEntity(T entity)
        {
            DbSet.Attach(entity);
            
        }

        public void DeleteEntity(T entity)
        {
            DbSet.Remove(entity);
            
        }

        public IQueryable<T> GetList()
        {
            IQueryable<T> query = Context.Set<T>();
            return query;
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> query)
        {
            throw new NotImplementedException();
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
