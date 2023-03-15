
using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext(DbContextOptions options) : base(options) { }
        public DbSet<ToDoTask> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    CategoryName="Important"
                },
                new Category()
                {
                    Id = 2,
                    CategoryName = "general"
                },
                new Category()
                {
                    Id = 3,
                    CategoryName = "High pirority"
                }
                );

            modelBuilder.Entity<Owner>().HasData(
                new Owner()
                {
                    Id = 1,
                    Name = "Aya",
                    Email = "aya@gmail.com"
                },
                new Owner()
                {
                    Id = 2,
                    Name = "Ahmed",
                    Email = "ahmed@gmail.com"
                },
                new Owner()
                {
                    Id = 3,
                    Name = "Salma",
                    Email = "salma@gmail.com"
                }
                );
        }
    }
}
