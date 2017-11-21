using BuisnessLayer.Implementations;
using BuisnessLayer.Interfaces;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcApp.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService<Customer> customerService= new CustomerService();
        // GET: Customer
        public ActionResult Index()
        {
           
            return View();
        }
    }
}