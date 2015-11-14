using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.Abstract;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    public interface IAddressService
    {
        List<AddressDbObject> GetAll();
        AddressDbObject GetById(int id);
        void Update(AddressDbObject address);
        void Delete(AddressDbObject address);
        void DeleteById(int id);
        void AddNew(AddressDbObject address);
    }
}
