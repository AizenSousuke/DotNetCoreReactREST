﻿// <auto-generated />
using System;
using DotNetCoreReactREST.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreReactREST.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetCoreReactREST.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "06b81209-2bd8-4b90-9ab9-749d785924fb",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "johnDoe@gmail.com",
                            EmailConfirmed = false,
                            IsAdmin = false,
                            LockoutEnabled = false,
                            PasswordHash = "password",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ba512964-13b3-4599-b21f-087c49b29ad6",
                            TwoFactorEnabled = false,
                            UserName = "JohnDoe"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d095506c-cb23-4fd5-9c2d-d3d34fe5dabe",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Jane_Doe@gmail.com",
                            EmailConfirmed = false,
                            IsAdmin = false,
                            LockoutEnabled = false,
                            PasswordHash = "password5",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8a56e582-1b62-40df-b44e-a3b1be848d26",
                            TwoFactorEnabled = false,
                            UserName = "Jane"
                        });
                });

            modelBuilder.Entity("DotNetCoreReactREST.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Sed justo exerci takimata nulla labore nonumy autem eirmod no",
                            Name = "Stet sit Category"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Sed justo exerci takimata nulla labore nonumy autem eirmod no",
                            Name = "Aliquam consectetuer Category"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Sed justo exerci takimata nulla labore nonumy autem eirmod no",
                            Name = "Et amet Category"
                        });
                });

            modelBuilder.Entity("DotNetCoreReactREST.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAnonymous")
                        .HasColumnType("bit");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "1",
                            Content = "I think this post rocks but i'm known for bad judgement",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAnonymous = false,
                            PostId = 1
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "2",
                            Content = "Your post sucks go home",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAnonymous = false,
                            PostId = 1
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = "2",
                            Content = "Cool Misaka!",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAnonymous = false,
                            PostId = 3
                        },
                        new
                        {
                            Id = 4,
                            ApplicationUserId = "1",
                            Content = "Cool Beans!",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAnonymous = true,
                            PostId = 4
                        });
                });

            modelBuilder.Entity("DotNetCoreReactREST.Entities.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CommentId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("DotNetCoreReactREST.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "1",
                            CategoryId = 1,
                            Content = "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 19, 17, 19, 372, DateTimeKind.Local).AddTicks(3885),
                            Title = "Autem nibh nulla nonumy lorem"
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "1",
                            CategoryId = 1,
                            Content = "Sea ullamcorper dolores tempor aliquyam sit sed diam elitr sed. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 19, 20, 19, 372, DateTimeKind.Local).AddTicks(8296),
                            Title = "Vero ipsum kasd in dolor"
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = "2",
                            CategoryId = 1,
                            Content = "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 20, 3, 19, 372, DateTimeKind.Local).AddTicks(8389),
                            Title = "Eos dolores suscipsetetur dolores sadipscing eos lorem"
                        },
                        new
                        {
                            Id = 4,
                            ApplicationUserId = "2",
                            CategoryId = 1,
                            Content = "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 20, 43, 19, 372, DateTimeKind.Local).AddTicks(8410),
                            Title = "Eos dolores suscipit consetetur dolores sadipscing eos lorem"
                        },
                        new
                        {
                            Id = 5,
                            ApplicationUserId = "2",
                            CategoryId = 1,
                            Content = "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 20, 13, 19, 372, DateTimeKind.Local).AddTicks(8427),
                            Title = "Eos dolors sadipscing eos lorem"
                        },
                        new
                        {
                            Id = 6,
                            ApplicationUserId = "2",
                            CategoryId = 1,
                            Content = "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 20, 3, 19, 372, DateTimeKind.Local).AddTicks(8446),
                            Title = "Eos dolores suscipit consetos lorem"
                        },
                        new
                        {
                            Id = 7,
                            ApplicationUserId = "2",
                            CategoryId = 1,
                            Content = "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 19, 53, 19, 372, DateTimeKind.Local).AddTicks(8463),
                            Title = "Eotetur dolores sadipscing eos lorem"
                        },
                        new
                        {
                            Id = 8,
                            ApplicationUserId = "2",
                            CategoryId = 1,
                            Content = "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 19, 43, 19, 372, DateTimeKind.Local).AddTicks(8479),
                            Title = "Eos dolores suscMisakaipscing eos lorem"
                        },
                        new
                        {
                            Id = 9,
                            ApplicationUserId = "2",
                            CategoryId = 1,
                            Content = "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam",
                            DateTime = new DateTime(2020, 3, 21, 19, 33, 19, 372, DateTimeKind.Local).AddTicks(8530),
                            Title = "Eos doloAJAJAJcing eos lorem"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DotNetCoreReactREST.Entities.Comment", b =>
                {
                    b.HasOne("DotNetCoreReactREST.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Comments")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DotNetCoreReactREST.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DotNetCoreReactREST.Entities.Like", b =>
                {
                    b.HasOne("DotNetCoreReactREST.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DotNetCoreReactREST.Entities.Comment", "Comment")
                        .WithMany("Likes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DotNetCoreReactREST.Entities.Post", b =>
                {
                    b.HasOne("DotNetCoreReactREST.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Posts")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetCoreReactREST.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DotNetCoreReactREST.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DotNetCoreReactREST.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotNetCoreReactREST.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DotNetCoreReactREST.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
