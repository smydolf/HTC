using System.ComponentModel.DataAnnotations.Schema;
using HTCDOMAIN.Abstract;

namespace HTCDOMAIN.AbstractDB
{
    [Table("User")]
    public class UserDbObject: BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRoleDbObject Role { get; set; }
    }
}
