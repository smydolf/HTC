using System.Collections.Generic;
using System.Linq;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCSERVICES.Interface;

namespace HTCSERVICES
{
    public class ProductService : Repository<Products>, IProductService
    {
        public ProductService(HtcEfDbContext context) : base(context)
        {
        }

        public List<Products> GetAll()
        {
            return Context.Set<Products>().ToList();
        }

        public Products GetById(int id)
        {
            return Context.Set<Products>().Find(id);
        }

        public void Update(Products products)
        {
            base.UpdateEntity(products);
        }

        public void Delete(Products products)
        {
            base.DeleteEntity(products);
            
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            Context.Set<Products>().Remove(toDelete);
            
        }

        public void AddNew(Products products)
        {
            base.AddEntity(products);
        }
    }

}
