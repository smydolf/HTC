using System;
using System.Collections.Generic;
 
namespace HTCDOMAIN.Abstract
{
    public class Order :DomainObject
    {

        public DateTime DateTime { get; set; }

        public Address Adress { get; set; }
        public Driver Driver { get; set; }

        public IList<OrderLine> OrderLines { get; set; }

        public string StreetName { get; set; }

        public void AddProduct(Products product, int quantity)
        {
            if (OrderLines == null)
            {
                OrderLines = new List<OrderLine>();
            }
            OrderLines.Add(new OrderLine(this, product, quantity));

            //OrderLines == null ? OrderLines = new List<OrderLine>() : OrderLines.Add(new OrderLine(this, product,quantity));
        }
    }
}
