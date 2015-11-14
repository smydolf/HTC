using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    public interface ICategoryService
    {
        List<CategoryDbObject> GetAll();
        CategoryDbObject GetById(int id);
        void Update(CategoryDbObject category);
        void Delete(CategoryDbObject category);
        void DeleteById(int id);
        void AddNew(CategoryDbObject category);
    }
}
