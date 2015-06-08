using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace hiro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

           
        public IActionResult PatientBanner()
        {
            return View();
        }


        public IActionResult PatientList()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }

        public IActionResult TelephoneNumber()
        {
            return View();
        }

        public IActionResult Date()
        {
            return View();
        }

        public IActionResult NhsNumber()
        {
            return View();
        }

        public IActionResult Gender()
        {
            return View();
        }

        public IActionResult PatientName()
        {
            return View();
        }

        public IActionResult Snomed()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
