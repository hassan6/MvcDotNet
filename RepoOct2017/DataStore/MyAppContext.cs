using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
  public  class MyAppContext : DbContext
    {
        public MyAppContext()
        {
                    
        }
        public DbSet<Customer> Cutomer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
