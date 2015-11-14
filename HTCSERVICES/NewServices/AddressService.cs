using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCDOMAIN.AbstractDB;
using HTCSERVICES.Interface;

namespace HTCSERVICES.NewServices
{
    public class AddressService: Repository<AddressDbObject>, IAddressService
    {
        public AddressService(HtcEfDbContext context) : base(context)
        {
        }

        public List<AddressDbObject> GetAll()
        {
            return Context.Set<AddressDbObject>().ToList();
        }

        public AddressDbObject GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<AddressDbObject>().Find(id);
        }

        public void Update(AddressDbObject address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }
            base.UpdateEntity(address);
        }

        public void Delete(AddressDbObject address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }
            base.DeleteEntity(address);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<AddressDbObject>().Remove(toDelete);
        }

        public void AddNew(AddressDbObject address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }
            base.AddEntity(address);
        }
    }
}
