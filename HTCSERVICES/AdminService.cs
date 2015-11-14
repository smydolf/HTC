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
    public class AdminService : Repository<Admin>, IAdminService
    {
        public AdminService(HtcEfDbContext context) : base(context)
        {
        }

        public List<Admin> GetAll()
        {
            return Context.Set<Admin>().ToList();
        }

        public Admin GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<Admin>().Find(id);
        }

        public void Update(Admin admin)
        {
            if (admin == null)
            {
                throw new ArgumentNullException(nameof(admin));
            }
            base.UpdateEntity(admin);
        }

        public void Delete(Admin admin)
        {
            if (admin == null)
            {
                throw new ArgumentNullException(nameof(admin));
            }
            base.DeleteEntity(admin);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<Admin>().Remove(toDelete);
        }

        public void AddNew(Admin admin)
        {
            if (admin == null)
            {
                throw new ArgumentNullException(nameof(admin));
            }
            base.AddEntity(admin);
        }
    }
}
