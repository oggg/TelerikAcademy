using System.Web.Mvc;
using Calculator.Models;
using Calculator.Services;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var theModel = (TempData["Result"] != null) ? TempData["Result"] : Constants.TheModel;

            TempData["Result"] = null;
            return View(theModel);
        }

        // POST: Calculator/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                var quantity = int.Parse(collection["Quantity"]);

                var kilo = int.Parse(collection["Kilo"]);
                var systemSIType = collection["Type"];

                var calc = new CalculatorService(quantity, kilo, systemSIType);
                var result = calc.Result();

                var resultModel = new InputModel()
                {
                    Quantity = quantity,
                    Kilo = Constants.Kilos,
                    Type = result
                };

                TempData["Result"] = resultModel;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
