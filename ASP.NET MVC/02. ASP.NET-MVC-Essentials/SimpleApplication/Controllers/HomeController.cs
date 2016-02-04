using System.Collections.Generic;
using System.Web.Mvc;
using SimpleApplication.Models;

namespace SimpleApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View(new PartialModel() { partialModel = Sampledetails() });
        }

        private List<PartialModel> Sampledetails()
        {
            List<PartialModel> model = new List<PartialModel>();

            model.Add(new PartialModel()
            {
                Name = "Rima",
                Age = 20,
                Address = "Kannur"
            });

            model.Add(new PartialModel()
            {
                Name = "Rohan",
                Age = 23,
                Address = "Ernakulam"
            });
            model.Add(new PartialModel()
            {
                Name = "Reshma",
                Age = 22,
                Address = "Kannur"
            });

            return model;
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
    }
}