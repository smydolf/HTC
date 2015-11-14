using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("Address")]
    public class AddressDbObject :BaseClass
    {
        public List<string> Name { get; set; }
    }
}
