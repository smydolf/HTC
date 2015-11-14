using System.Collections.Generic;
using System.Linq;

namespace HTCDOMAIN.Abstract
{
    public abstract class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Order> Order { get; set; }

        public virtual void AddOrder(Order order)
        {
            if (order == null)
            {
                Order = new List<Order>();
            }
            Order.Add(order);
        }
        public virtual void EditOrder(Order order)
        {
            // TODO write a body, na 99% to nie zadziała, trzeba będzie pewnie ręcznie podmienić dane na liście

            if (Order != null && Order.Contains(order))
            {
                {
                    var editOrder = Order.FirstOrDefault(x => x.PrimaryKey == order.PrimaryKey);
                    Order.Remove(editOrder);
                    AddOrder(order);
                }
            }

        }
    }
}
