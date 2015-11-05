using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    public interface IDriverservice
    {

        List<Driver> GetAll();
        Driver GetById(int id);
        void Update(Driver driver);
        void Delete(Driver driver);
        void DeleteById(int id);
        void AddNew(Driver driver);
    }
}
