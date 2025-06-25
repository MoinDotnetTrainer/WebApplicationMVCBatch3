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

        public DbSet<Patient> patients { get; set; }  // table

        public DbSet<PatientAddress> patientAddress { get; set; }

        public DbSet<One> ones { get; set; }  // table      

        public DbSet<Two> twos { get; set; }  // table  
        public DbSet<User> user { get; set; }  // table      

        public DbSet<UserProfile> userProfile { get; set; }  // table  
        public DbSet<Emp> emps { get; set; }

        public DbSet<Location> locations { get; set; }  // table

        public DbSet<Country> countries { get; set; }  // table 

        public DbSet<States> States { get; set; }  // table 

        public DbSet<Students> students { get; set; }  // table 

        public DbSet<Books> books { get; set; }  // table 

    }
}
