using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTCDOMAIN.Abstract
{
    public class Admin : Person
    {
        private IList<Driver> Driver { get; set; }
        private IList<Products> Product { get; set; }

        private void DeleteDriver(Driver driver)
        {
            Driver.Remove(driver);
        }
        private void AddDriver(Driver driver)
        {
            Driver.Add(driver);
        }
        private void AddProductToBase(Products product)
        {
            Product.Add(product);
        }
        //private void DeleteOrder(Order order)
        //{
        //    if (Order != null && Order.Contains(order)) Order.Remove(order);
        //}
        //TODO
    }
}
