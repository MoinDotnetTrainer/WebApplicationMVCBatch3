using Microsoft.EntityFrameworkCore;
using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Repos
{
    public class Ordersrepo : IOrderRepo
    {

        AppDb _db;
        public Ordersrepo(AppDb db)
        {
            _db = db;
        }
        public async Task AddOrders(Orders obj)
        {
            if (obj != null)
            {
                await _db.Orders.AddAsync(obj);
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException(nameof(obj), "User object cannot be null");
            }
        }

        public async Task<List<Orders>> GetAllOrders()
        {

            //complex Queries with LINQ
            return await _db.Orders.ToListAsync();
        }

        public async Task<Orders> GetOrdersByID(int Id)
        {
            return await _db.Orders.FirstOrDefaultAsync(x => x.OrderID == Id);
        }

        public async Task UpdateOrders(Orders obj)
        {
            _db.Orders.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteOrders(int Id)
        {
            var res = _db.Orders.Find(Id);
            if (res != null)
            {
                _db.Remove(res);
                await _db.SaveChangesAsync();
            }
        }
    }
}

