using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EoS.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
