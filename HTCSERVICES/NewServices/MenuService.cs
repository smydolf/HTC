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
    public class MenuService: Repository<MenuDbObject>, IMenuService
    {
        public MenuService(HtcEfDbContext context) : base(context)
        {
        }

        public List<MenuDbObject> GetAll()
        {
            return Context.Set<MenuDbObject>().ToList();
        }

        public MenuDbObject GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<MenuDbObject>().Find(id);
        }

        public void Update(MenuDbObject menu)
        {
            if (menu == null)
            {
                throw new ArgumentNullException(nameof(menu));
            }
            base.UpdateEntity(menu);
        }

        public void Delete(MenuDbObject menu)
        {
            if (menu == null)
            {
                throw new ArgumentNullException(nameof(menu));
            }
            base.DeleteEntity(menu);
        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<MenuDbObject>().Remove(toDelete);
        }

        public void AddNew(MenuDbObject menu)
        {
            if (menu == null)
            {
                throw new ArgumentNullException(nameof(menu));
            }
            base.AddEntity(menu);
        }
    }
}
