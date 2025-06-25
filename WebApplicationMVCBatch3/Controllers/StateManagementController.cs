using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVCBatch3.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult StoreData()  // to its corresponding view only
        {

            ViewBag.res = "Some Data from ViewBag";  // its scope 
            ViewData["res1"] = "Some Data from ViewData";  // its view
            TempData["res2"] = "Some Data from temp Data";  // scope 
                                                            //  return RedirectToAction("GetData", "StateManagement");
            return RedirectToAction("GettingData", "Sample");


            //return View();
        }
        public IActionResult GetData()
        {

            //store
            return RedirectToAction("NeedData", "StateManagement");

            //   return View();
        }

        public IActionResult NeedData()
        {
            return View();  // tempdata
        }
        public IActionResult SomeOtherData()
        {
            return View();
        }

        public IActionResult ViewDataEx()
        {
            List<string> list = new List<string>();

            list.Add("Data1");
            list.Add("Data2");
            list.Add("Data3");
            list.Add("Data4");
            list.Add("Data5");
            list.Add("Data6");

            //   ViewBag.vb = list;

            ViewData["vd"] = list;

            return View();
        }


        public IActionResult CookieEx()
        {

            CookieOptions obj = new CookieOptions();
            obj.Expires = DateTime.Now.AddDays(7); // 1 day
            Response.Cookies.Append("Username", "xyz", obj);
            Response.Cookies.Append("email", "xyz@yahoo.com", obj);

            return View();
        }

        public IActionResult GetCookie() {
            return View();
        }
    }
}
