using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    public interface IMenuService
    {
        List<MenuDbObject> GetAll();
        MenuDbObject GetById(int id);
        void Update(MenuDbObject menu);
        void Delete(MenuDbObject menu);
        void DeleteById(int id);
        void AddNew(MenuDbObject menu);
    }
}
