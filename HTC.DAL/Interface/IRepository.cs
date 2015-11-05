using System;
using System.Linq;
using System.Linq.Expressions;

namespace HTC.DAL.Interface
{
    public interface IRepository<T>
    {
        void AddEntity(T entity);
        void UpdateEntity(T entity);

        void DeleteEntity(T entity);

        IQueryable<T> GetList();

        IQueryable<T> GetList(Expression<Func<T, bool>> query);

        T GetEntity(object primaryKey);
    }
}
