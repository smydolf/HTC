using System;
using System.Collections.Generic;
using System.Linq;
using HTC.DAL.EF;
using HTCDOMAIN.Abstract;
using HTCDOMAIN.AbstractDB;
using HTCSERVICES.Interface;

namespace HTCSERVICES
{
    public class ProductService : Repository<ProductDbObject>, IProductService
    {
        public ProductService(HtcEfDbContext context) : base(context)
        {
        }

        public List<ProductDbObject> GetAll()
        {
            return Context.Set<ProductDbObject>().ToList();
        }
    
        public ProductDbObject GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<ProductDbObject>().Find(id);
        }

        public void Update(ProductDbObject product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            base.UpdateEntity(product);
        }

        public void Delete(ProductDbObject product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            base.DeleteEntity(product);
            
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<ProductDbObject>().Remove(toDelete);
            
        }

        public void AddNew(ProductDbObject product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            base.AddEntity(product);
        }
    }

}
