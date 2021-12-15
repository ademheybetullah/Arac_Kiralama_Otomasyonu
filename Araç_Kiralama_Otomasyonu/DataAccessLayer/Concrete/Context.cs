using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Renting> Rentings { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
