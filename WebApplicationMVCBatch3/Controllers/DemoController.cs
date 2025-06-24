using Microsoft.AspNetCore.Mvc;
using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Controllers
{
    public class DemoController : Controller
    {
        //Add View 


        [HttpGet]
        public IActionResult Add()
        {
            TempData["res"] = "No result on Load";
            return View();
        }

        [HttpPost]
        public IActionResult Add(Operations obj)
        {
            int z = obj.x + obj.y;
            TempData["res"] = $"Result of Addition is {z}";
            return View();
        }

        public IActionResult Sub()
        {
            return View();
        }
    }
}
