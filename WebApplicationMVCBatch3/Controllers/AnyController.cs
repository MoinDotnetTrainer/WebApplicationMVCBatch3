using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVCBatch3.Controllers
{

    //  [Route("[controller]/[action]")]  // Default it take controller name and action name
    //  [Route("[controller]")]  // we need to specify the cation name

    [Route("MyOps")]


    public class AnyController : Controller
    {

        [Route("MyData")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Get/{id?}")]
        public IActionResult Get()
        {
            return View();
        }

    }
}
