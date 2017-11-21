using BuisnessLayer.Interfaces;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BuisnessLayer.Implementations
{
    public class CustomerService : IBaseRepository<Customer>, ICustomerService<Customer>
    {
        private MyAppContext _ctx { get; set; }
        public CustomerService()
        {
            _ctx = new MyAppContext();
        }
        public bool Create(Customer o)
        {
            try
            {
                _ctx.Customer.Add(o);
                var result = _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool Delete(Customer id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            try
            {
                return _ctx.Customer.Where(s => s.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IEnumerable<Customer> Get()
        {
            return _ctx.Customer;
        }

        public IEnumerable<Customer> GetCustomerWithBillingDue(int days = 10, int month = 3)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetOnlineCustomers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetPendingCustomerRegistrations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetPrimeCustomers()
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer o)
        {
            throw new NotImplementedException();
        }
    }
}
