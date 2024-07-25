using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Model(int year, string name)
        {
            var car = new CarModel { Name = name,Year=year };
            
            return View(car);
        }

    }
}
