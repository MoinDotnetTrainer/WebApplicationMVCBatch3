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
                return RedirectToAction("GetUsersData");
            }
            else
            {
                TempData["res"] = "Error in Adding User";
            }
            return View();
        }

        public async Task<IActionResult> GetUsersData()
        {
            var res =await _db.GetAllUsers();
            return View(res);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var res =await _db.GetUserByID(Id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Users obj)
        {
            var res = _db.UpdateUsers(obj);
            return RedirectToAction("GetUsersData");
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            var res =await _db.GetUserByID(Id);
            return View(res);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int Id)
        {
            var res = _db.DeleteUsers(Id);
            return RedirectToAction("GetUsersData");
        }


        [HttpGet]
        public async Task<IActionResult> Details(int Id)
        {
            var res = await _db.GetUserByID(Id);
            return View(res);
        }

    }
}
