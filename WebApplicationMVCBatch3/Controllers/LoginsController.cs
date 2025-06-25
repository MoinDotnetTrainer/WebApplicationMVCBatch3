using Microsoft.AspNetCore.Mvc;
using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Controllers
{
    public class LoginsController : Controller
    {

        AppDb _db;
        public LoginsController(AppDb db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginUser(LoginModel obj)
        {

            //var res = from s in _db.Users
            //          where s.Email == obj.Email && s.Password == obj.Password
            //          select s;

            bool res1 = _db.Users.Any(x => x.Email == obj.Email && x.Password == obj.Password);
            if (res1 == true)
            {
                var mydata = _db.Users.FirstOrDefault(x => x.Email == obj.Email && x.Password == obj.Password);

                HttpContext.Session.SetString("Logintime", System.DateTime.Now.ToShortTimeString());
                HttpContext.Session.SetString("LoginName", mydata.Name);
                return RedirectToAction("GetUsersdata", "Accounts");
            }
            else
            {
                TempData["res"] = "Email or password is not corect !";
                return View();
            }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["res"] = "You have been logged out successfully!";
            return RedirectToAction("LoginUser","Logins");
        }


    }
}
