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
                    { "1", 0, "3ac2ef7e-96fa-43e4-8b7f-1b63928424d6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bennett.Hills19@gmail.com", false, false, false, null, null, null, "password", null, false, "8b3032d5-07bc-420d-a28e-3673b29677f2", false, "Dino" },
                    { "28", 0, "cc9a62d4-d68c-4856-89cf-a4a0cb29b6b7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bennett.Mertz76@gmail.com", false, false, false, null, null, null, "password", null, false, "ac6d74b4-0272-4de6-9b14-0c8951b07856", false, "Lisandro" },
                    { "29", 0, "5fedb40a-1b63-4b26-80a4-1d303f98727d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ara37@yahoo.com", false, false, false, null, null, null, "password", null, false, "40fbfc7b-53b3-45e8-ae05-27cf64804648", false, "Susana" },
                    { "30", 0, "3dcc9887-ba0f-4b85-9467-57ab6e19167b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilhelm.Rutherford31@hotmail.com", false, false, false, null, null, null, "password", null, false, "1521e0ad-92f7-421e-9887-e5a24d56eda5", false, "Bradley" },
                    { "31", 0, "3e43e34e-8c3e-4620-8675-b1aca9f175d3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avis_Mosciski24@yahoo.com", false, false, false, null, null, null, "password", null, false, "3b891580-9fcb-4e7a-8cde-de42d3ac3de6", false, "Lura" },
                    { "32", 0, "211b59ae-4470-415a-9d06-f0d5b8fce261", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavina57@gmail.com", false, false, false, null, null, null, "password", null, false, "9a900d22-0211-417a-9ed2-785c10d79eb7", false, "Andrew" },
                    { "33", 0, "2b93bc05-9db7-434e-acbf-32a6f73ba8f1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casey_Cruickshank@yahoo.com", false, false, false, null, null, null, "password", null, false, "9e81597e-5267-4457-bdd1-b5f2de1e0c24", false, "Stephania" },
                    { "34", 0, "a87468bf-9cdc-4ea9-9962-d98b22cfb8f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ernest.Jacobs62@hotmail.com", false, false, false, null, null, null, "password", null, false, "51fc8ade-8fd5-40bc-bbd1-aa5272bcf4db", false, "Dane" },
                    { "35", 0, "640ac742-a6e4-4086-87a0-9b22c779f0fd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby7@gmail.com", false, false, false, null, null, null, "password", null, false, "d1f5a3a0-536b-40ee-a6d3-7dd6940f8a84", false, "Alana" },
                    { "36", 0, "07e2d59a-fda2-4219-b757-d2e37813338c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlotta.Lehner@hotmail.com", false, false, false, null, null, null, "password", null, false, "05941abc-c526-46da-a4b0-a7d6f0007b04", false, "Roel" },
                    { "37", 0, "234940ef-be5e-4964-a239-c80df09cf203", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdullah2@hotmail.com", false, false, false, null, null, null, "password", null, false, "3574202f-7115-4492-a2c3-8d4db96569a6", false, "Mafalda" },
                    { "27", 0, "9cfb8a76-9422-4a67-ba3a-6642864bedf1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amir.Windler50@hotmail.com", false, false, false, null, null, null, "password", null, false, "a5d8ee7b-8e67-40c7-8105-31d2e1a1d137", false, "Elian" },
                    { "38", 0, "e0797f82-38c9-43e9-a992-58236a5401fb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vallie.Kovacek65@hotmail.com", false, false, false, null, null, null, "password", null, false, "84e32548-df7d-4b86-8430-0af6b4464a5a", false, "Malachi" },
                    { "40", 0, "4f894be3-b3a1-40ad-bea0-a5bcd89ea3ec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elmira.Hudson1@hotmail.com", false, false, false, null, null, null, "password", null, false, "eacf2847-b405-469c-802e-01b3abcf1093", false, "Grace" },
                    { "41", 0, "7bad7fc9-2a29-4ffe-a53c-0e2b295ce2fd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darwin.Bauch@yahoo.com", false, false, false, null, null, null, "password", null, false, "78a1a7b7-b878-4bfc-adc8-5ed16cf71ca4", false, "Stephen" },
                    { "42", 0, "6e75b5a6-e4a6-44d1-98fa-1723703712d2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgil.Hintz@hotmail.com", false, false, false, null, null, null, "password", null, false, "44380374-ce6c-4411-b553-e418c7ae5f57", false, "Norbert" },
                    { "43", 0, "28dc263b-107a-4341-bd15-0c86adeb19aa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dimitri_White@gmail.com", false, false, false, null, null, null, "password", null, false, "3186dd5a-f4d9-46a6-a211-6654528b6333", false, "Gay" },
                    { "44", 0, "2a1265fc-e89b-425d-a194-ae2d5237915f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "King17@hotmail.com", false, false, false, null, null, null, "password", null, false, "6cc87ded-12b0-41e0-a8e6-7286e116ab19", false, "Verla" },
                    { "45", 0, "9e853fd1-8ec8-40f7-b992-150203270f7b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "River.Abernathy@hotmail.com", false, false, false, null, null, null, "password", null, false, "8e582169-5da0-4f3c-87f4-01b31e2ba5e8", false, "Zachary" },
                    { "46", 0, "7970442d-e58d-4d25-a31f-e4bda6cc4e3b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Violet_Anderson26@hotmail.com", false, false, false, null, null, null, "password", null, false, "f23edae4-3b73-4e0d-96df-886bd128eca8", false, "Jaime" },
                    { "47", 0, "a77aff07-66b3-4a02-83fb-10ba8f33f034", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eriberto1@gmail.com", false, false, false, null, null, null, "password", null, false, "8ad634e4-1308-4086-aac6-163e8f61b069", false, "Hilton" },
                    { "48", 0, "4ab8c107-f5d5-452e-8083-9e4cb7058594", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest.Hamill@yahoo.com", false, false, false, null, null, null, "password", null, false, "4e12c725-cadf-4e5e-8517-1083bb99e201", false, "Izabella" },
                    { "49", 0, "e6d3785b-5438-4f12-9f07-e3be4a10a484", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominique.Schaden76@yahoo.com", false, false, false, null, null, null, "password", null, false, "6371396c-b4e0-4444-bdad-2ec52279b591", false, "Florencio" },
                    { "39", 0, "0c9d2158-8c71-464a-ad95-ef7ea78959ea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unique_Wunsch70@hotmail.com", false, false, false, null, null, null, "password", null, false, "16673c05-8a3d-4ff3-a1dd-89007021cebe", false, "Callie" },
                    { "26", 0, "e9ac6c6f-6e72-4a6b-b45d-58e228656f19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jarrell.Friesen97@yahoo.com", false, false, false, null, null, null, "password", null, false, "08dddfd6-dffb-4740-9419-1bb311b0d4cd", false, "Mark" },
                    { "50", 0, "30cc53d7-aef5-441c-a080-17ee38184bfa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dayna_Schmitt@gmail.com", false, false, false, null, null, null, "password", null, false, "4cc7a8d8-2e71-464f-a9b3-6e312faf8745", false, "Dameon" },
                    { "24", 0, "4aa9c545-4005-4926-883e-4b25860f0b65", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maci.Welch40@hotmail.com", false, false, false, null, null, null, "password", null, false, "1a5953a9-cf7f-42a1-8150-7d17c7cda444", false, "Florence" },
                    { "2", 0, "abaa1319-11b2-4631-8c6b-37dfa290245c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karson_Boyer@hotmail.com", false, false, false, null, null, null, "password", null, false, "8ebaee64-37d5-410f-9824-b151528dfef5", false, "Gisselle" },
                    { "3", 0, "5dae1dad-92ed-4656-91aa-f4e580d2fbf7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melody_Rath@hotmail.com", false, false, false, null, null, null, "password", null, false, "22de2c04-c566-4703-8b4c-7ec913976e86", false, "Beaulah" },
                    { "4", 0, "ac01fc79-02a8-4bc1-802d-d283d3264f27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaylan.Padberg32@gmail.com", false, false, false, null, null, null, "password", null, false, "2e5c2c75-2207-493d-89de-dc1dcbd43040", false, "Armand" },
                    { "5", 0, "8a6aac1b-2a43-47b5-a9cb-a88621b91742", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adan_Luettgen@hotmail.com", false, false, false, null, null, null, "password", null, false, "a944f7ea-4b5d-4560-91c1-92e3c25f7ebe", false, "Ari" },
                    { "6", 0, "4d9d7b20-f972-4b5c-9f19-4e85b653ddfe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berenice.Bradtke41@hotmail.com", false, false, false, null, null, null, "password", null, false, "abbf9670-5123-40f4-922e-a93ff9a83061", false, "Tatum" },
                    { "7", 0, "df0ce17e-c304-48e0-942c-0cb425fdcd4f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charity35@hotmail.com", false, false, false, null, null, null, "password", null, false, "858fe75b-10fd-4954-a2db-4f6dc2d97c11", false, "Madeline" },
                    { "25", 0, "12990660-81f4-4fa2-a3ba-8971694cd429", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mittie.Erdman9@gmail.com", false, false, false, null, null, null, "password", null, false, "1c74ad3c-a2e1-4120-8908-5d5160eac46e", false, "Pattie" },
                    { "9", 0, "7249b78d-4653-4843-bb8e-e1643daade44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clint43@hotmail.com", false, false, false, null, null, null, "password", null, false, "509e9ec9-61c8-46a3-b1e2-9603fca31348", false, "Glenna" },
                    { "10", 0, "4f9378fe-9d37-41eb-8dc3-177b28a81c9c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dortha69@yahoo.com", false, false, false, null, null, null, "password", null, false, "dd369dd3-a58c-41f3-a9f5-f35ce188a25a", false, "Camryn" },
                    { "11", 0, "0c6ce2d6-306a-4561-bb15-fa4e5dc49d13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harvey.Kertzmann@yahoo.com", false, false, false, null, null, null, "password", null, false, "093b1012-6004-4062-a7c9-920bdba66a10", false, "Zachariah" },
                    { "12", 0, "29ae7b04-2e7f-4704-bdf7-07e45ea5c0d4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol90@gmail.com", false, false, false, null, null, null, "password", null, false, "70991554-3a53-4800-a612-35933dcad4d4", false, "Lenora" },
                    { "8", 0, "87d43c34-d375-4bc5-99f8-cf17c5bbfc79", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maye44@yahoo.com", false, false, false, null, null, null, "password", null, false, "ac414909-6163-43e0-82ea-7eb33f829c74", false, "Ariel" },
                    { "14", 0, "1731bc97-d0c0-4288-a3a8-6351bf6090ac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wyatt40@yahoo.com", false, false, false, null, null, null, "password", null, false, "8dfc647b-b92a-421e-8c8b-fe4a66c4cb1b", false, "Khalil" },
                    { "15", 0, "cf05f902-62eb-42ca-a9c3-188b9f561b9c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floy.Ortiz@hotmail.com", false, false, false, null, null, null, "password", null, false, "70c8cf4b-dd49-406c-bf20-a08958a11c62", false, "Betty" },
                    { "16", 0, "92ecbf40-3e8c-4d64-a0c1-60ff2ccb8a13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dejon63@hotmail.com", false, false, false, null, null, null, "password", null, false, "2119422d-29bc-48db-b006-1a4ef6d6c3b9", false, "Terrance" },
                    { "17", 0, "fae322e3-1d31-4618-89df-5f318a970021", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucy.Fisher@gmail.com", false, false, false, null, null, null, "password", null, false, "26d068c0-e35e-4989-9224-4c5ffdbda700", false, "Sadye" },
                    { "18", 0, "0a26bd11-a8b1-4f9b-a0eb-e53b4d0db291", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chesley5@gmail.com", false, false, false, null, null, null, "password", null, false, "4d30aa9d-f347-48b5-acfa-c2c0bd9212f4", false, "Dave" },
                    { "19", 0, "3ea195b0-4c39-417c-b06f-cd554cf29e8f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisandro.Terry31@gmail.com", false, false, false, null, null, null, "password", null, false, "2730189f-edd6-413d-9664-e7db5cfb3789", false, "Quinton" },
                    { "20", 0, "20c321b7-49fe-4cc4-a1dd-7ce2920d38aa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry55@gmail.com", false, false, false, null, null, null, "password", null, false, "671a860b-8f3e-4913-8c7f-c810d32e51aa", false, "Sherman" },
                    { "21", 0, "e1d06bc9-8385-4802-8cfb-63b3bab77fe7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laisha_Gulgowski70@hotmail.com", false, false, false, null, null, null, "password", null, false, "d30c18e9-9634-4fbc-b775-4192e6f306ed", false, "Trever" },
                    { "22", 0, "114e023c-4ae3-4872-854a-a2a852f019b9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachery.Hintz@yahoo.com", false, false, false, null, null, null, "password", null, false, "1cabed33-c261-4b14-ab98-a48f8dbca7a5", false, "Abe" },
                    { "23", 0, "003bab83-4c28-47af-8368-2d4b41aab811", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Courtney22@hotmail.com", false, false, false, null, null, null, "password", null, false, "5940adde-ee92-413e-acf9-4764bd4038a2", false, "Kiara" },
                    { "13", 0, "3011df40-7ee3-4959-860e-221db2daf8f8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anya62@yahoo.com", false, false, false, null, null, null, "password", null, false, "13d541d7-93a4-48ab-9c4d-48b15270d9a1", false, "Nayeli" }
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
                    { 3, "3", 1, "Delectus autem recusandae et repellendus sint quisquam veritatis.", new DateTime(2020, 2, 1, 21, 7, 39, 855, DateTimeKind.Local).AddTicks(1353), "Nulla et eveniet enim exercitationem temporibus id nihil consequatur molestiae.", null, "Et et tempore." },
                    { 19, "2", 3, "Necessitatibus at repellat libero sunt sint tempora.", new DateTime(2019, 8, 22, 15, 30, 55, 753, DateTimeKind.Local).AddTicks(6732), "Dolor quos officia quaerat omnis in.", null, "Dignissimos id deserunt aut assumenda." },
                    { 22, "1", 3, "Illum necessitatibus sit eius sapiente ducimus qui architecto blanditiis facilis.", new DateTime(2019, 10, 30, 20, 36, 37, 895, DateTimeKind.Local).AddTicks(173), "Velit sed officia et itaque deserunt nemo illo.", null, "Ut dolor voluptas aspernatur occaecati sapiente culpa eum voluptatem." },
                    { 31, "3", 3, "Suscipit officiis ut natus et.", new DateTime(2020, 3, 3, 4, 34, 12, 504, DateTimeKind.Local).AddTicks(317), "Eligendi in aliquam reiciendis placeat.", null, "Sed est rerum earum velit perspiciatis quidem aut quae vitae." },
                    { 33, "1", 3, "Nostrum delectus distinctio maiores ut.", new DateTime(2020, 2, 24, 3, 38, 50, 356, DateTimeKind.Local).AddTicks(3025), "Est ut repellat ipsa impedit.", null, "Quo dicta minus porro iure." },
                    { 39, "3", 3, "Ratione veniam aut natus consequuntur.", new DateTime(2019, 11, 6, 23, 22, 49, 833, DateTimeKind.Local).AddTicks(7881), "Fuga sed occaecati possimus sint ratione quasi saepe sed beatae.", null, "Consectetur ducimus consequatur est ut." },
                    { 46, "1", 3, "Nam cumque est similique ex iste et.", new DateTime(2019, 8, 24, 18, 5, 16, 890, DateTimeKind.Local).AddTicks(5494), "Aspernatur et tempore ut vel aut dolor tempora.", null, "Ut qui expedita sapiente qui alias sit eos omnis." },
                    { 47, "3", 3, "Dolorum earum et odio et non est similique maxime.", new DateTime(2019, 11, 6, 3, 2, 10, 766, DateTimeKind.Local).AddTicks(9789), "Ut facilis libero consectetur sit.", null, "Enim voluptas necessitatibus." },
                    { 50, "3", 3, "Quidem magnam qui voluptate vitae aut.", new DateTime(2019, 8, 29, 11, 42, 18, 27, DateTimeKind.Local).AddTicks(4398), "Possimus adipisci omnis ut iure omnis et praesentium id.", null, "Quis nisi ducimus consequatur." },
                    { 5, "3", 4, "Commodi corporis rerum rem eveniet.", new DateTime(2019, 7, 6, 18, 31, 55, 254, DateTimeKind.Local).AddTicks(7882), "Nesciunt quia quia rerum aperiam veniam.", null, "Aut et sed omnis occaecati minus animi officiis sed corporis." },
                    { 8, "1", 4, "Sed aliquam qui minus neque.", new DateTime(2019, 4, 2, 10, 53, 12, 403, DateTimeKind.Local).AddTicks(6842), "Vel quisquam ut voluptas animi et qui non eum aut.", null, "Veniam qui incidunt ut fuga porro velit." },
                    { 23, "1", 4, "Sed sint ea voluptatibus perspiciatis quisquam sed nulla.", new DateTime(2019, 5, 25, 8, 22, 7, 316, DateTimeKind.Local).AddTicks(9864), "Iure reprehenderit qui.", null, "Non eligendi dicta voluptatem ullam." },
                    { 24, "2", 4, "Sit consequatur hic dolores nihil iusto provident sit dignissimos.", new DateTime(2020, 3, 13, 9, 19, 17, 951, DateTimeKind.Local).AddTicks(1746), "Consectetur expedita autem.", null, "Ea a debitis et autem necessitatibus quia id quod perferendis." },
                    { 26, "3", 4, "Ipsa est rerum ex modi repellat nesciunt quisquam.", new DateTime(2019, 8, 14, 11, 42, 37, 595, DateTimeKind.Local).AddTicks(3967), "Dolor sequi libero magnam.", null, "Adipisci maiores voluptatum eum earum et laborum eius commodi iure." },
                    { 30, "2", 4, "Officia non eveniet esse ipsum nemo et laudantium praesentium.", new DateTime(2020, 3, 4, 8, 24, 43, 199, DateTimeKind.Local).AddTicks(2797), "Quia nesciunt sint dolore dolor.", null, "Est nulla neque a suscipit omnis provident." },
                    { 36, "2", 4, "Sunt consequatur dolore.", new DateTime(2020, 2, 18, 20, 45, 28, 49, DateTimeKind.Local).AddTicks(7681), "Aliquid ratione aut quibusdam et perspiciatis labore aut.", null, "Maiores reiciendis id." },
                    { 48, "2", 4, "Recusandae dolorem dignissimos deserunt non impedit.", new DateTime(2020, 3, 12, 18, 19, 38, 582, DateTimeKind.Local).AddTicks(892), "Corporis ea iure velit animi dolorem quod suscipit quaerat aperiam.", null, "Corrupti consequuntur dolorum." },
                    { 49, "3", 4, "Et ea voluptatem omnis neque aut maiores eveniet magnam.", new DateTime(2019, 8, 9, 6, 9, 13, 610, DateTimeKind.Local).AddTicks(6133), "Corporis veniam qui autem in voluptatem ut omnis commodi.", null, "Aut et esse voluptatem." },
                    { 12, "3", 5, "Maiores mollitia maiores.", new DateTime(2019, 6, 17, 18, 45, 46, 521, DateTimeKind.Local).AddTicks(8295), "Rem voluptatibus sit exercitationem.", null, "Fugiat neque provident minus deserunt quos." },
                    { 15, "3", 5, "Rerum sint dolores vel libero blanditiis.", new DateTime(2019, 5, 14, 13, 43, 56, 68, DateTimeKind.Local).AddTicks(1606), "Dolorum vitae est.", null, "Quae suscipit quis delectus perferendis praesentium hic mollitia." },
                    { 27, "1", 5, "Aperiam omnis sapiente eligendi consequuntur ratione voluptas atque.", new DateTime(2019, 7, 27, 13, 49, 4, 847, DateTimeKind.Local).AddTicks(6777), "Amet hic eaque excepturi dolores aut et.", null, "Eum ex et minus est delectus tempora tenetur perspiciatis." },
                    { 32, "3", 5, "Est ut magni natus.", new DateTime(2019, 7, 7, 19, 29, 10, 237, DateTimeKind.Local).AddTicks(1866), "Quidem sit impedit vel eius porro nihil.", null, "Nostrum ut ratione eum explicabo consequatur." },
                    { 18, "3", 3, "Inventore omnis ipsam mollitia sed incidunt praesentium.", new DateTime(2019, 12, 10, 18, 1, 21, 121, DateTimeKind.Local).AddTicks(4128), "Recusandae fugiat labore tempore molestias magni corrupti autem cumque.", null, "Est blanditiis fugit ipsa rem dolorem doloremque cum." },
                    { 14, "3", 3, "Quibusdam sunt dolores quo non autem.", new DateTime(2019, 12, 18, 13, 39, 6, 457, DateTimeKind.Local).AddTicks(856), "Consequatur illum excepturi esse.", null, "Hic vel ipsa." },
                    { 7, "3", 3, "Praesentium aperiam praesentium ut quos.", new DateTime(2020, 2, 17, 16, 56, 25, 544, DateTimeKind.Local).AddTicks(2590), "Dolorem illo laudantium culpa sit.", null, "Alias voluptatem et et quidem animi voluptatum delectus adipisci." },
                    { 6, "1", 3, "Enim dolores voluptatem cumque.", new DateTime(2019, 7, 28, 17, 10, 48, 99, DateTimeKind.Local).AddTicks(8625), "Eos nihil est autem dolorem optio accusantium nemo.", null, "Omnis illum expedita est dolorem eum." },
                    { 10, "2", 1, "Odit ratione aut.", new DateTime(2019, 4, 8, 18, 48, 14, 291, DateTimeKind.Local).AddTicks(8438), "Et veniam eum dicta beatae reprehenderit laudantium eum nemo.", null, "Ipsam quasi quia omnis." },
                    { 11, "2", 1, "Neque quia esse sit perspiciatis unde minus sit doloremque.", new DateTime(2020, 2, 13, 9, 32, 47, 123, DateTimeKind.Local).AddTicks(9433), "Voluptate nobis possimus veniam sequi dolorem.", null, "Culpa magni vitae officiis id maiores vel aspernatur." },
                    { 13, "1", 1, "Aut sit sit nulla sed dolor iste hic.", new DateTime(2019, 6, 29, 9, 6, 19, 848, DateTimeKind.Local).AddTicks(3598), "Et dicta et impedit est et sequi accusantium est.", null, "Earum nisi facilis autem porro eius dolor doloremque qui eveniet." },
                    { 17, "2", 1, "Facilis porro aut.", new DateTime(2019, 6, 26, 18, 51, 18, 269, DateTimeKind.Local).AddTicks(8636), "Esse qui est labore laboriosam.", null, "Quos officiis nostrum sed veritatis vitae temporibus." },
                    { 20, "3", 1, "Aut voluptatem ullam velit optio nihil soluta ut temporibus est.", new DateTime(2019, 4, 2, 22, 15, 4, 738, DateTimeKind.Local).AddTicks(3194), "Incidunt facilis optio quod quo enim.", null, "Vero velit vero culpa consequatur perferendis cupiditate non ipsam sint." },
                    { 21, "3", 1, "Fugiat aut sint porro earum sunt laborum distinctio quo voluptatem.", new DateTime(2019, 5, 4, 19, 0, 1, 621, DateTimeKind.Local).AddTicks(2745), "Sunt minus incidunt voluptatem aut in fuga aliquid.", null, "Quo nobis fugit ea natus animi." },
                    { 25, "2", 1, "Molestiae numquam voluptas ipsum.", new DateTime(2019, 5, 15, 16, 6, 56, 197, DateTimeKind.Local).AddTicks(6501), "Est qui et ut quo voluptates.", null, "Cupiditate error vero quam itaque sit sit consequuntur." },
                    { 28, "3", 1, "Asperiores voluptatem quo eos ad modi necessitatibus.", new DateTime(2019, 6, 13, 15, 26, 0, 11, DateTimeKind.Local).AddTicks(6405), "Dignissimos ullam explicabo ut.", null, "Quia fugit esse repellendus iure aut occaecati deleniti qui." },
                    { 35, "1", 1, "Mollitia id et vel perferendis non non commodi dolorum ipsam.", new DateTime(2019, 5, 11, 8, 57, 13, 483, DateTimeKind.Local).AddTicks(8956), "Consequuntur asperiores nisi recusandae fugit unde amet corrupti.", null, "Pariatur est aut qui deserunt harum." },
                    { 37, "3", 1, "Fugiat fugiat laboriosam accusamus et aut quia.", new DateTime(2019, 9, 1, 0, 24, 52, 30, DateTimeKind.Local).AddTicks(1615), "Ad facere asperiores voluptas eveniet ex tenetur.", null, "Sunt omnis enim velit odio rerum adipisci sint." },
                    { 34, "3", 5, "Et non ad natus ipsum.", new DateTime(2019, 11, 9, 12, 39, 28, 948, DateTimeKind.Local).AddTicks(9542), "Necessitatibus earum reprehenderit quia eveniet labore vitae iusto ullam.", null, "Quis sequi et dolorem sed." },
                    { 43, "2", 1, "Explicabo eligendi totam earum rem quas voluptates fuga sit.", new DateTime(2019, 6, 26, 11, 34, 49, 599, DateTimeKind.Local).AddTicks(775), "Enim rerum magni eos aperiam at at.", null, "Libero molestiae quasi sed soluta." },
                    { 45, "1", 1, "Dicta nisi at quia rem iste quas sed.", new DateTime(2019, 6, 7, 3, 51, 15, 877, DateTimeKind.Local).AddTicks(9258), "Totam illum aut aut.", null, "Quia velit ipsa aspernatur ipsam aspernatur quia." },
                    { 1, "1", 2, "Quo quos sint officia provident.", new DateTime(2019, 12, 28, 17, 48, 4, 54, DateTimeKind.Local).AddTicks(9241), "Officia voluptas dolor voluptate accusamus asperiores dignissimos consequatur.", null, "Iste excepturi nesciunt consequatur similique placeat." },
                    { 2, "2", 2, "Enim pariatur facere et nihil.", new DateTime(2019, 7, 3, 16, 0, 34, 100, DateTimeKind.Local).AddTicks(7132), "Molestiae quis ut natus.", null, "Ratione earum consequatur sapiente commodi iure voluptatum et." },
                    { 4, "1", 2, "Asperiores voluptatum dolorem voluptas laudantium et quia.", new DateTime(2019, 12, 17, 13, 0, 1, 620, DateTimeKind.Local).AddTicks(2756), "Est molestiae et sit enim.", null, "Dolor consequatur quibusdam harum laborum magnam molestiae necessitatibus." },
                    { 9, "2", 2, "Fuga quia est vero molestiae alias eos provident.", new DateTime(2019, 8, 7, 20, 37, 5, 244, DateTimeKind.Local).AddTicks(4264), "Tempora quos ex perferendis et optio similique.", null, "Ut aliquid saepe." },
                    { 16, "2", 2, "Quam modi rem quibusdam vel ratione beatae magnam.", new DateTime(2020, 1, 16, 15, 54, 44, 98, DateTimeKind.Local).AddTicks(7095), "Et minima alias alias omnis voluptates voluptas nam nulla doloremque.", null, "Sed dolor possimus quae magni." },
                    { 29, "3", 2, "Aliquam quia consequuntur ea sit minima nulla.", new DateTime(2019, 12, 4, 8, 41, 56, 150, DateTimeKind.Local).AddTicks(3777), "Accusantium consequuntur temporibus exercitationem architecto.", null, "Tempora quisquam saepe et." },
                    { 40, "2", 2, "Dolor id consectetur adipisci reiciendis magni qui eveniet.", new DateTime(2020, 2, 11, 23, 18, 59, 281, DateTimeKind.Local).AddTicks(2347), "Quidem recusandae libero nihil debitis possimus labore.", null, "Provident voluptas iste recusandae cumque." },
                    { 41, "3", 2, "Optio velit laborum voluptates.", new DateTime(2019, 8, 21, 11, 50, 45, 24, DateTimeKind.Local).AddTicks(3362), "Qui ullam reiciendis qui illo non molestias dolores.", null, "Consequuntur harum quo et inventore et dolore." },
                    { 42, "3", 2, "Molestias omnis incidunt atque possimus est.", new DateTime(2020, 2, 7, 2, 53, 1, 390, DateTimeKind.Local).AddTicks(9202), "Modi animi consequatur.", null, "Velit in reprehenderit eum quidem sed quis fugit fugit praesentium." },
                    { 44, "2", 1, "Quas voluptate et optio velit iure.", new DateTime(2020, 3, 4, 17, 47, 38, 462, DateTimeKind.Local).AddTicks(1960), "Excepturi delectus est eius voluptates iusto recusandae optio laboriosam.", null, "Voluptas quasi quia inventore aliquid." },
                    { 38, "1", 5, "Cupiditate autem dolore ut consectetur.", new DateTime(2019, 7, 3, 18, 45, 4, 679, DateTimeKind.Local).AddTicks(5062), "Non libero voluptate enim impedit hic dolores.", null, "Repellat autem quia vero officiis nobis." }
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
