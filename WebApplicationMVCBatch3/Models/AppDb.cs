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
        public DbSet<UserAccount> UserAccount { get; set; }  // table 

        public DbSet<AccountName> AccountName { get; set; }  // table 

        public DbSet<P1> p1 { get; set; }  // table 

        public DbSet<C1> c1 { get; set; }  // table 

        public DbSet<P12> p12 { get; set; }  // table 

        public DbSet<C12> c12 { get; set; }  // table 


    }
}
