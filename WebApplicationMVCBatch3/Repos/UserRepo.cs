using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Users>> GetAllUsers()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<Users> GetUserByID(int Id)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.ID == Id);
        }

        public async Task UpdateUsers(Users obj)
        {
            _db.Users.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteUsers(int Id)
        {
            var res = _db.Users.Find(Id);
            if (res != null)
            {
                _db.Remove(res);
                await _db.SaveChangesAsync();
            }
        }
    }
}
