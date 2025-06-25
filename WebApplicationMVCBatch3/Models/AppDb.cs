using Microsoft.EntityFrameworkCore;

namespace WebApplicationMVCBatch3.Models
{
    public class AppDb : DbContext  // conn
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }  // table

        public DbSet<Orders> Orders { get; set; }  // table

        public DbSet<Husband> husbands { get; set; }  // table

        public DbSet<Wife> wives { get; set; }  // table
    }
}
