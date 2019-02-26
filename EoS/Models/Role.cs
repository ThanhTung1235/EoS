using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EoS.Models
{
    public class Role
    {
        public Role()
        {
            this.Status = Status.Active;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}
