using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("Order")]
    public class OrderDbObject: BaseClass
    {
        public UserDbObject User { get; set; }
        public PurchaserDbObject Purchaser { get; set; }
        public OrderDetailDbObject OrderDetail { get; set; }
    }
}
