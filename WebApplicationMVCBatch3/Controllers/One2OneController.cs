using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Controllers
{
    public class One2OneController : Controller
    {

        public readonly AppDb _db;
        public One2OneController(AppDb db)
        {
            _db = db;
        }
        public IActionResult GetEmp()
        {
            var res = _db.emps.Include(p => p.Location).ToList();
            return View(res);
        }
        public IActionResult GetLoc()
        {
            var res = _db.locations.Include(p => p.Emp).ToList();
            return View(res);
        }

        public IActionResult GetCountry()
        {
            var res = _db.countries.Include(p => p.States).ToList();
            return View(res);
        }
        public IActionResult GetStdBooks()
        {
            var res = _db.students.Include(p => p.Books).ToList();
            return View(res);
        }


    }
}
