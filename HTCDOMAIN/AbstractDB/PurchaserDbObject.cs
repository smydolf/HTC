using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("Purchaser")]
    public class PurchaserDbObject: BaseClass
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public AddressDbObject Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
