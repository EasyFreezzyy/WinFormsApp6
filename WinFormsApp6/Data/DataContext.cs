using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp6.Data
{
    public class DataContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<car> cars { get; set; }
        public DbSet<Corzina> corzinas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Задаем первоначальные данные
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "admin",
                Password = "admin123",
                Name="Владимир",
                Surname = "Меженин", 
                IsAdmin = true
            }, new User
            {
                Id = 2,
                Username = "user",
                Password = "user123",
                Name = "Володимир",
                Surname ="Меженин",
                IsAdmin = false
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Avtoservis;Trusted_Connection=True");

        }
    }
}
