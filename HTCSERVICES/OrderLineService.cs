using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTC.DAL;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCSERVICES.Interface;

namespace HTCSERVICES
{
    public class OrderLineService : Repository<OrderLine>, IOrderLineService
    {
        public OrderLineService(HtcEfDbContext context) : base(context)
        {
        }

        public List<OrderLine> GetAll()
        {
            return Context.Set<OrderLine>().ToList();
        }

        public OrderLine GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<OrderLine>().Find(id);
        }

        public void Update(OrderLine orderLine)
        {
            if (orderLine == null)
            {
                throw new ArgumentNullException(nameof(orderLine));
            }
            base.UpdateEntity(orderLine);
        }

        public void Delete(OrderLine orderLine)
        {
            if (orderLine == null)
            {
                throw new ArgumentNullException(nameof(orderLine));
            }
            base.DeleteEntity(orderLine);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<OrderLine>().Remove(toDelete);
        }

        public void AddNew(OrderLine orderLine)
        {
            if (orderLine == null)
            {
                throw new ArgumentNullException(nameof(orderLine));
            }
            base.AddEntity(orderLine);
        }
    }
}
