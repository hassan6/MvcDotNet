using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
   public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderAmount { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer OrderCustomer { get; set; }
    }
}
