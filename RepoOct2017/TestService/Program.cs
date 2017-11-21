using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuisnessLayer.Implementations;
using DataLayer;

namespace TestService
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            customerService.Create(new Customer { FirstName = "Don", LastName = "Hizzo", Email = "text@ymail.com", DateofBirth=System.DateTime.Now.Date });
            var results = customerService.Get().ToList();
            foreach(var item in results)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
}
