using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("OrderDetail")]
    public class OrderDetailDbObject: BaseClass
    {
        public MenuDbObject Menu { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
    }
}
