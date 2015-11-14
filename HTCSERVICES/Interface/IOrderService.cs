using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    

    public interface IOrderService
    {
        List<OrderDbObject> GetAll();
        OrderDbObject GetById(int id);
        void Update(OrderDbObject order);
        void Delete(OrderDbObject order);
        void DeleteById(int id);
        void AddNew(OrderDbObject order);
    }
}
