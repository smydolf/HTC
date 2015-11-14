using System;
using System.Collections.Generic;
using System.Linq;
using HTC.DAL.EF;
using HTCDOMAIN.AbstractDB;
using HTCSERVICES.Interface;

namespace HTCSERVICES.NewServices
{
    public class OrderService: Repository<OrderDbObject>, IOrderService
    {
        public OrderService(HtcEfDbContext context) : base(context)
        {
        }

        public List<OrderDbObject> GetAll()
        {
            return Context.Set<OrderDbObject>().ToList();
        }

        public OrderDbObject GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<OrderDbObject>().Find(id);
        }

        public void Update(OrderDbObject order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            base.UpdateEntity(order);
        }

        public void Delete(OrderDbObject order)
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
            Context.Set<OrderDbObject>().Remove(toDelete);
        }

        public void AddNew(OrderDbObject order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            base.AddEntity(order);
        }
    }
}
