using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVCBatch3.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult CreateUser()
        {
            return View();
        }
        public IActionResult GettingData()
        {
            return View();
        }

    }
}
