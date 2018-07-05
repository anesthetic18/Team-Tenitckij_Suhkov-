using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WindowsFormsApplication1.TwoArgument;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "buttonAmount",
                    Text = "Amount"
                },
                new SelectListItem()
                {
                    Value = "buttonDifference",
                    Text = "Difference"
                }
            };
            return View();   
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstArgument, double secondArgument, string operation)
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstArgument, secondArgument);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "buttonAmount",
                    Text = "Amount"
                },
                new SelectListItem()
                {
                    Value = "buttonDifference",
                    Text = "Difference"
                }
            };
            return View();
        }
    }
}