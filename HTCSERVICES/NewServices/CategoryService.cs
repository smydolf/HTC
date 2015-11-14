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
    public class CategoryService: Repository<CategoryDbObject>, ICategoryService
    {
        public CategoryService(HtcEfDbContext context) : base(context)
        {
        }

        public List<CategoryDbObject> GetAll()
        {
            return Context.Set<CategoryDbObject>().ToList();
        }

        public CategoryDbObject GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<CategoryDbObject>().Find(id);
        }

        public void Update(CategoryDbObject category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            base.UpdateEntity(category);
        }

        public void Delete(CategoryDbObject category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            base.DeleteEntity(category);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<CategoryDbObject>().Remove(toDelete);
        }

        public void AddNew(CategoryDbObject category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            base.AddEntity(category);
        }
    }
}
