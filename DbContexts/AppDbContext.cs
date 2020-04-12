using Bogus;
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
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set cascading for user so that when it gets deleted, everything else reference to this gets deleted. Doesn't work. Error out on deleting comments which the user is deleted but the post is not created by the user. 

            modelBuilder.Entity<ApplicationUser>()
                .HasMany<Post>(p => p.Posts)
                .WithOne(a => a.ApplicationUser)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Post>()
                .HasMany<Comment>(c => c.Comments)
                .WithOne(p => p.Post)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comment>()
                .HasMany<Like>(l => l.Likes)
                .WithOne(c => c.Comment)
                .OnDelete(DeleteBehavior.Cascade);

            // Bogus Fake Data =============

            // Set the randomizer seed if you wish to generate repeatable data sets.
            Randomizer.Seed = new Random(123456);

            var userId = 1;

            // Users
            var fakeUsers = new Faker<ApplicationUser>()
                // Ensure all properties have rules. By default, StrictMode is false
                // Set a global policy by using Faker.DefaultStrictMode
                // .StrictMode(true)
                // postId is deterministic
                .RuleFor(o => o.Id, f => userId++.ToString())
                .RuleFor(o => o.UserName, f => f.Name.FirstName())
                .RuleFor(o => o.Email, f => f.Internet.Email(f.Name.FirstName()))
                .RuleFor(o => o.PasswordHash, f => "password");

            var categoryId = 1;

            // Category
            var fakeCategory = new Faker<Category>()
                // Ensure all properties have rules. By default, StrictMode is false
                // Set a global policy by using Faker.DefaultStrictMode
                // .StrictMode(true)
                // postId is deterministic
                .RuleFor(o => o.Id, f => categoryId++)
                .RuleFor(o => o.Name, f => f.Random.Word())
                .RuleFor(o => o.Description, f => f.Random.Words());

            var postId = 1;

            // Posts
            var fakePosts = new Faker<Post>()
                // Ensure all properties have rules. By default, StrictMode is false
                // Set a global policy by using Faker.DefaultStrictMode
                // .StrictMode(true)
                // postId is deterministic
                .RuleFor(o => o.Id, f => postId++)
                .RuleFor(o => o.CategoryId, f => f.Random.Int(1, 5))
                .RuleFor(o => o.ApplicationUserId, f => f.Random.Int(1, 3).ToString())
                .RuleFor(o => o.Title, f => f.Lorem.Sentence())
                .RuleFor(o => o.Description, f => f.Lorem.Sentence())
                .RuleFor(o => o.Content, f => f.Lorem.Sentence())
                .RuleFor(o => o.DateTime, f => f.Date.Past());

            var commentId = 1;

            // Category
            var fakeComment = new Faker<Comment>()
                // Ensure all properties have rules. By default, StrictMode is false
                // Set a global policy by using Faker.DefaultStrictMode
                // .StrictMode(true)
                // postId is deterministic
                .RuleFor(o => o.Id, f => commentId++)
                .RuleFor(o => o.ApplicationUserId, f => f.Random.Int(1, 3).ToString())
                .RuleFor(o => o.PostId, f => f.Random.Int(1, 3))
                .RuleFor(o => o.Content, f => f.Random.Words())
                .RuleFor(o => o.IsAnonymous, f => f.Random.Bool(0.5f));

            // Generate the data
            modelBuilder.Entity<ApplicationUser>().HasData(
                fakeUsers.Generate(50)
            );

            modelBuilder.Entity<Category>().HasData(
                fakeCategory.Generate(50)
            );

            modelBuilder.Entity<Post>().HasData(
                fakePosts.Generate(50)
            );

            modelBuilder.Entity<Comment>().HasData(
                fakeComment.Generate(50)
            );
            // ==============================
        }

    }
}
