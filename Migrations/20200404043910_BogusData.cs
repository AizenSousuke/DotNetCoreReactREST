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
                    { "1", 0, "3a3ced38-84bb-4985-9ed4-3ef5456f3791", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bennett.Hills19@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "1d852442-f05f-4f54-93f9-026d5c769f71", false, "Dino" },
                    { "28", 0, "d4856db0-2e79-4eb5-8d78-9a1dd6da80ea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bennett.Mertz76@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "63082303-1058-4e9b-b75c-ce2a8e8219ee", false, "Lisandro" },
                    { "29", 0, "6a44fcf3-0bdc-4fc8-85eb-63688895d270", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ara37@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "9e0175e6-95c0-4373-8453-953c5b14f287", false, "Susana" },
                    { "30", 0, "cb505e93-7f58-41d6-a533-19a6df21285b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilhelm.Rutherford31@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "94307f19-5c55-490a-80eb-cca517c5885e", false, "Bradley" },
                    { "31", 0, "7d9b1425-be88-4b7d-aed2-beb4ebd47d66", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avis_Mosciski24@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "6c743c97-fb8f-466f-a5f1-59223c123bda", false, "Lura" },
                    { "32", 0, "291cad3c-2dbc-45d8-ad64-c00ee79f60c8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavina57@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "69eb35d1-5a4e-4cc8-827d-f611edffc610", false, "Andrew" },
                    { "33", 0, "ae4f4b35-d310-495c-b40e-94604c9930ba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casey_Cruickshank@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "c339d81d-51de-4289-90aa-c096fa773c12", false, "Stephania" },
                    { "34", 0, "da496df9-9852-46a2-b7b1-4192f3760341", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ernest.Jacobs62@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "40273038-1db1-4849-97f6-0340510c2069", false, "Dane" },
                    { "35", 0, "6d0105b5-0741-4243-900d-ef3d5d4e017a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby7@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "b5f54eef-8db8-42a7-ba26-a871e82aa1b8", false, "Alana" },
                    { "36", 0, "a1191f98-4ee8-437c-963f-5c6abef9f524", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlotta.Lehner@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "9d2e080c-b6c3-4c1c-bd2b-805db89176e8", false, "Roel" },
                    { "37", 0, "29d8a331-f7ff-42b6-a3de-7f6b85793c8a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdullah2@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "7c85d303-8742-4123-b767-069401c7258e", false, "Mafalda" },
                    { "27", 0, "df15f5aa-7d13-4f9b-b971-d566ca27a579", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amir.Windler50@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "249d1877-85ec-44bb-aef8-3431a0009753", false, "Elian" },
                    { "38", 0, "d4fc777a-6c54-44c7-9264-40207f02e918", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vallie.Kovacek65@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "b300de22-87a2-4cf8-8a81-85e7c9e7498b", false, "Malachi" },
                    { "40", 0, "9dae1972-1d18-48fa-a590-eadfb27c35f8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elmira.Hudson1@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "2e025b64-e7e0-407b-9bf7-cc1f5726dea1", false, "Grace" },
                    { "41", 0, "042dc2b8-5074-468f-9a9e-c5b47ac5d541", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darwin.Bauch@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "a52e0ac1-7699-4549-824f-a2acd43676db", false, "Stephen" },
                    { "42", 0, "e3afd325-98e3-4a4e-aa9e-0d70e9adf743", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgil.Hintz@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "16949520-6602-408d-b954-d3ee25327e3d", false, "Norbert" },
                    { "43", 0, "ab53eec0-a88d-4fcb-8e86-e47139331872", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dimitri_White@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "ce355c0c-914b-421a-b23c-ab7134e0b427", false, "Gay" },
                    { "44", 0, "87cd8422-eaf4-4341-a1d1-0436f8c7d044", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "King17@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "32398dde-99c9-4ba2-9825-eb0a1d2f239d", false, "Verla" },
                    { "45", 0, "a75ed5ad-20ca-4211-9904-7a5f8e00c9cb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "River.Abernathy@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "f739a56a-6b67-4b35-9aa9-17040b4038bb", false, "Zachary" },
                    { "46", 0, "3e1170ea-1b4f-4660-8e53-3b44bcdb8e16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Violet_Anderson26@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "2285c803-b590-49ae-8af4-a1c3092ac89c", false, "Jaime" },
                    { "47", 0, "ebfb107c-d735-4b0b-b462-d4d5f426e04a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eriberto1@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "134cfda8-cd65-46a0-99d3-3a12e464c946", false, "Hilton" },
                    { "48", 0, "c6469347-1379-4b55-97ba-a333ffbf776d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest.Hamill@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "74d1b7f9-a840-4a5d-afd4-0fc0dc7e8b17", false, "Izabella" },
                    { "49", 0, "aa7e692d-806e-47e8-a632-752c687f6a96", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominique.Schaden76@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "dab62889-f7b8-4818-9b00-dbc9b74ca962", false, "Florencio" },
                    { "39", 0, "b7317145-dff7-4eb5-91f9-dd18fda3ea79", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unique_Wunsch70@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "b9a3d62b-ca89-43e9-b0e1-7da8b77661a4", false, "Callie" },
                    { "26", 0, "9c09206d-35e7-440a-b9c6-43534934ec86", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jarrell.Friesen97@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "a91bb49f-15ea-43cb-8532-214b85666bad", false, "Mark" },
                    { "50", 0, "a53473a8-7135-43c4-a01a-5666362198a2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dayna_Schmitt@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "435b4efb-7562-468d-88f3-f354ee45649b", false, "Dameon" },
                    { "24", 0, "496afc74-9312-405f-8fc8-17b04ac0931f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maci.Welch40@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "9bc19b24-4c02-4f0d-8b4e-8318eded42dc", false, "Florence" },
                    { "2", 0, "efc61784-ffa3-4a0e-83fc-4d8c8d3744e5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karson_Boyer@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "8da94644-fdb6-4d86-b12c-252412d4f2af", false, "Gisselle" },
                    { "3", 0, "8778856d-5156-4259-89d8-6134735ca3ee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melody_Rath@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "c1f99395-aa70-4a34-9cbf-43e90bf02d31", false, "Beaulah" },
                    { "4", 0, "6dcd4ac8-e629-4e7d-8088-cf397d4b4def", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaylan.Padberg32@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "4bbd4e20-d6c9-419b-9ed3-c01d96228672", false, "Armand" },
                    { "5", 0, "a624ff99-7d20-4b53-8f24-80fd82227642", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adan_Luettgen@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "d0b85467-7dfc-4673-bdf0-2f70683f254f", false, "Ari" },
                    { "6", 0, "6489f28b-2c73-48c0-90e8-699b10167c31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berenice.Bradtke41@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "bd0fe314-0cbf-48c2-99f4-a82bcd2c3bb2", false, "Tatum" },
                    { "7", 0, "5507e32f-222b-4c27-8513-91084fa4b098", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charity35@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "1abd022a-8adb-405a-ba05-d811b1bbe701", false, "Madeline" },
                    { "25", 0, "2fbd1d4d-fa73-4a56-aa41-dcef54e44513", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mittie.Erdman9@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "33051631-7307-4029-9a81-75a59599c440", false, "Pattie" },
                    { "9", 0, "4909db47-b387-4101-b709-d00184310cd0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clint43@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "dfa1cb8d-30f6-4826-987b-9fdc0621e86e", false, "Glenna" },
                    { "10", 0, "1a93ead6-dee2-4246-a4a3-167a20f81520", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dortha69@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "a3e2bc2b-e7e7-414a-bf1a-a8bd66e593c4", false, "Camryn" },
                    { "11", 0, "49d3a2b4-5b13-4ac4-8d5d-77fa65604ff9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harvey.Kertzmann@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "cc23872b-4301-4351-ae54-3ea15c5b874e", false, "Zachariah" },
                    { "12", 0, "892e6e5b-2996-419b-b112-b56c98eee18a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol90@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "64c75804-1aea-4bc4-a23a-6671b1753c28", false, "Lenora" },
                    { "8", 0, "382ec5cc-3156-4341-9605-e9bb99656fb9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maye44@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "283855f2-e4c3-42af-905c-771a4d9c590d", false, "Ariel" },
                    { "14", 0, "b617cdb3-2874-45f4-9350-27543b8ed123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wyatt40@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "d49a3f91-ac2e-4804-be3b-77553ef0b6f9", false, "Khalil" },
                    { "15", 0, "ffc22c5f-62db-4527-a030-a3783983f04d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floy.Ortiz@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "e9a7b35a-21a9-4c10-a29c-0fc3dd3244f4", false, "Betty" },
                    { "16", 0, "103620bc-6570-4266-9720-e5cbf1e1ab63", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dejon63@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "c4ddc737-98e7-4eca-9dec-5fd2dcfb92dc", false, "Terrance" },
                    { "17", 0, "091d214f-1297-46b8-912b-d27d4f48ad9c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucy.Fisher@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "e626b480-fb74-4c0c-b575-4eed9e534b37", false, "Sadye" },
                    { "18", 0, "6d6f093a-8fb0-45e5-ae2c-9dff3de2d8d7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chesley5@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "ba531d51-101e-4ef2-8bb8-97d5ad396bda", false, "Dave" },
                    { "19", 0, "ff69f23d-5a8d-401f-8cb0-feba53c3196c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisandro.Terry31@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "f2c17786-2b58-4d2e-975c-7c83f5e1ee18", false, "Quinton" },
                    { "20", 0, "7d38bf02-79a2-473d-af99-0a23041fd74f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry55@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "b4aaa005-ba48-41f4-9197-5f8413d25016", false, "Sherman" },
                    { "21", 0, "eeef2f7f-0e63-444a-99cb-9bc3c6f22aef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laisha_Gulgowski70@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "ac363160-22b4-4de4-8065-c540e5472b5b", false, "Trever" },
                    { "22", 0, "accfd65d-242a-428a-9828-2e844f4ed823", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachery.Hintz@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "8197a690-85a7-427b-a823-e3ed3f0f20ed", false, "Abe" },
                    { "23", 0, "003132ce-5ec7-4c09-8f6a-0bdd392e81a5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Courtney22@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "9177e591-fded-4256-b431-ece2131ebd28", false, "Kiara" },
                    { "13", 0, "50bf2395-59f4-41b2-b943-5edfe6603135", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anya62@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDFFfX9bi0MHwPv4j020hmd6jXY6mEymMjUxEaivHfLewtEWNXPocAwW6kcBWBRgTg==", null, false, "0883d584-43b6-4a9a-bba0-95379002c666", false, "Nayeli" }
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
                    { 3, "3", 1, "Delectus autem recusandae et repellendus sint quisquam veritatis.", new DateTime(2020, 2, 8, 15, 12, 50, 117, DateTimeKind.Local).AddTicks(6742), "Nulla et eveniet enim exercitationem temporibus id nihil consequatur molestiae.", null, "Et et tempore." },
                    { 19, "2", 3, "Necessitatibus at repellat libero sunt sint tempora.", new DateTime(2019, 8, 29, 9, 36, 6, 16, DateTimeKind.Local).AddTicks(2275), "Dolor quos officia quaerat omnis in.", null, "Dignissimos id deserunt aut assumenda." },
                    { 22, "1", 3, "Illum necessitatibus sit eius sapiente ducimus qui architecto blanditiis facilis.", new DateTime(2019, 11, 6, 14, 41, 48, 157, DateTimeKind.Local).AddTicks(5759), "Velit sed officia et itaque deserunt nemo illo.", null, "Ut dolor voluptas aspernatur occaecati sapiente culpa eum voluptatem." },
                    { 31, "3", 3, "Suscipit officiis ut natus et.", new DateTime(2020, 3, 9, 22, 39, 22, 766, DateTimeKind.Local).AddTicks(6055), "Eligendi in aliquam reiciendis placeat.", null, "Sed est rerum earum velit perspiciatis quidem aut quae vitae." },
                    { 33, "1", 3, "Nostrum delectus distinctio maiores ut.", new DateTime(2020, 3, 1, 21, 44, 0, 618, DateTimeKind.Local).AddTicks(8786), "Est ut repellat ipsa impedit.", null, "Quo dicta minus porro iure." },
                    { 39, "3", 3, "Ratione veniam aut natus consequuntur.", new DateTime(2019, 11, 13, 17, 28, 0, 96, DateTimeKind.Local).AddTicks(3650), "Fuga sed occaecati possimus sint ratione quasi saepe sed beatae.", null, "Consectetur ducimus consequatur est ut." },
                    { 46, "1", 3, "Nam cumque est similique ex iste et.", new DateTime(2019, 8, 31, 12, 10, 27, 153, DateTimeKind.Local).AddTicks(1345), "Aspernatur et tempore ut vel aut dolor tempora.", null, "Ut qui expedita sapiente qui alias sit eos omnis." },
                    { 47, "3", 3, "Dolorum earum et odio et non est similique maxime.", new DateTime(2019, 11, 12, 21, 7, 21, 29, DateTimeKind.Local).AddTicks(5633), "Ut facilis libero consectetur sit.", null, "Enim voluptas necessitatibus." },
                    { 50, "3", 3, "Quidem magnam qui voluptate vitae aut.", new DateTime(2019, 9, 5, 5, 47, 28, 290, DateTimeKind.Local).AddTicks(293), "Possimus adipisci omnis ut iure omnis et praesentium id.", null, "Quis nisi ducimus consequatur." },
                    { 5, "3", 4, "Commodi corporis rerum rem eveniet.", new DateTime(2019, 7, 13, 12, 37, 5, 517, DateTimeKind.Local).AddTicks(3242), "Nesciunt quia quia rerum aperiam veniam.", null, "Aut et sed omnis occaecati minus animi officiis sed corporis." },
                    { 8, "1", 4, "Sed aliquam qui minus neque.", new DateTime(2019, 4, 9, 4, 58, 22, 666, DateTimeKind.Local).AddTicks(2234), "Vel quisquam ut voluptas animi et qui non eum aut.", null, "Veniam qui incidunt ut fuga porro velit." },
                    { 23, "1", 4, "Sed sint ea voluptatibus perspiciatis quisquam sed nulla.", new DateTime(2019, 6, 1, 2, 27, 17, 579, DateTimeKind.Local).AddTicks(5446), "Iure reprehenderit qui.", null, "Non eligendi dicta voluptatem ullam." },
                    { 24, "2", 4, "Sit consequatur hic dolores nihil iusto provident sit dignissimos.", new DateTime(2020, 3, 20, 3, 24, 28, 213, DateTimeKind.Local).AddTicks(7371), "Consectetur expedita autem.", null, "Ea a debitis et autem necessitatibus quia id quod perferendis." },
                    { 26, "3", 4, "Ipsa est rerum ex modi repellat nesciunt quisquam.", new DateTime(2019, 8, 21, 5, 47, 47, 857, DateTimeKind.Local).AddTicks(9616), "Dolor sequi libero magnam.", null, "Adipisci maiores voluptatum eum earum et laborum eius commodi iure." },
                    { 30, "2", 4, "Officia non eveniet esse ipsum nemo et laudantium praesentium.", new DateTime(2020, 3, 11, 2, 29, 53, 461, DateTimeKind.Local).AddTicks(8471), "Quia nesciunt sint dolore dolor.", null, "Est nulla neque a suscipit omnis provident." },
                    { 36, "2", 4, "Sunt consequatur dolore.", new DateTime(2020, 2, 25, 14, 50, 38, 312, DateTimeKind.Local).AddTicks(3431), "Aliquid ratione aut quibusdam et perspiciatis labore aut.", null, "Maiores reiciendis id." },
                    { 48, "2", 4, "Recusandae dolorem dignissimos deserunt non impedit.", new DateTime(2020, 3, 19, 12, 24, 48, 844, DateTimeKind.Local).AddTicks(6763), "Corporis ea iure velit animi dolorem quod suscipit quaerat aperiam.", null, "Corrupti consequuntur dolorum." },
                    { 49, "3", 4, "Et ea voluptatem omnis neque aut maiores eveniet magnam.", new DateTime(2019, 8, 16, 0, 14, 23, 873, DateTimeKind.Local).AddTicks(2000), "Corporis veniam qui autem in voluptatem ut omnis commodi.", null, "Aut et esse voluptatem." },
                    { 12, "3", 5, "Maiores mollitia maiores.", new DateTime(2019, 6, 24, 12, 50, 56, 784, DateTimeKind.Local).AddTicks(3759), "Rem voluptatibus sit exercitationem.", null, "Fugiat neque provident minus deserunt quos." },
                    { 15, "3", 5, "Rerum sint dolores vel libero blanditiis.", new DateTime(2019, 5, 21, 7, 49, 6, 330, DateTimeKind.Local).AddTicks(7083), "Dolorum vitae est.", null, "Quae suscipit quis delectus perferendis praesentium hic mollitia." },
                    { 27, "1", 5, "Aperiam omnis sapiente eligendi consequuntur ratione voluptas atque.", new DateTime(2019, 8, 3, 7, 54, 15, 110, DateTimeKind.Local).AddTicks(2424), "Amet hic eaque excepturi dolores aut et.", null, "Eum ex et minus est delectus tempora tenetur perspiciatis." },
                    { 32, "3", 5, "Est ut magni natus.", new DateTime(2019, 7, 14, 13, 34, 20, 499, DateTimeKind.Local).AddTicks(7599), "Quidem sit impedit vel eius porro nihil.", null, "Nostrum ut ratione eum explicabo consequatur." },
                    { 18, "3", 3, "Inventore omnis ipsam mollitia sed incidunt praesentium.", new DateTime(2019, 12, 17, 12, 6, 31, 383, DateTimeKind.Local).AddTicks(9639), "Recusandae fugiat labore tempore molestias magni corrupti autem cumque.", null, "Est blanditiis fugit ipsa rem dolorem doloremque cum." },
                    { 14, "3", 3, "Quibusdam sunt dolores quo non autem.", new DateTime(2019, 12, 25, 7, 44, 16, 719, DateTimeKind.Local).AddTicks(6324), "Consequatur illum excepturi esse.", null, "Hic vel ipsa." },
                    { 7, "3", 3, "Praesentium aperiam praesentium ut quos.", new DateTime(2020, 2, 24, 11, 1, 35, 806, DateTimeKind.Local).AddTicks(7980), "Dolorem illo laudantium culpa sit.", null, "Alias voluptatem et et quidem animi voluptatum delectus adipisci." },
                    { 6, "1", 3, "Enim dolores voluptatem cumque.", new DateTime(2019, 8, 4, 11, 15, 58, 362, DateTimeKind.Local).AddTicks(3985), "Eos nihil est autem dolorem optio accusantium nemo.", null, "Omnis illum expedita est dolorem eum." },
                    { 10, "2", 1, "Odit ratione aut.", new DateTime(2019, 4, 15, 12, 53, 24, 554, DateTimeKind.Local).AddTicks(3869), "Et veniam eum dicta beatae reprehenderit laudantium eum nemo.", null, "Ipsam quasi quia omnis." },
                    { 11, "2", 1, "Neque quia esse sit perspiciatis unde minus sit doloremque.", new DateTime(2020, 2, 20, 3, 37, 57, 386, DateTimeKind.Local).AddTicks(4868), "Voluptate nobis possimus veniam sequi dolorem.", null, "Culpa magni vitae officiis id maiores vel aspernatur." },
                    { 13, "1", 1, "Aut sit sit nulla sed dolor iste hic.", new DateTime(2019, 7, 6, 3, 11, 30, 110, DateTimeKind.Local).AddTicks(9063), "Et dicta et impedit est et sequi accusantium est.", null, "Earum nisi facilis autem porro eius dolor doloremque qui eveniet." },
                    { 17, "2", 1, "Facilis porro aut.", new DateTime(2019, 7, 3, 12, 56, 28, 532, DateTimeKind.Local).AddTicks(4145), "Esse qui est labore laboriosam.", null, "Quos officiis nostrum sed veritatis vitae temporibus." },
                    { 20, "3", 1, "Aut voluptatem ullam velit optio nihil soluta ut temporibus est.", new DateTime(2019, 4, 9, 16, 20, 15, 0, DateTimeKind.Local).AddTicks(8746), "Incidunt facilis optio quod quo enim.", null, "Vero velit vero culpa consequatur perferendis cupiditate non ipsam sint." },
                    { 21, "3", 1, "Fugiat aut sint porro earum sunt laborum distinctio quo voluptatem.", new DateTime(2019, 5, 11, 13, 5, 11, 883, DateTimeKind.Local).AddTicks(8322), "Sunt minus incidunt voluptatem aut in fuga aliquid.", null, "Quo nobis fugit ea natus animi." },
                    { 25, "2", 1, "Molestiae numquam voluptas ipsum.", new DateTime(2019, 5, 22, 10, 12, 6, 460, DateTimeKind.Local).AddTicks(2121), "Est qui et ut quo voluptates.", null, "Cupiditate error vero quam itaque sit sit consequuntur." },
                    { 28, "3", 1, "Asperiores voluptatem quo eos ad modi necessitatibus.", new DateTime(2019, 6, 20, 9, 31, 10, 274, DateTimeKind.Local).AddTicks(2081), "Dignissimos ullam explicabo ut.", null, "Quia fugit esse repellendus iure aut occaecati deleniti qui." },
                    { 35, "1", 1, "Mollitia id et vel perferendis non non commodi dolorum ipsam.", new DateTime(2019, 5, 18, 3, 2, 23, 746, DateTimeKind.Local).AddTicks(4683), "Consequuntur asperiores nisi recusandae fugit unde amet corrupti.", null, "Pariatur est aut qui deserunt harum." },
                    { 37, "3", 1, "Fugiat fugiat laboriosam accusamus et aut quia.", new DateTime(2019, 9, 7, 18, 30, 2, 292, DateTimeKind.Local).AddTicks(7357), "Ad facere asperiores voluptas eveniet ex tenetur.", null, "Sunt omnis enim velit odio rerum adipisci sint." },
                    { 34, "3", 5, "Et non ad natus ipsum.", new DateTime(2019, 11, 16, 6, 44, 39, 211, DateTimeKind.Local).AddTicks(5304), "Necessitatibus earum reprehenderit quia eveniet labore vitae iusto ullam.", null, "Quis sequi et dolorem sed." },
                    { 43, "2", 1, "Explicabo eligendi totam earum rem quas voluptates fuga sit.", new DateTime(2019, 7, 3, 5, 39, 59, 861, DateTimeKind.Local).AddTicks(6603), "Enim rerum magni eos aperiam at at.", null, "Libero molestiae quasi sed soluta." },
                    { 45, "1", 1, "Dicta nisi at quia rem iste quas sed.", new DateTime(2019, 6, 13, 21, 56, 26, 140, DateTimeKind.Local).AddTicks(5079), "Totam illum aut aut.", null, "Quia velit ipsa aspernatur ipsam aspernatur quia." },
                    { 1, "1", 2, "Quo quos sint officia provident.", new DateTime(2020, 1, 4, 11, 53, 14, 317, DateTimeKind.Local).AddTicks(7330), "Officia voluptas dolor voluptate accusamus asperiores dignissimos consequatur.", null, "Iste excepturi nesciunt consequatur similique placeat." },
                    { 2, "2", 2, "Enim pariatur facere et nihil.", new DateTime(2019, 7, 10, 10, 5, 44, 363, DateTimeKind.Local).AddTicks(2791), "Molestiae quis ut natus.", null, "Ratione earum consequatur sapiente commodi iure voluptatum et." },
                    { 4, "1", 2, "Asperiores voluptatum dolorem voluptas laudantium et quia.", new DateTime(2019, 12, 24, 7, 5, 11, 882, DateTimeKind.Local).AddTicks(8058), "Est molestiae et sit enim.", null, "Dolor consequatur quibusdam harum laborum magnam molestiae necessitatibus." },
                    { 9, "2", 2, "Fuga quia est vero molestiae alias eos provident.", new DateTime(2019, 8, 14, 14, 42, 15, 506, DateTimeKind.Local).AddTicks(9687), "Tempora quos ex perferendis et optio similique.", null, "Ut aliquid saepe." },
                    { 16, "2", 2, "Quam modi rem quibusdam vel ratione beatae magnam.", new DateTime(2020, 1, 23, 9, 59, 54, 361, DateTimeKind.Local).AddTicks(2571), "Et minima alias alias omnis voluptates voluptas nam nulla doloremque.", null, "Sed dolor possimus quae magni." },
                    { 29, "3", 2, "Aliquam quia consequuntur ea sit minima nulla.", new DateTime(2019, 12, 11, 2, 47, 6, 412, DateTimeKind.Local).AddTicks(9456), "Accusantium consequuntur temporibus exercitationem architecto.", null, "Tempora quisquam saepe et." },
                    { 40, "2", 2, "Dolor id consectetur adipisci reiciendis magni qui eveniet.", new DateTime(2020, 2, 18, 17, 24, 9, 543, DateTimeKind.Local).AddTicks(8109), "Quidem recusandae libero nihil debitis possimus labore.", null, "Provident voluptas iste recusandae cumque." },
                    { 41, "3", 2, "Optio velit laborum voluptates.", new DateTime(2019, 8, 28, 5, 55, 55, 286, DateTimeKind.Local).AddTicks(9151), "Qui ullam reiciendis qui illo non molestias dolores.", null, "Consequuntur harum quo et inventore et dolore." },
                    { 42, "3", 2, "Molestias omnis incidunt atque possimus est.", new DateTime(2020, 2, 13, 20, 58, 11, 653, DateTimeKind.Local).AddTicks(4985), "Modi animi consequatur.", null, "Velit in reprehenderit eum quidem sed quis fugit fugit praesentium." },
                    { 44, "2", 1, "Quas voluptate et optio velit iure.", new DateTime(2020, 3, 11, 11, 52, 48, 724, DateTimeKind.Local).AddTicks(7783), "Excepturi delectus est eius voluptates iusto recusandae optio laboriosam.", null, "Voluptas quasi quia inventore aliquid." },
                    { 38, "1", 5, "Cupiditate autem dolore ut consectetur.", new DateTime(2019, 7, 10, 12, 50, 14, 942, DateTimeKind.Local).AddTicks(830), "Non libero voluptate enim impedit hic dolores.", null, "Repellat autem quia vero officiis nobis." }
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
