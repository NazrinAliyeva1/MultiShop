using Microsoft.EntityFrameworkCore;
using MultiShopTask.Models;

namespace MultiShopTask.DataAccesLayer
{
    public class MultiShopContext : DbContext
    {
        public MultiShopContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-PVUROI38\\SQLEXPRESS; Database=MultiTask; Trusted_Connection=True;TrustServerCertificate=true;");
            base.OnConfiguring(options);
        }
    }
}
