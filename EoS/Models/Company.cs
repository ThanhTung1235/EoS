using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EoS.Models
{
    public class Company
    {
        public Company()
        {
            this.Status = Status.Active;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Active = 1,
        Deactive = 0
    }
}
