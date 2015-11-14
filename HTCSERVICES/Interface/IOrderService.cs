using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    

    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int id);
        void Update(Order order);
        void Delete(Order order);
        void DeleteById(int id);
        void AddNew(Order order);
    }
}
