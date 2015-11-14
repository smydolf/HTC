using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTCDOMAIN.Abstract
{
    //public enum Address
    //{
    //    Muszyna,
    //    Krynica,
    //    Szczawnik,
    //    Zlockie, 
    //    Powroznik,
    //    Milik,
    //    Andrzejowka,
    //    Zegeistow
    //}
    [Table("Address")]
    public class Address
    {
        public int Id { get; set; }
        public List<string> Name { get; set; }
    }
}
