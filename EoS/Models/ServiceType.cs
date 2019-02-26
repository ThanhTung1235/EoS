using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EoS.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Service> Services { get; set; }
    }
}
