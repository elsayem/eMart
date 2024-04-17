using eMart.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace eMart.Presentaion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //register db service
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("eMartConnectionString"));
            });






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
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //      name: "areas",
            //      pattern: "{area:Admin}/{controller=Category}/{action=Index}/{id?}"
            //    );
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");

            //});


            app.MapControllerRoute(
                name: "Default",

                pattern: "{controller=Home}/{action=Index}/{id?}"
                //pattern: "{area=Admin}/{controller=Category}/{action=Index}/{id?}"
                );


            app.MapControllerRoute(
                name: "areas",
                //pattern: "{controller=Home}/{action=Index}/{id?}");
                pattern: "{area=Admin}/{controller=Category}/{action=edit}/{id?}"
                );


            app.Run();
        }
    }
}
