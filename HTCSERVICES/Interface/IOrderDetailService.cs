using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    public interface IOrderDetailService
    {
        List<OrderDetailDbObject> GetAll();
        OrderDetailDbObject GetById(int id);
        void Update(OrderDetailDbObject orderDetail);
        void Delete(OrderDetailDbObject orderDetail);
        void DeleteById(int id);
        void AddNew(OrderDetailDbObject orderDetail);
    }
}
