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
        List<OrderLine> GetAll();
        OrderLine GetById(int id);
        void Update(OrderLine orderLine);
        void Delete(OrderLine orderLine);
        void DeleteById(int id);
        void AddNew(OrderLine orderLine);
    }
}
