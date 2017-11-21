using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
   public class Customer : Base
    {
       public ICollection<Order> CustomerOrders { get; set; }
        public Customer():base()
        {

        }
    }
}
