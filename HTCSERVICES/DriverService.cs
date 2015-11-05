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
            return Context.Set<Driver>().Find(id);
        }

        public void Update(Driver driver)
        {
            base.UpdateEntity(driver);
        }

        public void Delete(Driver driver)
        {
            //Context.Set<Driver>().Remove(driver);
            base.DeleteEntity(driver);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddNew(Driver driver)
        {
            base.AddEntity(driver);
        }
    }
}
