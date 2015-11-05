using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTCDOMAIN.Abstract
{
    public class OrderLine :DomainObject
    {
        public OrderLine(Order order, Products product, int quantity)
        {
            this.Order = order;
            this.Product = product;
            this.Quantity = quantity;
            CalculateTotal();
        }

        public Products Product { get; set; }

        public Order Order { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
        public Size Size { get; set; }


        public void CalculateTotal()
        {
            Total = (decimal) (Product.Price * Quantity);  
        }

    }
}
