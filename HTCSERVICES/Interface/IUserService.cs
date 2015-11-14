using System.Collections.Generic;
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
