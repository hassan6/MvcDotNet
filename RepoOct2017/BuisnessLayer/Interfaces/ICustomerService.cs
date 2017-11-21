using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace BuisnessLayer.Interfaces
{
   public interface ICustomerService<T> where T :Customer
    {
        IEnumerable<T> GetCustomerWithBillingDue(int days = 10, int month = 3);
        IEnumerable<T> GetOnlineCustomers();
        IEnumerable<T> GetPendingCustomerRegistrations();
        IEnumerable<T> GetPrimeCustomers();
        bool IsPrimeCustomer(int id);
    }
}
