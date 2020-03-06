using DotNetCoreReactREST.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DotNetCoreReactREST.DbContexts
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //ApplicationUser DbSet is inherited
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<UpVote> UpVotes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Id = "1", UserName = "JohnDoe", PasswordHash = "password" },
                new ApplicationUser { Id = "2", UserName = "Jane", PasswordHash = "password2" });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "Stet sit Category",
                Description = "Sed justo exerci takimata nulla labore nonumy autem eirmod no"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 2,
                Name = "Aliquam consectetuer Category",
                Description = "Sed justo exerci takimata nulla labore nonumy autem eirmod no"
            });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 3,
                Name = "Et amet Category",
                Description = "Sed justo exerci takimata nulla labore nonumy autem eirmod no"
            });

            modelBuilder.Entity<Post>().HasData(new Post()
            {
                Id = 1,
                CategoryId = 1,
                ApplicationUserId = "1",
                Title = "Autem nibh nulla nonumy lorem",
                Content = "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                DateTime = DateTime.Now
            });

            modelBuilder.Entity<Post>().HasData(new Post()
            {
                Id = 2,
                CategoryId = 1,
                ApplicationUserId = "1",
                Title = "Vero ipsum kasd in dolor",
                Content = "Sea ullamcorper dolores tempor aliquyam sit sed diam elitr sed. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                DateTime = DateTime.Now.AddMinutes(3)
            });

            modelBuilder.Entity<Post>().HasData(new Post()
            {
                Id = 3,
                CategoryId = 1,
                ApplicationUserId = "2",
                Title = "Eos dolores suscipit consetetur dolores sadipscing eos lorem",
                Content = "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                DateTime = DateTime.Now.AddMinutes(6)
            });
        }

    }
}
