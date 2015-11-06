using System;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTC.DAL.Interface
{
    public interface IRepository<T>
    {
        T AddEntity(T entity);
        void UpdateEntity(T entity);

        T DeleteEntity(T entity);

        IQueryable<T> GetList();

        IQueryable<T> GetList(Expression<Func<T, bool>> query);

        T GetEntity(object primarykey);
    }
}
