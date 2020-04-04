using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class BogusData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Content = table.Column<string>(maxLength: 50000, nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(maxLength: 1000, nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IsAnonymous = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    CommentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likes_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "IsAdmin", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "68b574c4-ae12-46ac-833f-33f2f3cf7677", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert.Johns@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEBKy9zEMrbuVqw1qW/C3MqJ84UEjzQc9KIOootQ6JS78MTGkYuhbJ9MxIi0TfmExQw==", null, false, "1cf0d5e4-c4b4-42f7-a6af-b488a88803dc", false, "Albert" },
                    { "28", 0, "db50053f-fade-4222-bbd0-025af579e69a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Derek.Ullrich@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEKyqE+ximL6N0XvrLzUBtOQ8Sq71Mzc6RWXbM2mYXOVxHgR0rx03++/stD8bF1+vMQ==", null, false, "bf4240cc-3c7c-4d12-8664-316cbef8570d", false, "Derek" },
                    { "29", 0, "a3c97409-2adb-4740-b682-fd914c3639af", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iris.Heaney@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEED840f3Xorh/P5gF5AYR4fCs496ggpPqdplmClMiKyx4ULSc6oaxZvbnQHpN7jjLA==", null, false, "1b64a713-df21-47a1-9505-a6a8be86a2e3", false, "Iris" },
                    { "30", 0, "38ed0b7b-3f09-4e0d-baef-97ceb3c0d63d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheri68@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAENCf3ox19/64OEWdD6Lhb3emR5P7siaoHTIbEx1Mdvf61yyh79hkTLJQOO7Prq9iXQ==", null, false, "1cb60b99-8f43-4546-b7cc-15d86de07ab8", false, "Sheri" },
                    { "31", 0, "7eff7a3a-64f6-4ffc-a9e8-4f7cf8669630", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven.Olson@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAECHptgzcYRhIQYeNsjGmUs3AqFDftIH+zo2I44HTVIZkbdww9YRbXllct56moj6Aog==", null, false, "4dbe12f9-41f1-4b1a-a19d-92e459dcb6c8", false, "Steven" },
                    { "32", 0, "00c9388d-3cbb-4d08-bc53-626b81023d37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doyle_Donnelly@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEKSzyAX3OxNlad0URTrZbSfV+4/rS+j6mYo1wUEzTA/HsyBmFRedK6Nzc4UwpknXQQ==", null, false, "fc9bb48d-f1fd-4974-b735-20b087170190", false, "Doyle" },
                    { "33", 0, "9a238fe7-ecb5-40a3-a408-390c9ffb1133", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyle.Schroeder@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEPBGCcB1APSkecVWWvjLDIAyd3A8xdLv1pxOa53g/+7VgjactuvDRI5BKxBN7C3vbg==", null, false, "429cee9a-e95e-4439-85ca-cafd1c3be640", false, "Kyle" },
                    { "34", 0, "8febc466-51c6-4663-bc53-40672c6cb527", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy_Gutmann@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEG8kiClw2qGrodlZX4QktRAjRlNYkNQKuGp2iydzfKzRls7Qos3lfZvd1ctcTuAxHQ==", null, false, "8135500a-e9a4-4685-9c3f-bbdda0ab9f3a", false, "Timothy" },
                    { "35", 0, "0531bc3d-800b-49e8-91b0-770a0f76721f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santiago_Abshire72@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDm/XfgMFfaigtVR3hcrSnf6MxZpCNlcCmyPfoPwI0t8L6mKJ9BxK4Mcdzz0xA70yQ==", null, false, "2e682c81-8f73-4599-8563-7aa732f49b12", false, "Santiago" },
                    { "36", 0, "4bf58fcc-b69b-411d-8f9a-74d2abe26ee7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freddie_Bruen39@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEPgMnfDAkQ9+9Vs6g486dGd7nIvM68LIk8vdftf4SYmW4gAfuYS6oP/z+eDOW2R/Cg==", null, false, "d0250c07-b27d-4933-859a-7ff7611c16f7", false, "Freddie" },
                    { "37", 0, "42f3357f-e2f9-4243-bb5d-c22f30415db8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cecelia.Ward66@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEPkv/YceakYtAN4FQrYRo17Ek+cgPWvHEH/JQ01ZSTpfqT+e6/uc13ZlRYx0WCYwtA==", null, false, "d2230d94-c282-4a1a-9a35-c6cddb75d743", false, "Cecelia" },
                    { "27", 0, "2e418135-bab3-4e95-8668-5e0caba0d91b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roland31@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEC5gm+kqF/OjaUBvGgHicsC9cY+794d4f+1JFgPPbR97gaLJ+JDgKliLx929/IJ62Q==", null, false, "25251c0e-398f-4608-9d78-58d2457dd4c5", false, "Roland" },
                    { "38", 0, "e0bf284d-bc97-48bf-82e5-a4f897f6c014", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ella.Strosin@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEhVVFTBgGXNc85iVBvJez+hRD9h99o66/QvEqZvHv/ZYNpGHa5Ihmt+FKM+8YtUkA==", null, false, "a006ce97-208a-4bd8-8a54-30ff9b5f8a26", false, "Ella" },
                    { "40", 0, "81bead6d-df3f-43f7-b45e-877762861352", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mack.Gibson@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEC3oSfyU8Mj7dlHKTlMEBYh9OspFsCiAetsD/G3pGlv7WpN5HqoBgh39fpZAdqCgTw==", null, false, "909c61e1-d49e-4d75-ae12-92fadc4018a8", false, "Mack" },
                    { "41", 0, "188001ba-f8e3-4f20-8067-2616e34c09ab", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel45@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEMLq0/pKGgA9vu+SJ2gy9spT+p0kE0/Iyw8PEHCqXwTz+N92aO6NGx2Npr336ynREg==", null, false, "2bf5e1e7-f5de-4ba8-9fe6-6b38e5d2c3b8", false, "Gabriel" },
                    { "42", 0, "4104774b-2eff-45b7-9d84-ad6eca6c7617", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olga45@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEJYq75fmZ4f5ddJqUQTWbyF9xvFJRWcE9/Jb4cQtrLM9linWu2OcWCx1oeDWdyVgmw==", null, false, "ac3daa8f-5d7b-466e-9bc4-e8c292b06546", false, "Olga" },
                    { "43", 0, "42d3e8cc-5a8b-49df-b5fe-f134955990cc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter_Kuhlman@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAENcIthLQWKunszrIiAeRIanfxH2uCed1I8WBWSmtWTRwfZquCpA8dMdxF4lWhNJg0Q==", null, false, "a222e829-000f-4a65-857b-227d1bd1e38a", false, "Walter" },
                    { "44", 0, "ced4db40-289d-49f4-bdbc-1f5ed60f582e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elsie_Keebler35@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEIJsPwwpbjOzyKejvIC0am/q7o3URBHRRsci1RijWMaa7sqhQKRSnRbKbBhxA9sYuA==", null, false, "914ab22c-d9e9-4f05-9210-ed3b9000352c", false, "Elsie" },
                    { "45", 0, "78beb6ff-152f-49ae-a3a2-d2f483ebcecd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfred_Bartoletti72@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDbDDj+gKu+2YlkUEaD7+q5WvZ5xjLXBdPE8ocPxaGZjw+X4uWfG5rSaNTCcr2O6Ug==", null, false, "e3ed1edc-29d4-4430-b5f5-da8d0d465c7f", false, "Alfred" },
                    { "46", 0, "35b359b4-49b2-4365-9c6c-be7e2b04a74f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnnie.Volkman25@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGQrjifvp0NdEANuthFbN41UevE9qeays/PuVYzEPSoANuDXSR7Pos4v3OEPDFcV3A==", null, false, "89ed157c-7b0f-4bf8-819d-20fb51869c43", false, "Johnnie" },
                    { "47", 0, "b640361f-0477-4512-8f30-2ed6aff726ef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgil.Gislason@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDIAtfNBFum2Jp+++03ciakKxvydO+avdY6zT31JcTiF4141IuxGa2PDTnU1GXws0w==", null, false, "32c8e740-ec9e-4ec3-a1e0-5bd898a59d29", false, "Virgil" },
                    { "48", 0, "7804e255-41dc-4ee3-bb9c-49576a78ba0b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geoffrey.Stracke83@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDTRgT200Rf+9u+wMW3VMKeOljrZmlD+Wqd06bYhdArHKLgggtUCDapTSHepNaya8g==", null, false, "c9c89614-b3ac-4b5a-a5c8-f7f14aac9235", false, "Geoffrey" },
                    { "49", 0, "dc77f5f9-eabe-41fb-bdc0-734a54774ccc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muriel_Upton@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGTkK3HDNf+8mp6jdLT+Mtvu26LX3X/821G6i66rxIFs+T3T5unYtsGz2/r7Df/3lQ==", null, false, "9e4a884b-3401-4adc-af71-ed1f348603b4", false, "Muriel" },
                    { "39", 0, "84e59f8a-3ef9-4ddd-8b45-a17420ecb3d2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeanette.Mills78@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEIB0W2WbLW4mK3iuHZhDXvDtDTbm/1BLtyHcfDLp8913n8aCcYUVcCIo5Dnl8nWx3Q==", null, false, "342f6e6f-03f7-44c0-9339-6b14d7bc67ef", false, "Jeanette" },
                    { "26", 0, "b96a2a01-64f2-4f05-ac24-2e1d33aa414d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramon60@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEFe+eM0idnQJRtLfWEoAyknjv6Xq1I7rOI8kodlXWdMJg+koCkPzoVwlaHPhW3ohTw==", null, false, "808f63c9-7b7b-46ea-b9ca-5052a0d61af9", false, "Ramon" },
                    { "50", 0, "691a3006-b224-415c-bd8d-848fffedbb84", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guadalupe96@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEKhpIHOuhIeFIIk1jUefRQMR3VxQXcrtteCKbVFZmaPbBYLmxuakK4Elc01UyvElCA==", null, false, "7eca2693-5f3b-4c76-91dc-eb3c40e7570e", false, "Guadalupe" },
                    { "24", 0, "9e8c008b-990a-4137-8a0d-b802b9875995", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randall44@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAELR5qZPiX+SVwBMMxWueKN/nMMZjzueG9Y6ERD3OQLNa2VkcHuWe+sTccy+0Ql6A3Q==", null, false, "b7c5e8ac-a67f-4eb5-ba7b-00c017d7af5d", false, "Randall" },
                    { "2", 0, "b9dc970b-3179-4052-9972-b1c4ca6e7dee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joel77@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGvKLJHRXcvbj5IVm/Ra3N5rwn3l+mYfd1dZD1ZkFkrn4YQ+lLkr4Gmykv89oOYE4w==", null, false, "7880932c-998a-4214-ba68-495762f5872c", false, "Joel" },
                    { "3", 0, "033772f6-7916-4ccc-b94c-05bbf993dad1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flora_Boyle@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEBGwAizBLek12qel+70E3tBSQUko6guM+ksGXei7RMIc5zH4bo5eNzVyCLrpx/elA==", null, false, "1385afc5-62e9-445f-9f6e-f740e395da32", false, "Flora" },
                    { "4", 0, "e0bf29cb-53a0-4e2c-8ee0-ab43f25a571f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doreen_Waters@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAED4J6fc5KNcMB+M8cMrANXcOmFq44w6B7JAMvqgKYEBGjFcVGoq1Ql2YvczH3jCh+Q==", null, false, "83124860-e68f-4ca9-9967-339c0e13b261", false, "Doreen" },
                    { "5", 0, "121f92b3-9bae-4ffc-a3ec-1e51e5ccebed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hector_Halvorson91@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEOq7VKNHCv8BmmIb5n9gjBQJCZ+AniPBQJeZ5sLrPqvDz4cmngBTIC+u/8zMOPWNDg==", null, false, "674e0ca1-97b9-42a6-a567-6500fc95813b", false, "Hector" },
                    { "6", 0, "ef075593-041e-4657-af55-c487ac0a800d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby_Will@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEB78L6J4yyc6Qwo91g2pmUvTaj4qAtzV8EQ1CMMm5SsTqbuP4vuDpK0KCGPhqQn3RQ==", null, false, "141bde6b-15f5-49c5-ac93-859e7f284aff", false, "Ruby" },
                    { "7", 0, "9a6ab076-eaa3-49fe-a70e-79d02815a13c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lonnie.Bernier9@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEWdRDgDrLShYHFwTWcCdg4tPu9Pm1qA54xEjE3RfLaSbAjXZJeEdU9McPvcc9LvxA==", null, false, "1859f394-feb9-4058-abca-9e19626e34ca", false, "Lonnie" },
                    { "25", 0, "7f8a1862-be12-4d50-a17c-bcaa55254c51", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lillian56@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEBQKwNRlFh/ATcjw6hFe9+KiymaaceQJgJpzjbuB1TL8Q+W58f0MLGvyjljra0bBPg==", null, false, "71ae0994-506b-4a40-8fa4-220d1f672599", false, "Lillian" },
                    { "9", 0, "72d4a687-3d14-449a-8b1a-a28bccbdfc11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristina_Stroman@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEMrNojgG6LvabvAwL4MPcAOchW5VIQUTGJbrq/V15PHhHtCIKGK1KWFPpNnSbS4ygQ==", null, false, "dfc0ad5b-3b6e-4b00-88a6-b2633410a7b5", false, "Cristina" },
                    { "10", 0, "058101c7-5c1b-49cf-8007-a8501b7a6343", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marion_Bartell@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEBnSHSpGI1TPoSs7shaUx3WreBuQE1vumtHw3ZFl66Xtuz47fc3Y+G2GPkRU6o0Y2A==", null, false, "35781e2e-d21a-48b3-a5fb-11a7e8aea82f", false, "Marion" },
                    { "11", 0, "b1def607-bb54-4426-877b-53c95f9247f4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vicky42@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGHwkMDgz7PpTnB3KQjdFfb4SYTDjoeFJjpfaSSoFmIWJSNnIv4t/spJZ4kLHLE7uw==", null, false, "58f08922-e4ed-49db-8098-982fb6a9cccb", false, "Vicky" },
                    { "12", 0, "350bc0b6-af28-4a78-ba61-89279d8dd82a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margaret17@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEL6h1iHXyl1JbtEutIKo7PyS+aZlKKLFfPF3WSkjq8r90HUMTftAQdQr62UfDiycxA==", null, false, "1c6e0db8-84c9-4c1f-a870-76b78d370a5d", false, "Margaret" },
                    { "8", 0, "940229ac-eb1b-455b-907c-0f7b66b9ef3e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan.Oberbrunner6@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEMqhajPyXWURCRlZB1aH+GFczTAYP3mf2WAAQOwSBdowc2YKqAKWZ0W+P9SyBUYlAw==", null, false, "09e04dcd-1f5d-444e-bc91-5fc4eb8a28ad", false, "Nathan" },
                    { "14", 0, "0c6bc6ba-3ce7-41b7-9045-f6238791b408", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robin_Corkery13@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEOwUeyGowRjHO2neAocb0WtFHVhzpsPfMK85duBhWThWPZ1HehtoF1CGQqy080fDQg==", null, false, "ee2458cf-0a5a-4119-b9c2-af14f5b410a7", false, "Robin" },
                    { "15", 0, "eabd1ce3-5b09-46ad-9c0e-27039e3b4add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alton2@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEA6HT15dPDXCHG1GYvlNu/3J04s15T3uS3LU3hP3cPBkQyQZlzshVV0XQO8qihl0QQ==", null, false, "7a99fa9e-1eea-4bc5-a8b9-6ab084502297", false, "Alton" },
                    { "16", 0, "c9451c05-2349-4002-af54-d41e27a1fa1c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberta.OReilly73@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEN26bQov8D++gIgxYwA4SX2o+O4hG8HcxoGenNPhf05CDhP5ReIVAgXCOggHWmPiMg==", null, false, "9d4a41e1-ca3a-4f40-8169-a624c7b916e3", false, "Alberta" },
                    { "17", 0, "74cbe483-45d6-4ec4-a31a-1c4ea7b42042", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodney49@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGJ08aQc7Ps6S28DJY7f0V+3RWPZxa+b6LH3Z2A71xk7POf0D7W3/MY4V2UqiKr8Pw==", null, false, "6653a79f-4d25-47ba-90ed-3582d7be6e2a", false, "Rodney" },
                    { "18", 0, "b13da7ae-4acf-4fbb-8c85-0b62b1b0ccf5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte_Schneider94@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEPiKlSPNigZJXvr1P2T+2mIBYWp1fuaJRlB2VvdlbZuH0G8vk7aIF+HwcXRJSgIM9g==", null, false, "0cab3ca1-83d9-4404-9c11-0ed0b103921b", false, "Charlotte" },
                    { "19", 0, "3413cf01-319f-4b1c-b288-a8ef1034fb5c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margarita.Thiel@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAELbCjMDXFkA0EzRcJaPNKNkcfMd2pkec4z5QmRCuoatqDxY2hIgMZuNykHHw3WwMxg==", null, false, "a3b34854-6d37-4346-ba36-b20f0595a09b", false, "Margarita" },
                    { "20", 0, "ad2159e3-11cd-4a24-a738-c225ecae2a50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joan.Fadel72@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEnO22axAAy/QFqIC9daIsug38jBeIHU1vpRleocaoU+S3CHAahMTGcihplCvS04kg==", null, false, "4a6cc6ba-795e-44d9-bfdc-21d30f2f3f43", false, "Joan" },
                    { "21", 0, "6379bafd-c985-405f-9d93-6148b8c131c9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krystal2@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEIcztctjT4pBElbBKhh31GMTbYiAap31Mnp58dHmiiBB8+Wxuvq1d9SUFWSuT1ND3A==", null, false, "73c37ef4-1d01-4e52-a870-4cb843d0c3e9", false, "Krystal" },
                    { "22", 0, "47bb054a-114a-40d4-bb92-f09d59644a79", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson.Macejkovic@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEMDnQjiN6pYa1ztEr9Hy96NbcujoRHq5/iVusH40u/ElX8NoeSB7i2pRI2uWvtNYsA==", null, false, "ed4fa53d-6ec2-4286-9e32-bdec6c66e02c", false, "Wilson" },
                    { "23", 0, "69f69261-ba79-4dde-bb81-0a8afa130477", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelley_Gulgowski@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEOcfDilncV4H/+Xk58QnZ7zirNu9ea9mfd1ncBwFW6Tso6eE0J+7of8fPgr8NG8L+w==", null, false, "e417af68-5a6f-4855-ad96-45c771bab56a", false, "Kelley" },
                    { "13", 0, "26ab3093-b04c-455f-b52b-835003b95b35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol62@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEASyVlKNU7EW2WGxPrdNzCedP1qUFVuZdMlOw0ID/g+yzjD7hL47V292+NClIZ/9SQ==", null, false, "9a97fbe5-e497-419c-bbf6-2b62f6e56aa4", false, "Carol" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 35, "SMTP compress migration", "deposit" },
                    { 34, "Global Singapore Dollar", "Kentucky" },
                    { 33, "back-end", "Licensed Wooden Salad" },
                    { 32, "Cotton Investment Account microchip", "alarm" },
                    { 27, "Director sensor", "Cambridgeshire" },
                    { 30, "Specialist", "transition" },
                    { 29, "Borders Division Toys", "Refined" },
                    { 28, "Money Market Account technologies Licensed Metal Table", "COM" },
                    { 31, "Sleek Wooden Shoes override", "Madagascar" },
                    { 36, "knowledge base", "Handmade Soft Salad" },
                    { 48, "Kids", "Dong" },
                    { 38, "SMS Unbranded Wooden Computer Oregon", "Sleek Frozen Bacon" },
                    { 39, "microchip Intelligent Plastic Table one-to-one", "matrix" },
                    { 40, "JBOD Moroccan Dirham compressing", "back up" },
                    { 41, "initiative", "maximize" },
                    { 42, "US Dollar", "microchip" },
                    { 43, "Syrian Pound zero defect", "Intelligent Steel Bacon" },
                    { 44, "Australian Dollar", "Practical Concrete Soap" },
                    { 45, "Intelligent Rubber Bike executive Metal", "GB" },
                    { 46, "hacking Lodge", "Savings Account" },
                    { 47, "Exclusive white Motorway", "zero defect" },
                    { 26, "Toys & Outdoors Tonga Internal", "supply-chains" },
                    { 37, "UAE Dirham Intelligent Rubber Hat", "Georgia" },
                    { 25, "Graphic Interface", "white" },
                    { 13, "Estates Dynamic Hawaii", "Shoes & Sports" },
                    { 23, "Representative", "Configuration" },
                    { 49, "Generic Soft Table", "Summit" },
                    { 1, "Drive", "Health" },
                    { 2, "Handcrafted Fresh Towels", "Handcrafted Soft Bike" },
                    { 3, "Handcrafted Cambridgeshire Practical Plastic Bacon", "Internal" },
                    { 4, "Unbranded Wooden Pants Cove", "reboot" },
                    { 5, "Ergonomic Kids, Garden & Baby Qatar", "payment" },
                    { 6, "Virginia Maryland Avon", "Program" },
                    { 7, "Concrete card", "Small Metal Cheese" },
                    { 8, "reboot", "Metal" },
                    { 9, "Kids & Garden Tanzanian Shilling bypass", "structure" },
                    { 24, "Grass-roots Beauty Berkshire", "quantify" },
                    { 10, "Zimbabwe Village", "programming" },
                    { 12, "Sleek Soft Soap purple payment", "Dynamic" },
                    { 14, "Rhode Island", "Danish Krone" },
                    { 15, "unleash Architect", "Tools, Shoes & Toys" },
                    { 16, "Borders program parsing", "withdrawal" },
                    { 17, "niches", "Intelligent Concrete Gloves" },
                    { 18, "Branding capacitor Generic Granite Cheese", "deposit" },
                    { 19, "Tasty Fresh Ball optical", "Senior" },
                    { 20, "Street frictionless Mauritius", "Directives" },
                    { 21, "e-business", "index" },
                    { 22, "Licensed Frozen Shirt", "Future" },
                    { 11, "Greens monitoring", "Small" },
                    { 50, "holistic Steel", "Producer" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "Content", "DateTime", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 5, "2", 1, "Consequatur non maxime ea earum.", new DateTime(2019, 7, 18, 18, 33, 44, 613, DateTimeKind.Local).AddTicks(383), "Iure fuga est sed eaque.", null, "Est rerum deserunt eum et dolorem occaecati." },
                    { 13, "2", 3, "Consequatur laborum eos et ut velit.", new DateTime(2019, 12, 3, 10, 46, 6, 342, DateTimeKind.Local).AddTicks(8497), "Quia ut eum quis assumenda veritatis hic quibusdam praesentium.", null, "Odit et rerum et laboriosam et." },
                    { 17, "1", 3, "Ut quo rerum.", new DateTime(2019, 11, 27, 21, 33, 21, 183, DateTimeKind.Local).AddTicks(3225), "Voluptas corrupti et et doloribus vel at.", null, "Dignissimos sunt nulla itaque quae temporibus rerum voluptas dignissimos facilis." },
                    { 25, "1", 3, "Earum ut consectetur eligendi rerum porro.", new DateTime(2019, 10, 18, 11, 50, 29, 477, DateTimeKind.Local).AddTicks(9987), "Doloribus reprehenderit quo nesciunt cum veritatis.", null, "Aut non ea quibusdam vel soluta magnam voluptatum quisquam." },
                    { 32, "1", 3, "Quisquam unde consequuntur laboriosam.", new DateTime(2020, 3, 10, 1, 23, 40, 96, DateTimeKind.Local).AddTicks(341), "Non vero perferendis ea voluptas numquam.", null, "Eos pariatur voluptate aut odio harum." },
                    { 40, "1", 3, "Saepe et facere et et et suscipit sequi.", new DateTime(2019, 9, 16, 12, 16, 27, 139, DateTimeKind.Local).AddTicks(369), "Explicabo voluptatem non.", null, "Rerum rerum a tempore est aperiam quo." },
                    { 41, "1", 3, "Ea cum placeat voluptatem est repellat quia officiis praesentium voluptatem.", new DateTime(2019, 4, 17, 14, 19, 37, 355, DateTimeKind.Local).AddTicks(1711), "Praesentium qui illum ex quia nihil perspiciatis totam omnis nobis.", null, "Voluptate debitis consequatur dolore minima nam suscipit." },
                    { 2, "1", 4, "Adipisci fugit deleniti dolorem.", new DateTime(2020, 3, 17, 9, 27, 4, 961, DateTimeKind.Local).AddTicks(9219), "Sed sunt molestiae asperiores autem fuga et eveniet quia saepe.", null, "Id dolorem aperiam itaque tempore qui asperiores aperiam repellendus." },
                    { 14, "3", 4, "Exercitationem non maiores explicabo ut eos ut alias.", new DateTime(2019, 5, 5, 9, 42, 38, 28, DateTimeKind.Local).AddTicks(5302), "Minima voluptatem eius quia.", null, "Aut eaque fugiat quaerat recusandae nihil vel minima consequatur." },
                    { 18, "2", 4, "Et praesentium nemo corporis qui mollitia impedit.", new DateTime(2020, 1, 25, 1, 28, 32, 977, DateTimeKind.Local).AddTicks(2421), "Et aut possimus est omnis ut.", null, "Odit dolor excepturi qui ut." },
                    { 20, "1", 4, "Illo ut eos facilis adipisci hic quos fugiat.", new DateTime(2019, 5, 2, 22, 1, 39, 8, DateTimeKind.Local).AddTicks(180), "Ea culpa ut amet quibusdam dolorem sed nostrum doloribus.", null, "Iusto perspiciatis et numquam." },
                    { 28, "1", 4, "Nulla distinctio est sit ut quisquam sit eaque ut repudiandae.", new DateTime(2019, 9, 18, 19, 42, 18, 622, DateTimeKind.Local).AddTicks(111), "Velit asperiores distinctio assumenda.", null, "Magnam recusandae aut veritatis rerum nihil." },
                    { 34, "3", 4, "Consequuntur veniam ut aut occaecati vitae magni totam maxime.", new DateTime(2020, 1, 21, 4, 31, 42, 454, DateTimeKind.Local).AddTicks(4525), "Doloribus ex voluptas architecto vel minus et.", null, "Non reiciendis consequatur." },
                    { 36, "1", 4, "Est totam tenetur incidunt eius nobis quidem officiis officiis.", new DateTime(2019, 10, 21, 16, 29, 17, 435, DateTimeKind.Local).AddTicks(7648), "Omnis et ut consequatur.", null, "Distinctio rerum doloribus harum." },
                    { 39, "3", 4, "Non facere quidem quis.", new DateTime(2019, 12, 30, 4, 41, 19, 723, DateTimeKind.Local).AddTicks(9446), "Omnis rerum laudantium.", null, "Explicabo consectetur et et quibusdam." },
                    { 46, "2", 4, "Neque ipsum rerum dolor commodi et nihil commodi recusandae.", new DateTime(2020, 1, 2, 22, 28, 18, 424, DateTimeKind.Local).AddTicks(3532), "Cumque repellendus quidem ut repudiandae.", null, "Beatae minus recusandae veritatis ducimus corrupti." },
                    { 49, "2", 4, "Corporis suscipit exercitationem placeat vitae ab.", new DateTime(2019, 10, 27, 21, 15, 22, 412, DateTimeKind.Local).AddTicks(1852), "Corporis quis quidem itaque mollitia fugit expedita.", null, "Harum eaque perferendis reprehenderit." },
                    { 16, "1", 5, "Aspernatur consectetur rem soluta consequatur qui sint molestias.", new DateTime(2019, 7, 22, 20, 47, 56, 663, DateTimeKind.Local).AddTicks(2262), "Et officia voluptate quidem.", null, "Dolor accusantium ut id beatae nam quo velit dolor in." },
                    { 19, "2", 5, "Vel quae quod fugit.", new DateTime(2020, 2, 15, 2, 2, 34, 455, DateTimeKind.Local).AddTicks(129), "Et nobis nobis.", null, "Eligendi pariatur culpa assumenda labore natus quod." },
                    { 26, "2", 5, "Sed corporis maiores.", new DateTime(2019, 7, 12, 20, 39, 35, 333, DateTimeKind.Local).AddTicks(4283), "A sit vel rem.", null, "Nostrum eum eos alias voluptatum officia." },
                    { 30, "3", 5, "Eligendi quae ut vel veniam deserunt.", new DateTime(2020, 3, 19, 14, 18, 32, 20, DateTimeKind.Local).AddTicks(2065), "Dolore beatae facilis neque cupiditate suscipit.", null, "Aut veniam fugit iusto ipsum." },
                    { 33, "2", 5, "Excepturi perferendis corporis earum repellendus sapiente voluptatem.", new DateTime(2019, 12, 31, 10, 46, 20, 281, DateTimeKind.Local).AddTicks(4783), "Ut laboriosam non enim exercitationem rem quae.", null, "Sed est enim enim aliquid." },
                    { 12, "1", 3, "Fugiat voluptates ad eos velit vel optio laudantium ullam.", new DateTime(2020, 3, 2, 8, 32, 9, 34, DateTimeKind.Local).AddTicks(3454), "Omnis beatae expedita officiis et.", null, "Culpa et magni aliquid qui dicta voluptatem iure." },
                    { 4, "3", 3, "Quia aspernatur aut sunt minus et ut sint quas beatae.", new DateTime(2019, 5, 6, 23, 21, 56, 286, DateTimeKind.Local).AddTicks(3365), "Sapiente velit quasi saepe molestiae temporibus dignissimos dicta quia.", null, "Fugit dolorum rem omnis est error et." },
                    { 1, "1", 3, "Omnis quam numquam.", new DateTime(2020, 3, 4, 1, 55, 37, 906, DateTimeKind.Local).AddTicks(5625), "Expedita voluptates tempore qui maxime.", null, "Est consequuntur voluptates porro." },
                    { 47, "2", 2, "Vel architecto aut aut.", new DateTime(2019, 8, 23, 3, 55, 11, 302, DateTimeKind.Local).AddTicks(7026), "Occaecati ducimus vel fugiat nisi aut dolores accusamus dolores ullam.", null, "Ea ut cumque quasi fugit sapiente." },
                    { 6, "2", 1, "Quo eum voluptatem.", new DateTime(2019, 8, 23, 18, 35, 36, 367, DateTimeKind.Local).AddTicks(9056), "Rerum id natus quia repellendus adipisci laborum totam consequatur qui.", null, "Voluptatem necessitatibus incidunt quis non veritatis unde." },
                    { 9, "2", 1, "Saepe odit praesentium aut.", new DateTime(2019, 6, 13, 3, 23, 41, 23, DateTimeKind.Local).AddTicks(1278), "Et possimus fuga nemo hic quibusdam ut.", null, "Voluptatem non accusamus nam ea." },
                    { 11, "1", 1, "Aspernatur id aut.", new DateTime(2019, 8, 25, 4, 24, 25, 202, DateTimeKind.Local).AddTicks(167), "Vero voluptas suscipit quasi ut laudantium nam corrupti.", null, "Unde corporis vel fuga libero minus." },
                    { 15, "3", 1, "Reprehenderit sit molestias est tempore ut harum ducimus.", new DateTime(2019, 4, 14, 10, 18, 42, 649, DateTimeKind.Local).AddTicks(1505), "Vitae nihil quia aliquid ut magnam tempore molestiae quia odit.", null, "Quia sed nihil corporis beatae ut qui." },
                    { 21, "1", 1, "Voluptatibus quo officiis harum occaecati atque officiis dolorem nisi.", new DateTime(2019, 7, 28, 2, 56, 16, 121, DateTimeKind.Local).AddTicks(2454), "Dicta voluptatem id commodi delectus.", null, "Quaerat impedit deleniti sunt officia possimus." },
                    { 29, "1", 1, "Aut ratione voluptatibus dignissimos.", new DateTime(2019, 6, 28, 20, 51, 27, 718, DateTimeKind.Local).AddTicks(5642), "Iure hic voluptatum.", null, "Saepe accusamus qui hic ea." },
                    { 35, "1", 1, "Molestiae omnis earum repudiandae delectus qui ut.", new DateTime(2019, 5, 23, 5, 50, 1, 203, DateTimeKind.Local).AddTicks(5123), "Quia vero molestiae laboriosam ullam eos.", null, "Aperiam consequuntur aut." },
                    { 38, "3", 1, "Mollitia ducimus culpa.", new DateTime(2020, 2, 29, 20, 59, 37, 424, DateTimeKind.Local).AddTicks(3757), "Ut occaecati qui dignissimos officiis aperiam suscipit repellat sint.", null, "Exercitationem maiores nobis placeat quo mollitia asperiores quo." },
                    { 45, "2", 1, "Dicta at est maiores minus voluptatem temporibus rerum voluptates.", new DateTime(2019, 5, 17, 14, 41, 0, 435, DateTimeKind.Local).AddTicks(5149), "Tempore non voluptates cupiditate perspiciatis assumenda voluptate omnis dolorum quia.", null, "Nam eligendi facilis reiciendis." },
                    { 48, "1", 1, "Cupiditate nemo aperiam sit porro ea ab iusto.", new DateTime(2019, 12, 30, 23, 40, 27, 22, DateTimeKind.Local).AddTicks(3788), "Dicta iusto alias.", null, "Nulla modi accusantium qui deleniti ut mollitia." },
                    { 37, "1", 5, "Tempora ea perspiciatis soluta quis quo.", new DateTime(2020, 3, 24, 6, 28, 22, 382, DateTimeKind.Local).AddTicks(1139), "Ut quaerat quia necessitatibus vero.", null, "Perspiciatis omnis qui numquam et." },
                    { 50, "2", 1, "Cupiditate sed voluptatum repellendus ratione commodi.", new DateTime(2019, 6, 25, 11, 0, 14, 301, DateTimeKind.Local).AddTicks(3631), "Libero quibusdam molestias.", null, "Architecto ipsa omnis eum aliquam perferendis eligendi quaerat." },
                    { 7, "3", 2, "Dolorem sint deleniti nesciunt qui minus dolores necessitatibus.", new DateTime(2019, 4, 28, 6, 46, 41, 273, DateTimeKind.Local).AddTicks(4412), "Molestiae neque explicabo sunt earum iure aut nemo et quo.", null, "Sunt suscipit omnis quasi." },
                    { 8, "1", 2, "Officiis optio dolores aspernatur est dolorem natus voluptas velit.", new DateTime(2019, 8, 5, 22, 24, 49, 306, DateTimeKind.Local).AddTicks(2524), "Magni sapiente eligendi fuga tempore vitae consequuntur dicta.", null, "Neque cumque ad accusantium corporis et corrupti numquam eum officiis." },
                    { 10, "1", 2, "Voluptatem assumenda optio omnis possimus consequatur quisquam unde.", new DateTime(2019, 5, 31, 13, 16, 44, 505, DateTimeKind.Local).AddTicks(5082), "Deleniti quas facilis perferendis quisquam.", null, "Totam quia dolor." },
                    { 22, "1", 2, "Consequatur non aut et sed ea harum nihil libero repudiandae.", new DateTime(2020, 3, 27, 18, 15, 41, 703, DateTimeKind.Local).AddTicks(8971), "Modi in ducimus sit ut omnis qui sed.", null, "Tenetur ut rerum impedit quia aspernatur quas voluptates quia consectetur." },
                    { 23, "1", 2, "Soluta vel voluptatem maxime.", new DateTime(2020, 2, 6, 20, 5, 11, 260, DateTimeKind.Local).AddTicks(3886), "Est dolorem velit earum eaque at et autem.", null, "Et alias eos odio minima voluptatem praesentium et." },
                    { 24, "2", 2, "Mollitia sunt maxime quia repellendus qui.", new DateTime(2019, 5, 3, 2, 13, 16, 974, DateTimeKind.Local).AddTicks(6942), "Fugit ipsum enim odio rerum omnis laudantium ducimus autem.", null, "Laudantium beatae labore velit ipsum ducimus molestiae hic facilis sit." },
                    { 27, "2", 2, "Numquam eveniet non officiis amet sapiente explicabo vero atque sint.", new DateTime(2019, 6, 16, 4, 38, 56, 942, DateTimeKind.Local).AddTicks(9269), "Voluptatibus non et voluptatem.", null, "Id officia dignissimos est." },
                    { 31, "3", 2, "Praesentium cumque ex nihil.", new DateTime(2019, 12, 7, 6, 19, 6, 355, DateTimeKind.Local).AddTicks(3856), "Ipsum aut ad dicta minus.", null, "Eveniet sit ducimus sint sed quod in." },
                    { 43, "1", 2, "Dolores hic molestias animi explicabo quibusdam.", new DateTime(2020, 1, 22, 6, 28, 56, 512, DateTimeKind.Local).AddTicks(9024), "Sit nulla corrupti officia.", null, "Officiis consequatur dolores dolorum eum maxime molestiae nesciunt est." },
                    { 44, "2", 2, "Est porro et amet repudiandae corrupti harum velit sit.", new DateTime(2020, 2, 25, 8, 21, 46, 152, DateTimeKind.Local).AddTicks(5570), "Voluptatem doloremque ut omnis harum earum odio.", null, "Quo reiciendis sint." },
                    { 3, "2", 2, "Voluptatem aut quia autem porro consectetur dignissimos fugit.", new DateTime(2019, 8, 18, 4, 0, 8, 655, DateTimeKind.Local).AddTicks(1373), "Atque velit impedit qui dicta quisquam dolore accusamus perferendis totam.", null, "Eius ut ex magni tempora." },
                    { 42, "2", 5, "Et mollitia et aut expedita et.", new DateTime(2020, 1, 22, 22, 13, 12, 711, DateTimeKind.Local).AddTicks(1070), "Magnam aliquam enim aut in aut architecto quaerat accusamus.", null, "In voluptatem assumenda tempora deserunt quo molestiae." }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "DateCreated", "IsAnonymous", "PostId" },
                values: new object[,]
                {
                    { 8, "1", "Land", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 45, "3", "backing up Christmas Island", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 7, "2", "platforms", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 10, "1", "Director digital", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 11, "1", "Games", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 12, "1", "Gorgeous XML", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 13, "3", "Macao", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 16, "2", "withdrawal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 17, "2", "Naira Bulgarian Lev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 18, "3", "Checking Account moratorium Turkey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 19, "3", "bypassing help-desk Licensed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 22, "3", "Glen Concrete Uganda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 24, "3", "Grass-roots", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 26, "2", "Gardens Gateway", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 27, "3", "calculating", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 32, "2", "incubate", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 33, "3", "navigate utilize panel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 34, "1", "Functionality Borders", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 38, "1", "turquoise Generic Concrete Chair Rustic Metal Chicken", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 41, "1", "Peru Product primary", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 43, "1", "withdrawal User-centric", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 47, "3", "Berkshire", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 44, "2", "calculate", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 42, "2", "Mill", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 40, "2", "EXE bottom-line Incredible", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 39, "1", "US Dollar Islands International", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 14, "1", "empower", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 15, "2", "empowering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 21, "1", "Gorgeous Granite Keyboard Ergonomic Frozen Hat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 23, "3", "Home Loan Account CSS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 28, "3", "Personal Loan Account solution", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 36, "3", "Steel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 37, "3", "withdrawal Director partnerships", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 46, "3", "South Dakota", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 50, "2", "alarm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 1, "3", "navigating Clothing, Games & Clothing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 48, "1", "withdrawal Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 2, "1", "Identity Agent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 4, "1", "1080p SMTP matrix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 5, "1", "architectures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 6, "2", "indexing RAM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 9, "1", "Handcrafted Plastic Sausages cross-platform", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 20, "2", "Ergonomic asynchronous Handmade Granite Pants", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 25, "1", "Chief", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 29, "1", "Iowa National", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 30, "1", "teal Bedfordshire", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 31, "2", "payment purple", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 35, "3", "USB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 3, "2", "Clothing, Jewelery & Outdoors generate", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 49, "3", "Florida application Buckinghamshire", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ApplicationUserId",
                table: "Likes",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CommentId",
                table: "Likes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
