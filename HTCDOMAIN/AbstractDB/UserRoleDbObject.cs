using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("UserRole")]
    public class UserRoleDbObject: BaseClass
    {
        public string Name { get; set; }
    }
}
