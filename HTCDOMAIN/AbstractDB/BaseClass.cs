using System;
using System.ComponentModel.DataAnnotations;

namespace HTCDOMAIN.AbstractDB
{
    public abstract class BaseClass
    {
        [Key]
        public Guid PrimaryKey { get; set; }
    }
}
