using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("Product")]
    public class ProductDbObject: BaseClass
    {
        public string Name { get; set; }
        public CategoryDbObject Category { get; set; }
    }
}
