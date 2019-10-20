using Microsoft.EntityFrameworkCore;

namespace DemoOwned.DataBase
{
    public class MyContext : DbContext
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="options"></param>
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .ToTable("Restaurants")
                .HasKey(r => r.Id);

            modelBuilder.Entity<Restaurant>()
                .OwnsOne(p => p.Address)
                .ToTable("Addresses");
        }
    }
}
