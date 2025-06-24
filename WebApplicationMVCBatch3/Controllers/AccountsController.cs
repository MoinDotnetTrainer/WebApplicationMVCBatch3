using Microsoft.AspNetCore.Mvc;
using WebApplicationMVCBatch3.Models;
using WebApplicationMVCBatch3.Repos;

namespace WebApplicationMVCBatch3.Controllers
{
    public class AccountsController : Controller
    {

        public readonly IUserRespo _db;
        public AccountsController(IUserRespo db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Insert(Users obj)
        {
            if (ModelState.IsValid)
            {
                await _db.AddUsers(obj);
                TempData["res"] = "User Added Successfully";
                return RedirectToAction("Insert");
            }
            else
            {
                TempData["res"] = "Error in Adding User";
            }
            return View();
        }
    }
}
