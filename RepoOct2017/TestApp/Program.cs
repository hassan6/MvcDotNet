using System;
using DataStore;
using BuisnessLayer;
using System.Collections.Generic;
using BuisnessLayer.Implementations;
using BuisnessLayer.Interfaces;
using System.Linq;
using System.Data;
using TestApp.DataHelper;

namespace TestApp
{
    class Program
    {
        private static object results;

        static void Main(string[] args)
        {
           // var customers = CutomerDataHelper.GetCustomer();
            //var employees = EmployeeDataGenerator.GetEmployee();
            CustomerService customerService1 = new CustomerService();// This has all the methods.
            ICustomerService<Customer> customerService2 = new CustomerService();// This has methods only from ICutomerService
            IBaseRepository<Customer> customerService3 = new CustomerService();//This has mehtodds only from IBaseRpeository
            var employeeService = new EmployeeService();
            //customerService.


            var custResult = from c in CustomerDataGenerator.GetCustomer()

                             select c;

            foreach (var cust in custResult)
            {
                Console.WriteLine("{0}, {1}", cust.Id,cust.FirstName);
            }
            Console.ReadKey();


            Console.WriteLine("Hello World!");
        }
    }
}
