using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTC.DAL.EF;
using HTCDOMAIN.AbstractDB;
using HTCSERVICES.Interface;

namespace HTCSERVICES.NewServices
{
    public class OrderDetailService: Repository<OrderDetailDbObject>, IOrderDetailService
    {
        public OrderDetailService(HtcEfDbContext context) : base(context)
        {
        }
       
        public List<OrderDetailDbObject> GetAll()
        {
            return Context.Set<OrderDetailDbObject>().ToList();
        }

        public OrderDetailDbObject GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<OrderDetailDbObject>().Find(id);
        }

        public void Update(OrderDetailDbObject orderDetail)
        {
            if (orderDetail == null)
            {
                throw new ArgumentNullException(nameof(orderDetail));
            }
            base.UpdateEntity(orderDetail);
        }

        public void Delete(OrderDetailDbObject orderDetail)
        {
            if (orderDetail == null)
            {
                throw new ArgumentNullException(nameof(orderDetail));
            }
            base.DeleteEntity(orderDetail);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<OrderDetailDbObject>().Remove(toDelete);
        }

        public void AddNew(OrderDetailDbObject orderDetail)
        {
            if(orderDetail == null)
            {
                throw new ArgumentNullException(nameof(orderDetail));
            }
            base.AddEntity(orderDetail);
        }
    }
}
