using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    public interface IUserRoleService
    {
        List<UserRoleDbObject> GetAll();
        UserRoleDbObject GetById(int id);
        void Update(UserRoleDbObject userRole);
        void Delete(UserRoleDbObject userRole);
        void DeleteById(int id);
        void AddNew(UserRoleDbObject userRole);
    }
}
