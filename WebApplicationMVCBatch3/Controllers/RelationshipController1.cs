using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Controllers
{
    public class RelationshipController1 : Controller
    {

        public readonly AppDb _db;
        public RelationshipController1(AppDb db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
             var res = _db.husbands.Include(p => p.wife).ToList();

          
            return View(res);
        }

        public IActionResult PatientEx() {

            var res = _db.patients.Include(p => p.PatientAddress).ToList();
            return View(res);
        }

        public IActionResult PatientAddEx()
        {

            var res = _db.patientAddress.Include(p => p.Patient).ToList();
            return View(res);
        }
    }
}
