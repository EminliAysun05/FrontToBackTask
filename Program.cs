using FrontToBack.DataAccesLayer;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            //  builder.Services.AddMvc();
            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}"));

            //app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id}");
            //app.MapGet("/", () => "Hello World!");

            app.UseStaticFiles();
            //Ctrl+Shift+B


            //        app.MapControllerRoute(
            //name: "default",
            //pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
