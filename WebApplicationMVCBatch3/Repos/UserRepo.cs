using WebApplicationMVCBatch3.Models;

namespace WebApplicationMVCBatch3.Repos
{

    public class UserRepo : IUserRespo
    {

        AppDb _db;
        public UserRepo(AppDb db)
        {
            _db = db;
        }

        public async Task AddUsers(Users obj)
        {
            if (obj != null)
            {
                await _db.Users.AddAsync(obj);
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException(nameof(obj), "User object cannot be null");
            }
        }

    }
}
