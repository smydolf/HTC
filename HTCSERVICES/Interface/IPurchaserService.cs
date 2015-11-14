using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    public interface IPurchaserService
    {
        List<PurchaserDbObject> GetAll();
        PurchaserDbObject GetById(int id);
        void Update(PurchaserDbObject purchaser);
        void Delete(PurchaserDbObject purchaser);
        void DeleteById(int id);
        void AddNew(PurchaserDbObject purchaser);
    }
}
