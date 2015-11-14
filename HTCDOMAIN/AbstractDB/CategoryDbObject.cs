using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
     [Table("Category")]
    public class CategoryDbObject :BaseClass
    {
        
        public string Name { get; set; }
    }
}
