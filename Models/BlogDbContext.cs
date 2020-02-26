using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Vote> Vote { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get; set; }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Post 

            //modelBuilder.Entity<Post>()
            //    .Property(p => p.Id)
            //    .ValueGeneratedOnAdd();

            //modelBuilder.Entity<Post>()
            //    .Property(p => p.Title)
            //    .IsRequired();

            //modelBuilder.Entity<Post>()
            //    .Property(p => p.Content)
            //    .IsRequired();

            //modelBuilder.Entity<Post>()
            //    .Property(p => p.Created)
            //    .ValueGeneratedOnAdd();

            //modelBuilder.Entity<Post>()
            //    .Property(p => p.Modified)
            //    .ValueGeneratedOnAdd();

            //modelBuilder.Entity<Post>()
            //    .Property(p => p.UpVotes)
            //    .HasDefaultValue(0);

            //modelBuilder.Entity<Post>()
            //    .Property(p => p.DownVotes)
            //    .HasDefaultValue(0);

            //// Votes

            //modelBuilder.Entity<Vote>()
            //    .Property(p => p.Id)
            //    .ValueGeneratedOnAdd();

            //modelBuilder.Entity<Vote>()
            //    .Property(p => p.UpVotes)
            //    .HasDefaultValue(0);

            //modelBuilder.Entity<Vote>()
            //    .Property(p => p.DownVotes)
            //    .HasDefaultValue(0);

            //// Categories

            //modelBuilder.Entity<Categories>()
            //    .Property(p => p.Id)
            //    .ValueGeneratedOnAdd();

            //modelBuilder.Entity<Categories>()
            //    .Property(p => p.Name)
            //    .IsRequired();

            //modelBuilder.Entity<Categories>()
            //    .Property(p => p.Description)
            //    .HasDefaultValue(null);

            // Seed data
            modelBuilder.Entity<Post>()
                .HasData(new Post
                {
                    Id = 1,
                    Title = "Sample Title",
                    Content = "Lorem ipsum",
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                });
        }
        #endregion
    }
}
