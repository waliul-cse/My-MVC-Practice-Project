using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVClab02.Models;
namespace MVClab02.Controllers
{
    public class DisplayCustomerInfoController : Controller
    {
        // GET: DisplayCustomerInfo
        public ActionResult Index()
        {
            Customer custObj = new Customer();
            custObj.StudentId = 12032;
            custObj.Name = "Waliul";
            custObj.Amount = 40023;

            return View(custObj);
        }
    }
}