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
    public class CutomerOperationsController : Controller
    {
        private IBaseRepository<Customer> customerService = new CustomerService();
      
        // GET: CutomerOperations
        public ActionResult Index()
        {
            return View();
        }
    }
}