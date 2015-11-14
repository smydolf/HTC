using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    public interface IUserService
    {
        List<UserDbObject> GetAll();
        UserDbObject GetById(int id);
        void Update(UserDbObject user);
        void Delete(UserDbObject user);
        void DeleteById(int id);
        void AddNew(UserDbObject user);
    }
}
