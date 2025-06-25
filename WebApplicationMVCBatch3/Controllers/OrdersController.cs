using Microsoft.AspNetCore.Mvc;
using WebApplicationMVCBatch3.Models;
using WebApplicationMVCBatch3.Repos;

namespace WebApplicationMVCBatch3.Controllers
{
    [SetSessionGlobally]
    public class OrdersController : Controller
    {

        public readonly IOrderRepo _obj;
        public OrdersController(IOrderRepo obj)
        {
            _obj = obj;
        }
        public async Task<IActionResult> Index()
        {
            var res = await _obj.GetAllOrders();
            return View(res);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Orders obj)
        {
            if (obj != null)
            {
                await _obj.AddOrders(obj);
                return RedirectToAction("index");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            if (Id != null)
            {
                var res = await _obj.GetOrdersByID(Id);
                return View(res);
            }
            return View();
        }


        [HttpPost]
        public IActionResult Edit(Orders obj)
        {
            if (obj != null)
            {
                _obj.UpdateOrders(obj);
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            if (Id != null)
            {
                var res = await _obj.GetOrdersByID(Id);
                return View(res);
            }
            return View();
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int Id)
        {
            if (Id != null)
            {
                _obj.DeleteOrders(Id);
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> Details(int Id)
        {
            if (Id != null)
            {
                var res = await _obj.GetOrdersByID(Id);
                return View(res);
            }
            return View();
        }

    }
}
