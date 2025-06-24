using Microsoft.EntityFrameworkCore;
using WebApplicationMVCBatch3.Repos;

namespace WebApplicationMVCBatch3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Middleware config for db connection

            var constr = builder.Configuration.GetConnectionString("Constr");
            builder.Services.AddDbContext<Models.AppDb>(options =>
                options.UseSqlServer(constr));

            builder.Services.AddScoped<IUserRespo, UserRepo>();  // inject 
            builder.Services.AddScoped<IOrderRepo, Ordersrepo>();  // inject 


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Logins}/{action=LoginUser}/{id?}");

            app.Run();
        }
    }
}
