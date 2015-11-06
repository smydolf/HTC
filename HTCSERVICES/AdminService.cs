using System;
using System.Linq;
using System.Linq.Expressions;
using HTC.DAL;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCSERVICES.Interface;

namespace HTCSERVICES
{
    public class AdminService : Repository<Admin>, IAdminService
    {
        public AdminService(HtcEfDbContext context) : base(context)
        {
        }

        void IAdminService.AddEntity(Admin admin)
        {
            base.AddEntity(admin);
        }

        void IAdminService.DeleteEntity(Admin admin)
        {
            base.DeleteEntity(admin);
        }

        Admin IAdminService.GetEntity<T>(int Id)
        {
            return base.GetEntity(Id);
        }

        IQueryable<Admin> IAdminService.GetList()
        {
            return base.GetList();
        }

        IQueryable<OrderLine> IAdminService.GetList(Expression<Func<Order, bool>> query)
        {
            throw new NotImplementedException("dupa");
        }

        void IAdminService.UpdateEntity(Admin admin)
        {
            base.UpdateEntity(admin);
        }
    }
}
