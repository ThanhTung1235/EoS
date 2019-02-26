using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EoS.Models
{
    public class OrderDetails
    {
        public OrderDetails()
        {
            this.Status = Status.Active;
        }
        public int Id { get; set; }
        public int UnitPrice { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int NumberOfEmployee { get; set; }
        public Status Status { get; set; }
        public int ServiceId { get; set; }
        public int OrderServiceId { get; set; }
        public OrderService OrderService { get; set; }
        public Service Service { get; set; }
    }
}
