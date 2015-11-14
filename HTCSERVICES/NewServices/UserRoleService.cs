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
    public class UserRoleService: Repository<UserRoleDbObject>, IUserRoleService
    {
        public UserRoleService(HtcEfDbContext context) : base(context)
        {
        }

        public List<UserRoleDbObject> GetAll()
        {
            return Context.Set<UserRoleDbObject>().ToList();
        }

        public UserRoleDbObject GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<UserRoleDbObject>().Find(id);
        }

        public void Update(UserRoleDbObject userRole)
        {
            if (userRole == null)
            {
                throw new ArgumentNullException(nameof(userRole));
            }
            base.UpdateEntity(userRole);
        }

        public void Delete(UserRoleDbObject userRole)
        {
            if (userRole == null)
            {
                throw new ArgumentNullException(nameof(userRole));
            }
            base.DeleteEntity(userRole);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<UserRoleDbObject>().Remove(toDelete);
        }

        public void AddNew(UserRoleDbObject userRole)
        {
            if (userRole == null)
            {
                throw new ArgumentNullException(nameof(userRole));
            }
            base.AddEntity(userRole);
        }
    }
}
