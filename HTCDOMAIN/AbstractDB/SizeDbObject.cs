using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("Size")]
    public class SizeDbObject: BaseClass
    {
        public string Name { get; set; }
    }
}
