using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.Abstract;

namespace HTCSERVICES.Interface
{
    public interface IAddressService
    {
        List<Address> GetAll();
        Address GetById(int id);
        void Update(Address address);
        void Delete(Address address);
        void DeleteById(int id);
        void AddNew(Address address);
    }
}
