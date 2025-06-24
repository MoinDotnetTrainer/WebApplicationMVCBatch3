using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Repos
{
    public interface IUserRespo
    {
        Task AddUsers(Users obj);
    }
}
