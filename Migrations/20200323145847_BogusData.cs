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
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Content = table.Column<string>(maxLength: 1000, nullable: true),
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
                    { "1", 0, "7c3f1be6-b30d-444b-af92-3205460b2f9b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bennett.Hills19@gmail.com", false, false, false, null, null, null, "password", null, false, "e6f212fa-3a98-4af8-bab4-09b5e748f909", false, "Dino" },
                    { "28", 0, "79bcaabd-e30c-445d-990d-656b4a94dfe6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bennett.Mertz76@gmail.com", false, false, false, null, null, null, "password", null, false, "455d861e-a2ff-4422-918e-0f9ed1f50d01", false, "Lisandro" },
                    { "29", 0, "24018cd0-377f-4fc2-a761-014d810e687c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ara37@yahoo.com", false, false, false, null, null, null, "password", null, false, "af4bcb7f-c5d8-4f67-9c38-e66d4bda37c1", false, "Susana" },
                    { "30", 0, "31a59c32-a963-45a9-a70c-081ab5947e92", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilhelm.Rutherford31@hotmail.com", false, false, false, null, null, null, "password", null, false, "8d8bfe13-c5f0-4000-8c8b-01aa4ce4cd4c", false, "Bradley" },
                    { "31", 0, "0abe16da-ce02-4a65-800d-9952dec9479e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avis_Mosciski24@yahoo.com", false, false, false, null, null, null, "password", null, false, "72c7ea1a-3730-41a0-b3e7-6c84e414d09a", false, "Lura" },
                    { "32", 0, "28d3706f-dfdf-476f-a4c1-19ddfa0ccaeb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavina57@gmail.com", false, false, false, null, null, null, "password", null, false, "27466cb6-09c8-4f43-a217-689fd46bbbb7", false, "Andrew" },
                    { "33", 0, "53be073b-2a89-4aa8-8ddb-129cfe5daa64", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casey_Cruickshank@yahoo.com", false, false, false, null, null, null, "password", null, false, "389c360c-18af-4330-927e-25740f62934d", false, "Stephania" },
                    { "34", 0, "95717111-7117-4db4-9634-768574687a9c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ernest.Jacobs62@hotmail.com", false, false, false, null, null, null, "password", null, false, "a22cffa3-c4cd-4ee8-a3f0-937f55916531", false, "Dane" },
                    { "35", 0, "d2fa82f6-2064-4e6e-bd63-fe1346ffd44a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby7@gmail.com", false, false, false, null, null, null, "password", null, false, "487ca9db-3e80-4e09-8ba7-477dd01a690f", false, "Alana" },
                    { "36", 0, "94e781d2-c7d2-4b60-b61a-a263e3c031a8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlotta.Lehner@hotmail.com", false, false, false, null, null, null, "password", null, false, "7dacc5a7-eaff-415e-92c3-f26c544a5c14", false, "Roel" },
                    { "37", 0, "1c8c9d48-2337-4e74-ab40-4c000f6bf4f6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdullah2@hotmail.com", false, false, false, null, null, null, "password", null, false, "22b46d1e-d0af-4a0e-b860-84f9df7e1206", false, "Mafalda" },
                    { "27", 0, "48cafd48-e666-4bfc-82e1-00d8efbc096b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amir.Windler50@hotmail.com", false, false, false, null, null, null, "password", null, false, "5b7c2205-25dd-41ff-aa03-3f4ac7fd221f", false, "Elian" },
                    { "38", 0, "71dd5812-c2f9-4a60-a992-4f2e1e8d1e79", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vallie.Kovacek65@hotmail.com", false, false, false, null, null, null, "password", null, false, "85bde0be-2074-40dc-b90f-0ade754f8f54", false, "Malachi" },
                    { "40", 0, "915a61e5-e298-4fb9-aaa4-5a3b04a5aba3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elmira.Hudson1@hotmail.com", false, false, false, null, null, null, "password", null, false, "bca0f676-2d51-4a35-a813-742d938d3c3d", false, "Grace" },
                    { "41", 0, "6f271eb4-9761-4cf3-8178-e13acb299124", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darwin.Bauch@yahoo.com", false, false, false, null, null, null, "password", null, false, "23225978-b64e-4c12-bf4a-3577ed3a7b76", false, "Stephen" },
                    { "42", 0, "6da4de91-a9b2-4092-987d-5d537ebe72b3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgil.Hintz@hotmail.com", false, false, false, null, null, null, "password", null, false, "df04fd15-ef9a-4936-97c6-7efbca2a1104", false, "Norbert" },
                    { "43", 0, "df1db2bc-2b52-4543-9ffb-4a1a41c2f4af", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dimitri_White@gmail.com", false, false, false, null, null, null, "password", null, false, "62b51497-9c0c-4477-8fef-fea23afb995f", false, "Gay" },
                    { "44", 0, "0891a9a4-2c5a-4e25-8bdc-47c7c813d100", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "King17@hotmail.com", false, false, false, null, null, null, "password", null, false, "42c72cd2-0f24-4249-a40f-f35f242cea3a", false, "Verla" },
                    { "45", 0, "b128c8c8-2bcf-43ea-963f-85b51afab3f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "River.Abernathy@hotmail.com", false, false, false, null, null, null, "password", null, false, "daa56d61-9410-4ad4-9f39-d54b694e4d7a", false, "Zachary" },
                    { "46", 0, "c5e42d1d-1ef4-4a65-a982-d89b901c0077", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Violet_Anderson26@hotmail.com", false, false, false, null, null, null, "password", null, false, "5079a980-469b-4dc6-9b0d-20d08e2463d6", false, "Jaime" },
                    { "47", 0, "f64147d0-fa62-4f3b-b956-295e4ee27727", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eriberto1@gmail.com", false, false, false, null, null, null, "password", null, false, "ea4e1b9c-b6b8-4f3a-9da9-9e93d38197ec", false, "Hilton" },
                    { "48", 0, "ac697607-6441-404a-95e4-1247ce4fdb29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest.Hamill@yahoo.com", false, false, false, null, null, null, "password", null, false, "1e318824-0e9e-45a3-8c7d-61ca0432352d", false, "Izabella" },
                    { "49", 0, "8816e71e-1596-4e69-8a35-6886de1ac057", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominique.Schaden76@yahoo.com", false, false, false, null, null, null, "password", null, false, "a02da121-3e0e-47c5-ab0b-0f6f49ebca4b", false, "Florencio" },
                    { "39", 0, "0ef2b4a4-d004-4b56-9a78-b369950e82de", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unique_Wunsch70@hotmail.com", false, false, false, null, null, null, "password", null, false, "bd57cd09-61ab-4816-9dc3-1a8356a54164", false, "Callie" },
                    { "26", 0, "2edcfe27-ee5f-424a-86e4-2e45d6c6ac19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jarrell.Friesen97@yahoo.com", false, false, false, null, null, null, "password", null, false, "01fa0786-1396-4026-8c05-0d892488ae83", false, "Mark" },
                    { "50", 0, "e4d074d0-aea4-490a-b6cf-4346858e0e8c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dayna_Schmitt@gmail.com", false, false, false, null, null, null, "password", null, false, "33bfaa25-e228-43f3-ace0-b09ecd870e6f", false, "Dameon" },
                    { "24", 0, "672a12ce-a4ef-42c3-8fc3-141c9aecaf65", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maci.Welch40@hotmail.com", false, false, false, null, null, null, "password", null, false, "6c156770-c8ca-46cd-919b-90e43dd9de7b", false, "Florence" },
                    { "2", 0, "ccd3aef4-6927-4d73-aefa-b07616c6cab0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karson_Boyer@hotmail.com", false, false, false, null, null, null, "password", null, false, "83c7455e-0529-4ac9-bb9d-368fbaa8946a", false, "Gisselle" },
                    { "3", 0, "347a40bf-acfe-4a24-a7c6-c5e7f8c57f54", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melody_Rath@hotmail.com", false, false, false, null, null, null, "password", null, false, "296da26a-b43f-47a1-a501-ab284ccc7e8f", false, "Beaulah" },
                    { "4", 0, "af830b60-5b1e-4069-adf2-4642a5b10447", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaylan.Padberg32@gmail.com", false, false, false, null, null, null, "password", null, false, "af0d6894-7212-428d-8879-1b2a90b0f046", false, "Armand" },
                    { "5", 0, "bc7ed8e3-bd7e-49f1-a602-4d03c62cd0c8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adan_Luettgen@hotmail.com", false, false, false, null, null, null, "password", null, false, "f9065db6-6c81-4b40-a6a4-18c3db221012", false, "Ari" },
                    { "6", 0, "0a2cffdc-3f99-42f5-96a0-6eca0b6e6b12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berenice.Bradtke41@hotmail.com", false, false, false, null, null, null, "password", null, false, "ef14f17a-e940-44d2-914c-cc1559fa05ba", false, "Tatum" },
                    { "7", 0, "08e8faf3-224e-473b-be4f-b8a4bb218389", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charity35@hotmail.com", false, false, false, null, null, null, "password", null, false, "e4c5249b-83b7-49da-aabc-f3f1d32953e1", false, "Madeline" },
                    { "25", 0, "c106af42-b03b-4128-ac3e-3c4f5a38087c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mittie.Erdman9@gmail.com", false, false, false, null, null, null, "password", null, false, "6ca8abee-9dd1-4fab-bf0a-c74a206f1103", false, "Pattie" },
                    { "9", 0, "d4d8c96b-2c6f-464b-aa0c-d94d7beb20dc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clint43@hotmail.com", false, false, false, null, null, null, "password", null, false, "35d7e286-cb1d-4b3c-b1ee-9c626c2e1583", false, "Glenna" },
                    { "10", 0, "443e37ef-c576-4c12-b5c5-0dccf2f6e10a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dortha69@yahoo.com", false, false, false, null, null, null, "password", null, false, "d4ff309c-18a1-411d-af12-4daf3f0563f4", false, "Camryn" },
                    { "11", 0, "e45a8c73-db98-4dc6-af2c-5abb318d7417", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harvey.Kertzmann@yahoo.com", false, false, false, null, null, null, "password", null, false, "43de0aab-bb53-49d4-a125-c74e2c0b0e4c", false, "Zachariah" },
                    { "12", 0, "4799f011-f3ed-43c7-98e0-d95bcdacfb62", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol90@gmail.com", false, false, false, null, null, null, "password", null, false, "194e47cc-fc96-4570-8a71-93629be7375e", false, "Lenora" },
                    { "8", 0, "744d2163-aa2c-4656-8318-4f1808db1e99", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maye44@yahoo.com", false, false, false, null, null, null, "password", null, false, "575337b8-0111-45de-b4ba-b695d2c8e991", false, "Ariel" },
                    { "14", 0, "e188ac4e-b2c7-4c33-9bc7-f3665bfb18d9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wyatt40@yahoo.com", false, false, false, null, null, null, "password", null, false, "48743c49-488a-4048-b51b-c33b303a496c", false, "Khalil" },
                    { "15", 0, "8b796754-2ba4-4264-9a8f-123bf762ef89", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floy.Ortiz@hotmail.com", false, false, false, null, null, null, "password", null, false, "0bfb5156-df05-41ad-a8fc-bdd3ebf9b35f", false, "Betty" },
                    { "16", 0, "0dc7d020-054b-47f9-8b6f-1d4947530c90", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dejon63@hotmail.com", false, false, false, null, null, null, "password", null, false, "46cb3d74-3571-4edc-b3b0-e4fe51a98e76", false, "Terrance" },
                    { "17", 0, "2821e891-7b1f-44e3-abc3-120c24f41669", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucy.Fisher@gmail.com", false, false, false, null, null, null, "password", null, false, "9f0ade38-9fa4-4e2c-a45b-e8f88884df2b", false, "Sadye" },
                    { "18", 0, "71606fbc-b62f-4a8b-a45a-f0518f7bc2bf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chesley5@gmail.com", false, false, false, null, null, null, "password", null, false, "922a88ab-bebd-4a50-964b-df2b6e0921e2", false, "Dave" },
                    { "19", 0, "7ca163f3-f4a0-4a1e-befb-54b819dab5b4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisandro.Terry31@gmail.com", false, false, false, null, null, null, "password", null, false, "a5a3a6d5-b1dd-4000-be0a-cb71a6153e57", false, "Quinton" },
                    { "20", 0, "6145837f-5b6d-4b1d-a8ed-73c404749756", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry55@gmail.com", false, false, false, null, null, null, "password", null, false, "b4c250c8-3aca-47e7-9d7f-853fc7f61b95", false, "Sherman" },
                    { "21", 0, "b3f23617-f7ce-4ae9-b8f4-fa00b3a81373", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laisha_Gulgowski70@hotmail.com", false, false, false, null, null, null, "password", null, false, "ff15ee16-b66c-4a95-8ec4-26a18065cd5f", false, "Trever" },
                    { "22", 0, "5f6f8365-2a83-4747-8377-a138786bf0b9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachery.Hintz@yahoo.com", false, false, false, null, null, null, "password", null, false, "c54672ba-a96f-4baf-b3b8-bd1493c865b9", false, "Abe" },
                    { "23", 0, "39fcad4d-e4e6-49eb-9bc5-85ae4393ab56", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Courtney22@hotmail.com", false, false, false, null, null, null, "password", null, false, "e04fa8fc-eb5a-444e-b6ed-01507b810b3c", false, "Kiara" },
                    { "13", 0, "318b5ef7-5bba-41be-bbec-54f8b8aab2dc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anya62@yahoo.com", false, false, false, null, null, null, "password", null, false, "d557b8ca-dbfe-4d5e-b5be-383c436cd824", false, "Nayeli" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 35, "Missouri Mozambique", "Intelligent" },
                    { 34, "implement", "Operations" },
                    { 33, "Dynamic Planner Frozen", "Strategist" },
                    { 32, "Gorgeous Wooden Pants", "invoice" },
                    { 27, "integrate Gorgeous Metal Chips", "web-enabled" },
                    { 30, "customer loyalty Montana connecting", "budgetary management" },
                    { 29, "networks Squares Senior", "calculating" },
                    { 28, "Latvian Lats Unbranded Fresh Table", "withdrawal" },
                    { 31, "Progressive Technician discrete", "Hollow" },
                    { 36, "quantify Rustic Frozen Sausages Fresh", "Brooks" },
                    { 48, "Buckinghamshire experiences", "backing up" },
                    { 38, "synthesize Realigned", "Configuration" },
                    { 39, "intermediate online Auto Loan Account", "Berkshire" },
                    { 40, "Accountability Wooden", "Row" },
                    { 41, "Refined Metal Soap", "redundant" },
                    { 42, "innovate Kwanza", "unleash" },
                    { 43, "function open-source", "reboot" },
                    { 44, "Berkshire", "HDD" },
                    { 45, "THX", "Small" },
                    { 46, "withdrawal Florida SAS", "Data" },
                    { 47, "Shoes & Automotive transmit", "haptic" },
                    { 26, "Sports, Baby & Toys", "Savings Account" },
                    { 37, "Square", "Personal Loan Account" },
                    { 25, "payment Customer neural-net", "SQL" },
                    { 13, "RAM Indiana", "Angola" },
                    { 23, "Rapids", "driver" },
                    { 49, "front-end Crossroad", "backing up" },
                    { 1, "payment syndicate Ohio", "Credit Card Account" },
                    { 2, "Sudanese Pound Rubber multi-byte", "Rubber" },
                    { 3, "Agent Directives Unbranded Frozen Shoes", "Gambia" },
                    { 4, "Fort", "Beauty & Sports" },
                    { 5, "Factors North Dakota Unbranded Steel Computer", "Oklahoma" },
                    { 6, "vortals approach", "bandwidth" },
                    { 7, "Applications grow Bahamas", "HDD" },
                    { 8, "Customer", "payment" },
                    { 9, "Soft", "Fresh" },
                    { 24, "Ergonomic yellow Tasty Fresh Fish", "Greece" },
                    { 10, "process improvement", "Maine" },
                    { 12, "Pike Multi-tiered Berkshire", "port" },
                    { 14, "monitor", "bluetooth" },
                    { 15, "Unbranded", "Malaysian Ringgit" },
                    { 16, "Intelligent Steel Bacon digital circuit", "frictionless" },
                    { 17, "Cloned Data forecast", "content" },
                    { 18, "black tan", "Small Granite Mouse" },
                    { 19, "GB Bedfordshire well-modulated", "Handcrafted Metal Pants" },
                    { 20, "attitude-oriented aggregate Manor", "Circles" },
                    { 21, "Producer copy synthesizing", "Auto Loan Account" },
                    { 22, "Greens Rubber Bahamas", "Checking Account" },
                    { 11, "generating Integration", "Rustic Steel Shoes" },
                    { 50, "Chief deploy", "SCSI" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "Content", "DateTime", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 3, "3", 1, "Delectus autem recusandae et repellendus sint quisquam veritatis.", new DateTime(2020, 1, 28, 1, 32, 27, 353, DateTimeKind.Local).AddTicks(3974), "Nulla et eveniet enim exercitationem temporibus id nihil consequatur molestiae.", null, "Et et tempore." },
                    { 19, "2", 3, "Necessitatibus at repellat libero sunt sint tempora.", new DateTime(2019, 8, 17, 19, 55, 43, 251, DateTimeKind.Local).AddTicks(9438), "Dolor quos officia quaerat omnis in.", null, "Dignissimos id deserunt aut assumenda." },
                    { 22, "1", 3, "Illum necessitatibus sit eius sapiente ducimus qui architecto blanditiis facilis.", new DateTime(2019, 10, 26, 1, 1, 25, 393, DateTimeKind.Local).AddTicks(2959), "Velit sed officia et itaque deserunt nemo illo.", null, "Ut dolor voluptas aspernatur occaecati sapiente culpa eum voluptatem." },
                    { 31, "3", 3, "Suscipit officiis ut natus et.", new DateTime(2020, 2, 27, 8, 59, 0, 2, DateTimeKind.Local).AddTicks(3189), "Eligendi in aliquam reiciendis placeat.", null, "Sed est rerum earum velit perspiciatis quidem aut quae vitae." },
                    { 33, "1", 3, "Nostrum delectus distinctio maiores ut.", new DateTime(2020, 2, 19, 8, 3, 37, 854, DateTimeKind.Local).AddTicks(5890), "Est ut repellat ipsa impedit.", null, "Quo dicta minus porro iure." },
                    { 39, "3", 3, "Ratione veniam aut natus consequuntur.", new DateTime(2019, 11, 2, 3, 47, 37, 332, DateTimeKind.Local).AddTicks(768), "Fuga sed occaecati possimus sint ratione quasi saepe sed beatae.", null, "Consectetur ducimus consequatur est ut." },
                    { 46, "1", 3, "Nam cumque est similique ex iste et.", new DateTime(2019, 8, 19, 22, 30, 4, 388, DateTimeKind.Local).AddTicks(8412), "Aspernatur et tempore ut vel aut dolor tempora.", null, "Ut qui expedita sapiente qui alias sit eos omnis." },
                    { 47, "3", 3, "Dolorum earum et odio et non est similique maxime.", new DateTime(2019, 11, 1, 7, 26, 58, 265, DateTimeKind.Local).AddTicks(2697), "Ut facilis libero consectetur sit.", null, "Enim voluptas necessitatibus." },
                    { 50, "3", 3, "Quidem magnam qui voluptate vitae aut.", new DateTime(2019, 8, 24, 16, 7, 5, 525, DateTimeKind.Local).AddTicks(7339), "Possimus adipisci omnis ut iure omnis et praesentium id.", null, "Quis nisi ducimus consequatur." },
                    { 5, "3", 4, "Commodi corporis rerum rem eveniet.", new DateTime(2019, 7, 1, 22, 56, 42, 753, DateTimeKind.Local).AddTicks(436), "Nesciunt quia quia rerum aperiam veniam.", null, "Aut et sed omnis occaecati minus animi officiis sed corporis." },
                    { 8, "1", 4, "Sed aliquam qui minus neque.", new DateTime(2019, 3, 28, 15, 17, 59, 901, DateTimeKind.Local).AddTicks(9409), "Vel quisquam ut voluptas animi et qui non eum aut.", null, "Veniam qui incidunt ut fuga porro velit." },
                    { 23, "1", 4, "Sed sint ea voluptatibus perspiciatis quisquam sed nulla.", new DateTime(2019, 5, 20, 12, 46, 54, 815, DateTimeKind.Local).AddTicks(2643), "Iure reprehenderit qui.", null, "Non eligendi dicta voluptatem ullam." },
                    { 24, "2", 4, "Sit consequatur hic dolores nihil iusto provident sit dignissimos.", new DateTime(2020, 3, 8, 13, 44, 5, 449, DateTimeKind.Local).AddTicks(4563), "Consectetur expedita autem.", null, "Ea a debitis et autem necessitatibus quia id quod perferendis." },
                    { 26, "3", 4, "Ipsa est rerum ex modi repellat nesciunt quisquam.", new DateTime(2019, 8, 9, 16, 7, 25, 93, DateTimeKind.Local).AddTicks(6779), "Dolor sequi libero magnam.", null, "Adipisci maiores voluptatum eum earum et laborum eius commodi iure." },
                    { 30, "2", 4, "Officia non eveniet esse ipsum nemo et laudantium praesentium.", new DateTime(2020, 2, 28, 12, 49, 30, 697, DateTimeKind.Local).AddTicks(5642), "Quia nesciunt sint dolore dolor.", null, "Est nulla neque a suscipit omnis provident." },
                    { 36, "2", 4, "Sunt consequatur dolore.", new DateTime(2020, 2, 14, 1, 10, 15, 548, DateTimeKind.Local).AddTicks(562), "Aliquid ratione aut quibusdam et perspiciatis labore aut.", null, "Maiores reiciendis id." },
                    { 48, "2", 4, "Recusandae dolorem dignissimos deserunt non impedit.", new DateTime(2020, 3, 7, 22, 44, 26, 80, DateTimeKind.Local).AddTicks(3794), "Corporis ea iure velit animi dolorem quod suscipit quaerat aperiam.", null, "Corrupti consequuntur dolorum." },
                    { 49, "3", 4, "Et ea voluptatem omnis neque aut maiores eveniet magnam.", new DateTime(2019, 8, 4, 10, 34, 1, 108, DateTimeKind.Local).AddTicks(9078), "Corporis veniam qui autem in voluptatem ut omnis commodi.", null, "Aut et esse voluptatem." },
                    { 12, "3", 5, "Maiores mollitia maiores.", new DateTime(2019, 6, 12, 23, 10, 34, 20, DateTimeKind.Local).AddTicks(886), "Rem voluptatibus sit exercitationem.", null, "Fugiat neque provident minus deserunt quos." },
                    { 15, "3", 5, "Rerum sint dolores vel libero blanditiis.", new DateTime(2019, 5, 9, 18, 8, 43, 566, DateTimeKind.Local).AddTicks(4264), "Dolorum vitae est.", null, "Quae suscipit quis delectus perferendis praesentium hic mollitia." },
                    { 27, "1", 5, "Aperiam omnis sapiente eligendi consequuntur ratione voluptas atque.", new DateTime(2019, 7, 22, 18, 13, 52, 345, DateTimeKind.Local).AddTicks(9608), "Amet hic eaque excepturi dolores aut et.", null, "Eum ex et minus est delectus tempora tenetur perspiciatis." },
                    { 32, "3", 5, "Est ut magni natus.", new DateTime(2019, 7, 2, 23, 53, 57, 735, DateTimeKind.Local).AddTicks(4730), "Quidem sit impedit vel eius porro nihil.", null, "Nostrum ut ratione eum explicabo consequatur." },
                    { 18, "3", 3, "Inventore omnis ipsam mollitia sed incidunt praesentium.", new DateTime(2019, 12, 5, 22, 26, 8, 619, DateTimeKind.Local).AddTicks(6834), "Recusandae fugiat labore tempore molestias magni corrupti autem cumque.", null, "Est blanditiis fugit ipsa rem dolorem doloremque cum." },
                    { 14, "3", 3, "Quibusdam sunt dolores quo non autem.", new DateTime(2019, 12, 13, 18, 3, 53, 955, DateTimeKind.Local).AddTicks(3469), "Consequatur illum excepturi esse.", null, "Hic vel ipsa." },
                    { 7, "3", 3, "Praesentium aperiam praesentium ut quos.", new DateTime(2020, 2, 12, 21, 21, 13, 42, DateTimeKind.Local).AddTicks(5132), "Dolorem illo laudantium culpa sit.", null, "Alias voluptatem et et quidem animi voluptatum delectus adipisci." },
                    { 6, "1", 3, "Enim dolores voluptatem cumque.", new DateTime(2019, 7, 23, 21, 35, 35, 598, DateTimeKind.Local).AddTicks(1171), "Eos nihil est autem dolorem optio accusantium nemo.", null, "Omnis illum expedita est dolorem eum." },
                    { 10, "2", 1, "Odit ratione aut.", new DateTime(2019, 4, 3, 23, 13, 1, 790, DateTimeKind.Local).AddTicks(1034), "Et veniam eum dicta beatae reprehenderit laudantium eum nemo.", null, "Ipsam quasi quia omnis." },
                    { 11, "2", 1, "Neque quia esse sit perspiciatis unde minus sit doloremque.", new DateTime(2020, 2, 8, 13, 57, 34, 622, DateTimeKind.Local).AddTicks(2026), "Voluptate nobis possimus veniam sequi dolorem.", null, "Culpa magni vitae officiis id maiores vel aspernatur." },
                    { 13, "1", 1, "Aut sit sit nulla sed dolor iste hic.", new DateTime(2019, 6, 24, 13, 31, 7, 346, DateTimeKind.Local).AddTicks(6212), "Et dicta et impedit est et sequi accusantium est.", null, "Earum nisi facilis autem porro eius dolor doloremque qui eveniet." },
                    { 17, "2", 1, "Facilis porro aut.", new DateTime(2019, 6, 21, 23, 16, 5, 768, DateTimeKind.Local).AddTicks(1290), "Esse qui est labore laboriosam.", null, "Quos officiis nostrum sed veritatis vitae temporibus." },
                    { 20, "3", 1, "Aut voluptatem ullam velit optio nihil soluta ut temporibus est.", new DateTime(2019, 3, 29, 2, 39, 52, 236, DateTimeKind.Local).AddTicks(5945), "Incidunt facilis optio quod quo enim.", null, "Vero velit vero culpa consequatur perferendis cupiditate non ipsam sint." },
                    { 21, "3", 1, "Fugiat aut sint porro earum sunt laborum distinctio quo voluptatem.", new DateTime(2019, 4, 29, 23, 24, 49, 119, DateTimeKind.Local).AddTicks(5491), "Sunt minus incidunt voluptatem aut in fuga aliquid.", null, "Quo nobis fugit ea natus animi." },
                    { 25, "2", 1, "Molestiae numquam voluptas ipsum.", new DateTime(2019, 5, 10, 20, 31, 43, 695, DateTimeKind.Local).AddTicks(9313), "Est qui et ut quo voluptates.", null, "Cupiditate error vero quam itaque sit sit consequuntur." },
                    { 28, "3", 1, "Asperiores voluptatem quo eos ad modi necessitatibus.", new DateTime(2019, 6, 8, 19, 50, 47, 509, DateTimeKind.Local).AddTicks(9233), "Dignissimos ullam explicabo ut.", null, "Quia fugit esse repellendus iure aut occaecati deleniti qui." },
                    { 35, "1", 1, "Mollitia id et vel perferendis non non commodi dolorum ipsam.", new DateTime(2019, 5, 6, 13, 22, 0, 982, DateTimeKind.Local).AddTicks(1820), "Consequuntur asperiores nisi recusandae fugit unde amet corrupti.", null, "Pariatur est aut qui deserunt harum." },
                    { 37, "3", 1, "Fugiat fugiat laboriosam accusamus et aut quia.", new DateTime(2019, 8, 27, 4, 49, 39, 528, DateTimeKind.Local).AddTicks(4485), "Ad facere asperiores voluptas eveniet ex tenetur.", null, "Sunt omnis enim velit odio rerum adipisci sint." },
                    { 34, "3", 5, "Et non ad natus ipsum.", new DateTime(2019, 11, 4, 17, 4, 16, 447, DateTimeKind.Local).AddTicks(2443), "Necessitatibus earum reprehenderit quia eveniet labore vitae iusto ullam.", null, "Quis sequi et dolorem sed." },
                    { 43, "2", 1, "Explicabo eligendi totam earum rem quas voluptates fuga sit.", new DateTime(2019, 6, 21, 15, 59, 37, 97, DateTimeKind.Local).AddTicks(3660), "Enim rerum magni eos aperiam at at.", null, "Libero molestiae quasi sed soluta." },
                    { 45, "1", 1, "Dicta nisi at quia rem iste quas sed.", new DateTime(2019, 6, 2, 8, 16, 3, 376, DateTimeKind.Local).AddTicks(2153), "Totam illum aut aut.", null, "Quia velit ipsa aspernatur ipsam aspernatur quia." },
                    { 1, "1", 2, "Quo quos sint officia provident.", new DateTime(2019, 12, 23, 22, 12, 51, 553, DateTimeKind.Local).AddTicks(4869), "Officia voluptas dolor voluptate accusamus asperiores dignissimos consequatur.", null, "Iste excepturi nesciunt consequatur similique placeat." },
                    { 2, "2", 2, "Enim pariatur facere et nihil.", new DateTime(2019, 6, 28, 20, 25, 21, 598, DateTimeKind.Local).AddTicks(9969), "Molestiae quis ut natus.", null, "Ratione earum consequatur sapiente commodi iure voluptatum et." },
                    { 4, "1", 2, "Asperiores voluptatum dolorem voluptas laudantium et quia.", new DateTime(2019, 12, 12, 17, 24, 49, 118, DateTimeKind.Local).AddTicks(5288), "Est molestiae et sit enim.", null, "Dolor consequatur quibusdam harum laborum magnam molestiae necessitatibus." },
                    { 9, "2", 2, "Fuga quia est vero molestiae alias eos provident.", new DateTime(2019, 8, 3, 1, 1, 52, 742, DateTimeKind.Local).AddTicks(6831), "Tempora quos ex perferendis et optio similique.", null, "Ut aliquid saepe." },
                    { 16, "2", 2, "Quam modi rem quibusdam vel ratione beatae magnam.", new DateTime(2020, 1, 11, 20, 19, 31, 596, DateTimeKind.Local).AddTicks(9751), "Et minima alias alias omnis voluptates voluptas nam nulla doloremque.", null, "Sed dolor possimus quae magni." },
                    { 29, "3", 2, "Aliquam quia consequuntur ea sit minima nulla.", new DateTime(2019, 11, 29, 13, 6, 43, 648, DateTimeKind.Local).AddTicks(6631), "Accusantium consequuntur temporibus exercitationem architecto.", null, "Tempora quisquam saepe et." },
                    { 40, "2", 2, "Dolor id consectetur adipisci reiciendis magni qui eveniet.", new DateTime(2020, 2, 7, 3, 43, 46, 779, DateTimeKind.Local).AddTicks(5223), "Quidem recusandae libero nihil debitis possimus labore.", null, "Provident voluptas iste recusandae cumque." },
                    { 41, "3", 2, "Optio velit laborum voluptates.", new DateTime(2019, 8, 16, 16, 15, 32, 522, DateTimeKind.Local).AddTicks(6260), "Qui ullam reiciendis qui illo non molestias dolores.", null, "Consequuntur harum quo et inventore et dolore." },
                    { 42, "3", 2, "Molestias omnis incidunt atque possimus est.", new DateTime(2020, 2, 2, 7, 17, 48, 889, DateTimeKind.Local).AddTicks(2089), "Modi animi consequatur.", null, "Velit in reprehenderit eum quidem sed quis fugit fugit praesentium." },
                    { 44, "2", 1, "Quas voluptate et optio velit iure.", new DateTime(2020, 2, 28, 22, 12, 25, 960, DateTimeKind.Local).AddTicks(4860), "Excepturi delectus est eius voluptates iusto recusandae optio laboriosam.", null, "Voluptas quasi quia inventore aliquid." },
                    { 38, "1", 5, "Cupiditate autem dolore ut consectetur.", new DateTime(2019, 6, 28, 23, 9, 52, 177, DateTimeKind.Local).AddTicks(7928), "Non libero voluptate enim impedit hic dolores.", null, "Repellat autem quia vero officiis nobis." }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "DateCreated", "IsAnonymous", "PostId" },
                values: new object[,]
                {
                    { 3, "3", "Equatorial Guinea Games", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 50, "2", "hacking Small Fresh Gloves", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 2, "2", "generate Books deposit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 6, "2", "Health, Books & Tools", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 8, "2", "Incredible Wooden Shoes quantify", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 9, "2", "asynchronous Configuration", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 10, "3", "impactful Mountain", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 12, "1", "Credit Card Account synergies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 13, "3", "Generic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 16, "1", "Qatari Rial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 18, "2", "multi-byte District", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 19, "2", "transmitter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 20, "3", "Regional Afghani", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 21, "1", "Representative zero tolerance", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 24, "1", "Gorgeous Metal Mouse Outdoors", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 27, "3", "Unbranded Licensed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 31, "3", "green GB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 32, "1", "Swedish Krona", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 35, "3", "stable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 36, "2", "invoice Brook", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 40, "2", "Money Market Account invoice green", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 41, "1", "Congolese Franc synthesize", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 46, "2", "Refined Granite Cheese Sports", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 39, "1", "Grove", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 37, "3", "De-engineered deposit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 33, "2", "Direct Forks Credit Card Account", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 4, "2", "niches", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 7, "3", "bypass", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 11, "3", "USB withdrawal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 14, "3", "zero tolerance", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 25, "2", "Walks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 28, "2", "Mobility invoice dynamic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 34, "1", "Outdoors, Computers & Home fresh-thinking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 38, "2", "budgetary management", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 42, "1", "Movies Sleek Metal Cheese", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 44, "3", "parsing optical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 43, "2", "Rubber Jamaican Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 45, "2", "Haiti Ways", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 49, "1", "deposit Mountains Gorgeous", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 1, "1", "deposit Soft Fantastic Concrete Pants", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 5, "3", "mobile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 15, "2", "THX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 17, "1", "Investment Account", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 22, "1", "JSON Money Market Account", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 23, "3", "Unbranded Metal Shirt Cambridgeshire", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 26, "3", "Camp revolutionize Digitized", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 29, "1", "Platinum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 30, "2", "Dam Automotive, Movies & Health maximize", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 47, "3", "Solutions generate", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 48, "1", "communities Island Saint Lucia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 }
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
