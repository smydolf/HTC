using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTCDOMAIN.Abstract
{
    [Table("Purchaser")]
    public abstract class Purchaser: BaseClass
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
