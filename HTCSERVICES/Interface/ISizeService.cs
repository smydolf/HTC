using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDOMAIN.AbstractDB;

namespace HTCSERVICES.Interface
{
    public interface ISizeService
    {
        List<SizeDbObject> GetAll();
        SizeDbObject GetById(int id);
        void Update(SizeDbObject size);
        void Delete(SizeDbObject size);
        void DeleteById(int id);
        void AddNew(SizeDbObject size);
    }
}
