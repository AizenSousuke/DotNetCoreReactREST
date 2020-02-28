using DotNetCoreReactREST.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "Sample Category",
                Description = "Sed justo exerci takimata nulla labore nonumy autem eirmod no"
            });

            modelBuilder.Entity<Post>().HasData(new Post()
            {
                Id = 1,
                CategoryId = 1,
                Title = "Autem nibh nulla nonumy lorem",
                Content = "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                DateTime = DateTime.Now
            });

            modelBuilder.Entity<Post>().HasData(new Post()
            {
                Id = 2,
                CategoryId = 1,
                Title = "Autem nibh nulla nonumy lorem",
                Content = "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                DateTime = DateTime.Now.AddMinutes(3)
            });

            modelBuilder.Entity<Post>().HasData(new Post()
            {
                Id = 3,
                CategoryId = 1,
                Title = "Autem nibh nulla nonumy lorem",
                Content = "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                DateTime = DateTime.Now.AddMinutes(6)
            });
        }

    }
}
