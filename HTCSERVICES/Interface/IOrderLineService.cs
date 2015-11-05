using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    public interface IOrderLineService
    {
        IQueryable<OrderLine> GetList();
        OrderLine AddEntity(OrderLine orderLine);
        OrderLine UpdateEntity(OrderLine orderLine);
        void DeleteEntity(OrderLine orderLine);
        IQueryable<OrderLine> GetList(Expression<Func<Order, bool>> query);
        OrderLine GetEntity<T>(object primaryKey);
    }
}
