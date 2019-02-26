using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EoS.Models
{
    public class EoSContext : DbContext
    {
        public EoSContext (DbContextOptions<EoSContext> options)
            : base(options)
        {
        }

        public DbSet<EoS.Models.Company> Companies { get; set; }
        public DbSet<EoS.Models.Department> Departments { get; set; }
        public DbSet<EoS.Models.Employee> Employees { get; set; }
        public DbSet<EoS.Models.OrderDetails> OrderDetailses { get; set; }
        public DbSet<EoS.Models.OrderService> OrderServices { get; set; }
        public DbSet<EoS.Models.Role> Roles { get; set; }
        public DbSet<EoS.Models.Service> Services { get; set; }
        public DbSet<EoS.Models.ServiceType> ServiceTypes { get; set; }
        public DbSet<EoS.Models.Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>().HasKey(od => new {od.ServiceId , od.OrderServiceId});
        }




    }
}
