using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("Menu")]
    public class MenuDbObject: BaseClass
    {
        public ProductDbObject Product { get; set; }
        public SizeDbObject Size { get; set; }
        public decimal Price { get; set; }
    }
}
