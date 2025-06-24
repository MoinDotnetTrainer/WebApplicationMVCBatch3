using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Repos
{
    public interface IOrderRepo
    {
        Task AddOrders(Orders obj);  // Insert

        Task<List<Orders>> GetAllOrders();  // all table info

        Task<Orders> GetOrdersByID(int Id);  // ID , not a list 

        Task UpdateOrders(Orders obj);

        Task DeleteOrders(int Id);
    }
}
