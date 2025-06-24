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
                return RedirectToAction("GetUsersdata", "Accounts");
            }
            else
            {
                TempData["res"] = "Email or password is not corect !";
                return View();
            }

        }

    }
}
