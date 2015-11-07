using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    public interface IAdminService
    {
        IEnumerable<Admin> GetList();
        void AddEntity(Admin admin);
        void UpdateEntity(Admin admin);
        void DeleteEntity(Admin admin);
        IQueryable<OrderLine> GetList(Expression<Func<Order, bool>> query);
        Admin GetEntity<T>(int Id);
    }
}
