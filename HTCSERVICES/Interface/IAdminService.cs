using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    public interface IAdminService
    {
        List<Admin> GetAll();
        Admin GetById(int id);
        void Update(Admin admin);
        void Delete(Admin admin);
        void DeleteById(int id);
        void AddNew(Admin admin);
    }
}
