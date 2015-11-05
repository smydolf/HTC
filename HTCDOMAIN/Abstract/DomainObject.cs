using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTCDOMAIN
{
    public abstract class DomainObject
    {
        public Guid PrimaryKey { get; set; }
    }
}
