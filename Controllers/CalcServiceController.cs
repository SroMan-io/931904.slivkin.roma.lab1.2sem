using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class CalcServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            var calc1 = new CalcServices();

            return View(calc1);
        }

        public IActionResult PassUsingViewBag(Models.CalcServices calc)
        {               
            ViewBag.x = calc.x;
            ViewBag.y = calc.y;
            ViewBag.add = calc.add;
            ViewBag.sub = calc.sub;
            ViewBag.mult = calc.mult;
            ViewBag.div = calc.div;

            var calc1 = new CalcServices();

            return View(calc1);
        }

        public IActionResult PassUsingViewData(Models.CalcServices calc)
        {     
            ViewData["x"] = calc.x;           
            ViewData["y"] = calc.y;
            if (calc.y == 0) ViewData["Hund"] = ViewData["y"];
            ViewData["add"] = calc.add;
            ViewData["sub"] = calc.sub;
            ViewData["mult"] = calc.mult;
            ViewData["div"] = calc.div;

            var calc1 = new CalcServices();

            return View(calc1);
        }
        public IActionResult AccessServiceDirectly()
        {
            var calc1 = new CalcServices();

            return View(calc1);
        }
    }
}
