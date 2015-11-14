using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HTC.DAL;
using HTC.DAL.EF;
using HTCDOMAIN;
using HTCDOMAIN.Abstract;
using HTCSERVICES.Interface;

namespace HTCSERVICES
{
    public class DriverService : Repository<Driver>, IDriverservice
    {
        public DriverService(HtcEfDbContext context) : base(context)
        {
        }

        public List<Driver> GetAll()
        {
            return Context.Set<Driver>().ToList();
        }

        public Driver GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<Driver>().Find(id);
        }

        public void Update(Driver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver));
            }
            base.UpdateEntity(driver);
        }

        public void Delete(Driver driver)
        {
            //Context.Set<Driver>().Remove(driver);
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver));
            }
            base.DeleteEntity(driver);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<Driver>().Remove(toDelete);
        }

        public void AddNew(Driver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver));
            }
            base.AddEntity(driver);
        }

        //Co to jest ? 
        public static implicit operator DriverService(ProductService v)
        {
            throw new NotImplementedException();
        }
    }
}
