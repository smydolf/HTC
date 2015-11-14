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
    public class SizeService: Repository<SizeDbObject>, ISizeService
    {
        public SizeService(HtcEfDbContext context) : base(context)
        {
        }

        public List<SizeDbObject> GetAll()
        {
            return Context.Set<SizeDbObject>().ToList();
        }

        public SizeDbObject GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<SizeDbObject>().Find(id);
        }

        public void Update(SizeDbObject size)
        {
            if (size == null)
            {
                throw new ArgumentNullException(nameof(size));
            }
            base.UpdateEntity(size);
        }

        public void Delete(SizeDbObject size)
        {
            if (size == null)
            {
                throw new ArgumentNullException(nameof(size));
            }
            base.DeleteEntity(size);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<SizeDbObject>().Remove(toDelete);
        }

        public void AddNew(SizeDbObject size)
        {
            if (size == null)
            {
                throw new ArgumentNullException(nameof(size));
            }
            base.AddEntity(size);
        }
    }
}
