using MultiShopTask.DataAccesLayer;

namespace MultiShopTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MultiShopContext>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute("{dafault}", "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
