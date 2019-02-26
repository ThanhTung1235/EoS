using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace EoS.Models
{
    public class Service
    {
        public Service()
        {
            this.Status = Status.Active;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public Status Status { get; set; }
        public ServiceType ServiceType { get; set; }
        public List<OrderDetails> OrderDetailses { get; set; }
        public Company Company { get; set; }
        public Employee Employee { get; set; }
    }
    
}
