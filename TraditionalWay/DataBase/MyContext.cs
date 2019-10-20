using Microsoft.EntityFrameworkCore;

namespace TraditionalWay.DataBase
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


            modelBuilder.Entity<Address>()
                .ToTable("Addresses")
                .HasKey(a => a.Id);
        }
    }
}
