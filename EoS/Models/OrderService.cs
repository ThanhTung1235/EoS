using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EoS.Models
{
    public class OrderService
    {
        public OrderService()
        {
            this.Status = Status.Active;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public string TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime BillDate { get; set; }
        public Status Status { get; set; }
        public List<OrderDetails> OrderDetailses { get; set; }


    }
}
