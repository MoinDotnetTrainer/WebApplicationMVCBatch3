using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Repos
{
    public interface IUserRespo
    {
        Task AddUsers(Users obj);  // Insert

        Task<List<Users>> GetAllUsers();  // all table info

        Task<Users> GetUserByID(int Id);  // ID , not a list 

        Task UpdateUsers(Users obj);

        Task DeleteUsers(int Id);
    }
}
