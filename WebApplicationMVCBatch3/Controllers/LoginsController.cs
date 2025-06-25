using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Xml.Linq;
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
            ClaimsIdentity Identity = null;
            bool IsAuth = false;

            bool res1 = _db.Users.Any(x => x.Email == obj.Email && x.Password == obj.Password);
            if (res1 == true)
            {
                var mydata = _db.Users.FirstOrDefault(x => x.Email == obj.Email && x.Password == obj.Password);


                HttpContext.Session.SetString("Logintime", System.DateTime.Now.ToShortTimeString());
                HttpContext.Session.SetString("LoginName", mydata.Name);



                Identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Email,obj.Email),
                  new Claim(ClaimTypes.Role,mydata.Role),
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                IsAuth = true;


                if (IsAuth == true)
                {
                  
                    var prin = new ClaimsPrincipal(Identity);
                    var redirect = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, prin);
                    return RedirectToAction("GetUsersData", "Accounts", redirect);

                }
            }
            else
            {
                TempData["res"] = "Email or password is not corect !";
                return View();
            }
            return View();

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["res"] = "You have been logged out successfully!";
            return RedirectToAction("LoginUser", "Logins");
        }



        [HttpGet]
        public IActionResult AUthUser()
        {

            //Identity the user and Giving roles to the user , ClaimIdentity
            return View();

        }



        [HttpPost]
        public IActionResult AUthUser(LoginModel obj)
        {



            ClaimsIdentity iden = null;
            bool IsAuthentic = false;

            if (obj.Email == "admin@yahoo.com" && obj.Password == "123")
            {
                iden = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Email,obj.Email),
                  new Claim(ClaimTypes.Role,"Admin"),
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                IsAuthentic = true;
            }

            if (obj.Email == "user@yahoo.com" && obj.Password == "123")
            {
                iden = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Email,obj.Email),
                  new Claim(ClaimTypes.Role,"User"),
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                IsAuthentic = true;
            }



            if (IsAuthentic == true)
            {
                HttpContext.Session.SetString("Logintime", System.DateTime.Now.ToShortTimeString());
                HttpContext.Session.SetString("LoginName", obj.Email);
                var prin = new ClaimsPrincipal(iden);
                var redirect = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, prin);
                return RedirectToAction("GetUsersData", "Accounts", redirect);

            }

            //Identity the user and Giving roles to the user , ClaimIdentity
            return View();

        }

    }
}
