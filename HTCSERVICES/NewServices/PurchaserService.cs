using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTC.DAL.EF;
using HTCDOMAIN.AbstractDB;
using HTCSERVICES.Interface;

namespace HTCSERVICES.NewServices
{
    public class PurchaserService: Repository<PurchaserDbObject>, IPurchaserService
    {
        public PurchaserService(HtcEfDbContext context) : base(context)
        {
        }

        public List<PurchaserDbObject> GetAll()
        {
            return Context.Set<PurchaserDbObject>().ToList();
        }

        public PurchaserDbObject GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<PurchaserDbObject>().Find(id);
        }

        public void Update(PurchaserDbObject purchaser)
        {
            if (purchaser == null)
            {
                throw new ArgumentNullException(nameof(purchaser));
            }
            base.UpdateEntity(purchaser);
        }

        public void Delete(PurchaserDbObject purchaser)
        {
            if (purchaser == null)
            {
                throw new ArgumentNullException(nameof(purchaser));
            }
            base.DeleteEntity(purchaser);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<PurchaserDbObject>().Remove(toDelete);
        }

        public void AddNew(PurchaserDbObject purchaser)
        {
            if (purchaser == null)
            {
                throw new ArgumentNullException(nameof(purchaser));
            }
            base.AddEntity(purchaser);
        }
    }
}
