using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HTC.DAL;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCSERVICES.Interface;

namespace HTCSERVICES
{
    public class OrderService: Repository<Order>, IOrderService
    {
        public OrderService(HtcEfDbContext context) : base(context)
        {
        }

        public List<Order> GetAll()
        {
            return Context.Set<Order>().ToList();
        }

        public Order GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<Order>().Find(id);
        }

        public void Update(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            base.UpdateEntity(order);
        }

        public void Delete(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            base.DeleteEntity(order);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<Order>().Remove(toDelete);
        }

        public void AddNew(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            base.AddEntity(order);
        }
    }
}
