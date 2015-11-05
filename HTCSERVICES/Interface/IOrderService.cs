using System;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    

    public interface IOrderService
    {
        IQueryable<Order> GetList();
        Order AddEntity(Order order);
        Order UpdateEntity(Order order);
        void DeleteEntity(Order order);
        IQueryable<Order> GetList(Expression<Func<Order, bool>> query);
        Order GetEntity<T>(object primaryKey);
    }
}
