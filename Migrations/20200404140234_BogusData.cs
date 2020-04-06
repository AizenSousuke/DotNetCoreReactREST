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
                    { "1", 0, "7da5865d-256b-4904-8708-76a14c78bca3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert.Johns@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEA0F4IWrJGZTsxzZIWUU00CtMetoNVElm9y0YZlsIRq8NlxeryqFPYPjAmnYD0u+dA==", null, false, "e41b388e-27f6-4be5-981d-a70dcedd0213", false, "Albert" },
                    { "28", 0, "fa04a245-fef0-4784-bd55-455315c19bd3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Derek.Ullrich@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAED8ey2jUK2eXRWET8/BBIH6UVGb6tQT+IOSzU4YHruh1iTUZ2lCK8Kyqz5uS4s68PA==", null, false, "b6483817-0d6d-4a7e-87be-9576eeff17f7", false, "Derek" },
                    { "29", 0, "7dbd5280-1bbc-49c4-b976-07fb0e4933e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iris.Heaney@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAENk2UJTbMX0LaoalsuV1DOjl5+vJdi2i5TLIvgCS+GAb0BRCCmRj9yVC7GbzvZ1ZAg==", null, false, "cd6dacbb-ff67-4aee-a7b5-fb86842404bc", false, "Iris" },
                    { "30", 0, "23d6e449-afb8-4e22-afbc-b01c9ccd6f6c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheri68@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEFcGY8jEpaRjbyPTEsHc2RscoueOXrNT3R1vKg6/uZtpejDAwb6F0HI9ymAprCVvMQ==", null, false, "1135c2b2-dc9a-4fc1-8f60-eee99daf8e4c", false, "Sheri" },
                    { "31", 0, "d10391cf-fef4-4461-9c00-a03e33dd1108", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven.Olson@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDAv7mRvNa3eq/f4iwZt0EW2H/2iuWWXo6HoweKcVo4qgwh8xL4cX/dO/v5rjFy6gQ==", null, false, "caf95f3c-0b77-412a-b779-6234ea28c5d4", false, "Steven" },
                    { "32", 0, "54126c5b-d77f-487e-b766-420a082ec9bc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doyle_Donnelly@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEJAfnhiLUWkacFOkZ+/Hv/R6imxjkCzyqFfVrrPRp7lly69ZLLmiOTskxC0m0T4S0A==", null, false, "e617a64f-51ba-414d-a124-c284a96a13e6", false, "Doyle" },
                    { "33", 0, "fa670fc6-641c-47d7-a08a-b78b4d598c66", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyle.Schroeder@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEASh2fDUyIxks6Kk+mVknzEmYQX4TI43ogeOHtL1C8Wf4mti2eLNo0SPqxIIMzPUPQ==", null, false, "a17e3621-b369-42f1-8f1f-befc1b9ceb0c", false, "Kyle" },
                    { "34", 0, "b0e6ed15-0306-4207-a336-360ba5e36553", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timothy_Gutmann@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEg2s6jyyTTAlPfDpp8OarKAQXfAP/J6YDAjSjgy2X3LPymkaU4eXt6FOn8sGAg1/w==", null, false, "cb9af797-92ab-43b6-a1cb-c263c8bfe99f", false, "Timothy" },
                    { "35", 0, "edca326c-c4a5-40ad-bb7b-551415a9c81f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santiago_Abshire72@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGN5ua4lntEwS1inREUs0LPxqkVgtbEypVuaoGpwbYYkogfYTGpG/9OYpQe6wOqLqw==", null, false, "dac68f24-932c-47a1-baf6-55fe02516922", false, "Santiago" },
                    { "36", 0, "b7893603-4384-4fcd-851a-9392f842d70f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freddie_Bruen39@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEHU1xk3WqLl01pQd3pOWwTpH14VIqf6WPv1rpjwUIViOxeDg0m8U+VgVmq0ReIo89Q==", null, false, "ef860556-0740-4068-97a5-ea3430c9b678", false, "Freddie" },
                    { "37", 0, "432f17d5-c66a-4cc6-bde0-9498372c7c9b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cecelia.Ward66@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEAF4hYwx+xu+D8ZexTvIJlgORgxV0qwMbPgmKTVqez7imml0tt6DuG4Ptl3PZC/LCA==", null, false, "2f1995a4-057b-4a57-aebd-bf19978dac06", false, "Cecelia" },
                    { "27", 0, "cb7e2b81-fe16-4739-8f01-2a69eacf126c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roland31@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEAX7/TQXiVHkHqLCRqfnXlO4JbHeOEe72oNdK8rnIAQwGygrSBbtJRz+VzppbUmBKA==", null, false, "495214d4-8a1c-489a-a05d-5bea812e3b0c", false, "Roland" },
                    { "38", 0, "85717192-b8bd-4a77-aafa-fa11b895e788", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ella.Strosin@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEBxPl6/aClvJLZIz6Fp1lg8OwZhHk0nypWaqPJSjRS1dXTrSR0OyEeF9LsaU3WL0uA==", null, false, "61a1bd86-7af3-4fe3-a604-d1eabcffff3b", false, "Ella" },
                    { "40", 0, "39cadece-a814-4f53-9fc0-6072d318edec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mack.Gibson@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEFp2yXBRgH9+leexl/d90Bio/M54sqdFICs5ulMpGqRIs1TBIxKvc1b6GR+Hy2SnFg==", null, false, "60df1302-0c07-4b88-8c46-b531aacb03e2", false, "Mack" },
                    { "41", 0, "d7522bff-2266-4313-ba1f-5e8bd680a91d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel45@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEJz6iGeEigDTAmyl/EAS77cM8yXiQd5wnxGpK2+SfSMxFAqBoNJVBM4vtNq7iBzC1w==", null, false, "9d0ba066-2407-4563-88cb-58d109d5b8e6", false, "Gabriel" },
                    { "42", 0, "066a2e99-bb43-4b98-9c71-a384050a0827", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olga45@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEBuLMyKaZpM9GHvuyalNai3WJjQiwdh2RcGRve9bkTp4gnznD3DuRac0bJFSnFWyQQ==", null, false, "2e7a92ed-42ec-4888-9ff4-de2d23b6011b", false, "Olga" },
                    { "43", 0, "fdfe5242-f8a6-4be4-8d4e-0c30d3d78b85", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter_Kuhlman@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEexYJL8kx+FNOhZIK+q/x2bBHY8AnVVqJmSQEfmy4c1S5se6n9UREVJNeQJSIHP5A==", null, false, "105c33db-85f1-4bdf-8615-952f701740b1", false, "Walter" },
                    { "44", 0, "a579dd8b-c085-4bf6-82a7-fcc294465776", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elsie_Keebler35@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEF3cmMSxNkW9hTjvfffWNtWsLODW2buduS7UR98yVXs2xUrLhHUFkFwTDLGp1Dvj1w==", null, false, "1e09d152-416b-45ba-a0ab-def550077d06", false, "Elsie" },
                    { "45", 0, "a62cbf40-10da-4258-a5ae-9bd9e49e99f0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfred_Bartoletti72@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEAACAFZewW2S/uHzqyjUSOFHIdTtA3szjTFq9CbOU9McwJH7bM6PQr27CoR8X3odwA==", null, false, "0b2d44b3-7c15-4fb4-97e2-e03b44eaef3d", false, "Alfred" },
                    { "46", 0, "ee68f535-df2c-480f-9929-59419a4e5021", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnnie.Volkman25@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEFHSXdz7Sa1UqkLE2QCMY5ssU6rjNeDw1dQGf//6JPSI+/penTShkdxjXiW1n1ASOQ==", null, false, "fc288366-b759-4688-b28d-1a85a12a7916", false, "Johnnie" },
                    { "47", 0, "1a30d111-c8e9-403b-96eb-af3a75623617", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgil.Gislason@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEO+4pUdl5MhSUetDJ/mR9kb4wx3xvL648A7Mi7oW3ECe+mjfyEruT5KR8lR7mVPFrQ==", null, false, "dde84260-06d6-4fb8-951f-a0ab8302d922", false, "Virgil" },
                    { "48", 0, "555f5b6f-8a75-48e7-9a07-e5ffb47256eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geoffrey.Stracke83@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAECz7qO7rqwD76rJ9Nlt3P/gQ9+vzIe4ciMLOGwOYz1ko4IJNy/pBU3RgaDEG5qUlZw==", null, false, "233b199e-0246-4b55-bf6f-f1df349e9e9c", false, "Geoffrey" },
                    { "49", 0, "403fd060-7119-4d68-bf9e-71d65c5a446c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muriel_Upton@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGblhKXxvXdF8aYdPIidKA5oFbe4Uq50QNmiZtHe7iPGFYpX+yL+mlnUL5BBflqHxw==", null, false, "d7fc1ed2-1fd0-44eb-80a5-d58fb9d9854a", false, "Muriel" },
                    { "39", 0, "668dab43-ff56-495b-a96a-2e8471fa9454", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeanette.Mills78@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEFhH+m5B3LVa3wWXDvxxyXaJUIhSbGv7bowoppEOk0OqH2ONcdEiGQFU/eZn5HgC0g==", null, false, "7004e630-9cc5-425c-95ca-11580e554ced", false, "Jeanette" },
                    { "26", 0, "819dbfb0-2875-4474-8afe-1880947560a8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramon60@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEN99VtXpf1dFYGQBW1Lhz3NHON69twjtVbTnikG3WkhCmUl21eqnOfmFQxBc8FuhA==", null, false, "94dad4dd-c9a7-46bf-8d28-927eb6f34f38", false, "Ramon" },
                    { "50", 0, "8e9233b0-3124-4f68-b2e7-08f096ef9e7f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guadalupe96@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEFQmHL0ag2wXgR1B9nKZlwT5hu98eJcF0Ms0iyYNYLIvqaFgmslaZpffUIlNowdpnA==", null, false, "da754c65-0749-4af3-bc03-4f6e61e2a3fa", false, "Guadalupe" },
                    { "24", 0, "26cba659-1e32-40af-bbdd-101882287d70", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randall44@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEyMEhgGZ0ynPHh0S56O0VIGnZ7gYdbGQFEiQsNjzEY733PXT1TZ1jgFPIX/SLMVNg==", null, false, "7c139d15-9488-4f66-a919-873334178343", false, "Randall" },
                    { "2", 0, "a902823e-4be5-411f-9b98-165a9c35387f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joel77@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDdt4hj8z6CosALOZaJ9SjYDWy5kTNXUa8E5GHtNJ3TN5hJZXujHaqrf9SNtSEN4JA==", null, false, "aa75cec8-59fe-471e-aa41-61c2c95fb2ce", false, "Joel" },
                    { "3", 0, "245aa322-6258-40d7-a360-53cdbddad23d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flora_Boyle@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGLtBcrrmU0072umxgSFYiHPDYVRbWoY4bfdHu7CorAEMqx0lvOAG6yLIw3SVb3+sA==", null, false, "4380fc3b-8f6c-4d23-9fee-a7c9c67ab9b3", false, "Flora" },
                    { "4", 0, "c4be53ef-929d-40ea-abc4-73073ad0052f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doreen_Waters@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEHhCeQZY5zVCMqZ3ls8j4pcs5igUlYM4L+dCMxKFcs2VDJji64S3dGID+kkGvGX9jw==", null, false, "16456caf-53a9-4789-8ea0-911d2d00389b", false, "Doreen" },
                    { "5", 0, "62d5ca54-71ae-4af8-bcb3-19d3948c0c0a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hector_Halvorson91@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEBNAKCJhY1t9dFP5YH0b0lURjpyOvx3wBr+q+0V/CTXNMtljwR/78xBTMgxPTSrTfQ==", null, false, "1af6e6c8-0874-4e5f-911a-00116c65fff2", false, "Hector" },
                    { "6", 0, "6f222fa6-341b-43ca-ba41-a160e63c3aa1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby_Will@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEFPTjI709BZKzVv5aQ9GEabmsvSMIUhj24ZKHx7vMw0Z+HjlzS3ApxwwDbjuZhuVSA==", null, false, "6ac0a385-7d6e-4c58-b18a-d2e315effc70", false, "Ruby" },
                    { "7", 0, "47f919ed-870a-408e-8ff5-09d28fc98fa9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lonnie.Bernier9@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAENG1doxzAp19RSQ0EBhumdTmmDf7tNUixmBur4RN3WkOYIGL4+kxVbviJtBk3f50hQ==", null, false, "02cbf303-44e5-4198-b11a-00f2483f2bcf", false, "Lonnie" },
                    { "25", 0, "b4b47d09-28f1-424c-9609-72b3b4c2c5e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lillian56@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAECmeDM5OO8tW2okGZamhH2f4s5ffoCPBdYJRgFnYfsu3Bx5mMbMDCDJikNZftW94Ig==", null, false, "1d1f851f-8ff6-43b6-a897-76475496dae8", false, "Lillian" },
                    { "9", 0, "b9539a2c-3177-44f6-8b80-444c20d6cac9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristina_Stroman@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEBYAQnOK07Cgr/YE9eUFm4SB8ZC+vYk/5kXmH9IppBDfR2xq/kjF2xn9SVFRwg1YDA==", null, false, "1212ef2e-2b6a-4015-9ffa-c298a4e06226", false, "Cristina" },
                    { "10", 0, "d814e571-0e67-46e7-b516-1f72f7563bdc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marion_Bartell@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEFcM7c7I9ElGu4oszcf8w37hYdVrwIcYkFE6AFaUCqw/5mcc0UV/Z35P4G/LUHB32w==", null, false, "3ff85642-1c25-4760-8779-091c24279e11", false, "Marion" },
                    { "11", 0, "3e40d253-0966-458d-89f3-f9dbc67640c5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vicky42@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEC9y/73T3MR9Mg7p5ZDhngT/mW4ZX5dR9TkzBDwvCNdqdOEwjDNiNjzm85SzQ9KLkw==", null, false, "60f6d33b-3f5f-4927-9bd4-f112e9d89d5f", false, "Vicky" },
                    { "12", 0, "7b1961b4-59ac-4f47-a322-fffbb08f1afc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margaret17@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEJHKDdEoPAOAfbSuYL7ZWo5hux0CtCkALzOryddtVYlD6l8yifa8lheG6Aj+h58o0w==", null, false, "495c69cd-96c9-440e-8180-76f462ca0101", false, "Margaret" },
                    { "8", 0, "45d923bc-4b71-4e30-8d4b-385189156c5a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan.Oberbrunner6@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEHzYbLLzMklO3Yntqwj4YRzR+gsS+onMw38WI1ptYbMsus6hv5GGJBsJMvKwBI9gxg==", null, false, "fff71363-df05-450b-a527-db1a870a6c93", false, "Nathan" },
                    { "14", 0, "d6deda3d-a82e-426a-b147-b107daf13c81", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robin_Corkery13@gmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEI+6eaxGlfG2Hv7UuqWRdD5W/PiMKTL/mI8PT94G1+7jRtYOB7Mz8u/lVpLVrN2kww==", null, false, "b3a2900b-d0ad-4544-822c-f5cfade8d0ec", false, "Robin" },
                    { "15", 0, "ad1e9d8e-1361-472f-81c3-77336aabe287", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alton2@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEBe54jjpUavZYyO/ZEFqq7qoMkTA680lVNVtuQu6zBoz/qOY2R2ZgxUo0Z+zhv2PaA==", null, false, "081090e5-23b3-4a79-83e4-4ce4f5972b08", false, "Alton" },
                    { "16", 0, "9172d3b1-ac11-4494-bd02-92c6dd855255", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberta.OReilly73@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEHJ+T4muGM09dMSdmYvpHIJiWTX6AqYEFNrap3/qfoCkt657Ou/cp0w8fyZg0wb70w==", null, false, "c3380012-6ffb-4606-bd14-6ad8f4796299", false, "Alberta" },
                    { "17", 0, "89da6a71-e713-44fc-822b-f1e831796043", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodney49@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEDwZbouTqQkHsH0VZeMKwwbakSNh0xp1BgDIgpjiaaBdEXjNpIgipkoPns2lqq2axw==", null, false, "28061a40-44fd-4061-8ab0-0a0fea5cbd75", false, "Rodney" },
                    { "18", 0, "fa1518a6-b0da-4b49-8dbc-a25c75393e96", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte_Schneider94@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEKNt+k9/ByzO6Z5CS0xlUh/6a732M/xU1He+FGxABPW2at5O5mrdCx4RVpriN+HAgw==", null, false, "933acdcd-19e8-4979-98af-00b77391bd37", false, "Charlotte" },
                    { "19", 0, "20880145-d7e3-456d-ac3e-806168dd7ebe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margarita.Thiel@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEHAFVI5CRoVHUCgC4syGLOYkBef+idUJD7oZ6Q3r31M/nkHmiT3F1k5zk2Yn3POl4A==", null, false, "934e736e-ba56-4a98-a0d4-b337d1c66bbd", false, "Margarita" },
                    { "20", 0, "5cf7d8bc-4a14-4636-8c7f-346998ed068b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joan.Fadel72@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEP1lWmrfMrXuqq3Ih3ZQeflCDie3orAn30yB7RVohsePn7jZX/LY7L923WZImVonVA==", null, false, "78f7264a-4443-4785-9cdc-88699c9d8aaf", false, "Joan" },
                    { "21", 0, "3e636269-75a7-417c-976a-675edce5a8fa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krystal2@hotmail.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEGD7eb2Y5wDlbJ/pp5D4tfWu8ioPUEhuhQ6VLxjEGNg70mNOGiOEVNQBzojR5+devQ==", null, false, "1342f9e7-ba1f-4b3d-992a-82864db5c1a9", false, "Krystal" },
                    { "22", 0, "e80f8b41-4499-4118-8814-17dfec68214f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson.Macejkovic@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEKa8sY2/Cn23kBW7XzFgc/vNW8uCAHwuQAub4UU3yg672sVP//bcVan/f50mnUjZNA==", null, false, "9e163a79-e754-45e2-aa9a-824a3529a0d5", false, "Wilson" },
                    { "23", 0, "09f774a4-9e9b-41f5-9164-ae0723690a68", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelley_Gulgowski@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEEJhL+7LsNkFTJUYCOUrMnep493/eikZtA7VbZB/NHOUig7lxolKt2RkKbpZ7deRVQ==", null, false, "1b3cf98d-385e-4920-a1a6-2608e6e51f9b", false, "Kelley" },
                    { "13", 0, "9ba12c51-1ac6-4c91-9ceb-c75bc23e2b31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carol62@yahoo.com", false, false, false, null, null, null, "AQAAAAEAACcQAAAAEJVew1va33jU9ovmq0TOY6md4wP/WfTqavgrYfUIPoaUgBG/UIQYaFnJ9/upZUi2hA==", null, false, "8e5a1d38-205e-4aa1-b921-081457e61eca", false, "Carol" }
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
                    { 5, "2", 1, "Consequatur non maxime ea earum.", new DateTime(2019, 7, 19, 2, 39, 39, 435, DateTimeKind.Local).AddTicks(7671), "Iure fuga est sed eaque.", null, "Est rerum deserunt eum et dolorem occaecati." },
                    { 13, "2", 3, "Consequatur laborum eos et ut velit.", new DateTime(2019, 12, 3, 18, 52, 1, 165, DateTimeKind.Local).AddTicks(5753), "Quia ut eum quis assumenda veritatis hic quibusdam praesentium.", null, "Odit et rerum et laboriosam et." },
                    { 17, "1", 3, "Ut quo rerum.", new DateTime(2019, 11, 28, 5, 39, 16, 6, DateTimeKind.Local).AddTicks(424), "Voluptas corrupti et et doloribus vel at.", null, "Dignissimos sunt nulla itaque quae temporibus rerum voluptas dignissimos facilis." },
                    { 25, "1", 3, "Earum ut consectetur eligendi rerum porro.", new DateTime(2019, 10, 18, 19, 56, 24, 300, DateTimeKind.Local).AddTicks(7194), "Doloribus reprehenderit quo nesciunt cum veritatis.", null, "Aut non ea quibusdam vel soluta magnam voluptatum quisquam." },
                    { 32, "1", 3, "Quisquam unde consequuntur laboriosam.", new DateTime(2020, 3, 10, 9, 29, 34, 918, DateTimeKind.Local).AddTicks(7480), "Non vero perferendis ea voluptas numquam.", null, "Eos pariatur voluptate aut odio harum." },
                    { 40, "1", 3, "Saepe et facere et et et suscipit sequi.", new DateTime(2019, 9, 16, 20, 22, 21, 961, DateTimeKind.Local).AddTicks(7454), "Explicabo voluptatem non.", null, "Rerum rerum a tempore est aperiam quo." },
                    { 41, "1", 3, "Ea cum placeat voluptatem est repellat quia officiis praesentium voluptatem.", new DateTime(2019, 4, 17, 22, 25, 32, 177, DateTimeKind.Local).AddTicks(8813), "Praesentium qui illum ex quia nihil perspiciatis totam omnis nobis.", null, "Voluptate debitis consequatur dolore minima nam suscipit." },
                    { 2, "1", 4, "Adipisci fugit deleniti dolorem.", new DateTime(2020, 3, 17, 17, 32, 59, 784, DateTimeKind.Local).AddTicks(6567), "Sed sunt molestiae asperiores autem fuga et eveniet quia saepe.", null, "Id dolorem aperiam itaque tempore qui asperiores aperiam repellendus." },
                    { 14, "3", 4, "Exercitationem non maiores explicabo ut eos ut alias.", new DateTime(2019, 5, 5, 17, 48, 32, 851, DateTimeKind.Local).AddTicks(2552), "Minima voluptatem eius quia.", null, "Aut eaque fugiat quaerat recusandae nihil vel minima consequatur." },
                    { 18, "2", 4, "Et praesentium nemo corporis qui mollitia impedit.", new DateTime(2020, 1, 25, 9, 34, 27, 799, DateTimeKind.Local).AddTicks(9676), "Et aut possimus est omnis ut.", null, "Odit dolor excepturi qui ut." },
                    { 20, "1", 4, "Illo ut eos facilis adipisci hic quos fugiat.", new DateTime(2019, 5, 3, 6, 7, 33, 830, DateTimeKind.Local).AddTicks(7408), "Ea culpa ut amet quibusdam dolorem sed nostrum doloribus.", null, "Iusto perspiciatis et numquam." },
                    { 28, "1", 4, "Nulla distinctio est sit ut quisquam sit eaque ut repudiandae.", new DateTime(2019, 9, 19, 3, 48, 13, 444, DateTimeKind.Local).AddTicks(7302), "Velit asperiores distinctio assumenda.", null, "Magnam recusandae aut veritatis rerum nihil." },
                    { 34, "3", 4, "Consequuntur veniam ut aut occaecati vitae magni totam maxime.", new DateTime(2020, 1, 21, 12, 37, 37, 277, DateTimeKind.Local).AddTicks(1693), "Doloribus ex voluptas architecto vel minus et.", null, "Non reiciendis consequatur." },
                    { 36, "1", 4, "Est totam tenetur incidunt eius nobis quidem officiis officiis.", new DateTime(2019, 10, 22, 0, 35, 12, 258, DateTimeKind.Local).AddTicks(4782), "Omnis et ut consequatur.", null, "Distinctio rerum doloribus harum." },
                    { 39, "3", 4, "Non facere quidem quis.", new DateTime(2019, 12, 30, 12, 47, 14, 546, DateTimeKind.Local).AddTicks(6564), "Omnis rerum laudantium.", null, "Explicabo consectetur et et quibusdam." },
                    { 46, "2", 4, "Neque ipsum rerum dolor commodi et nihil commodi recusandae.", new DateTime(2020, 1, 3, 6, 34, 13, 247, DateTimeKind.Local).AddTicks(613), "Cumque repellendus quidem ut repudiandae.", null, "Beatae minus recusandae veritatis ducimus corrupti." },
                    { 49, "2", 4, "Corporis suscipit exercitationem placeat vitae ab.", new DateTime(2019, 10, 28, 5, 21, 17, 234, DateTimeKind.Local).AddTicks(8925), "Corporis quis quidem itaque mollitia fugit expedita.", null, "Harum eaque perferendis reprehenderit." },
                    { 16, "1", 5, "Aspernatur consectetur rem soluta consequatur qui sint molestias.", new DateTime(2019, 7, 23, 4, 53, 51, 485, DateTimeKind.Local).AddTicks(9494), "Et officia voluptate quidem.", null, "Dolor accusantium ut id beatae nam quo velit dolor in." },
                    { 19, "2", 5, "Vel quae quod fugit.", new DateTime(2020, 2, 15, 10, 8, 29, 277, DateTimeKind.Local).AddTicks(7369), "Et nobis nobis.", null, "Eligendi pariatur culpa assumenda labore natus quod." },
                    { 26, "2", 5, "Sed corporis maiores.", new DateTime(2019, 7, 13, 4, 45, 30, 156, DateTimeKind.Local).AddTicks(1487), "A sit vel rem.", null, "Nostrum eum eos alias voluptatum officia." },
                    { 30, "3", 5, "Eligendi quae ut vel veniam deserunt.", new DateTime(2020, 3, 19, 22, 24, 26, 842, DateTimeKind.Local).AddTicks(9253), "Dolore beatae facilis neque cupiditate suscipit.", null, "Aut veniam fugit iusto ipsum." },
                    { 33, "2", 5, "Excepturi perferendis corporis earum repellendus sapiente voluptatem.", new DateTime(2019, 12, 31, 18, 52, 15, 104, DateTimeKind.Local).AddTicks(1953), "Ut laboriosam non enim exercitationem rem quae.", null, "Sed est enim enim aliquid." },
                    { 12, "1", 3, "Fugiat voluptates ad eos velit vel optio laudantium ullam.", new DateTime(2020, 3, 2, 16, 38, 3, 857, DateTimeKind.Local).AddTicks(717), "Omnis beatae expedita officiis et.", null, "Culpa et magni aliquid qui dicta voluptatem iure." },
                    { 4, "3", 3, "Quia aspernatur aut sunt minus et ut sint quas beatae.", new DateTime(2019, 5, 7, 7, 27, 51, 109, DateTimeKind.Local).AddTicks(654), "Sapiente velit quasi saepe molestiae temporibus dignissimos dicta quia.", null, "Fugit dolorum rem omnis est error et." },
                    { 1, "1", 3, "Omnis quam numquam.", new DateTime(2020, 3, 4, 10, 1, 32, 729, DateTimeKind.Local).AddTicks(2986), "Expedita voluptates tempore qui maxime.", null, "Est consequuntur voluptates porro." },
                    { 47, "2", 2, "Vel architecto aut aut.", new DateTime(2019, 8, 23, 12, 1, 6, 125, DateTimeKind.Local).AddTicks(4132), "Occaecati ducimus vel fugiat nisi aut dolores accusamus dolores ullam.", null, "Ea ut cumque quasi fugit sapiente." },
                    { 6, "2", 1, "Quo eum voluptatem.", new DateTime(2019, 8, 24, 2, 41, 31, 190, DateTimeKind.Local).AddTicks(6338), "Rerum id natus quia repellendus adipisci laborum totam consequatur qui.", null, "Voluptatem necessitatibus incidunt quis non veritatis unde." },
                    { 9, "2", 1, "Saepe odit praesentium aut.", new DateTime(2019, 6, 13, 11, 29, 35, 845, DateTimeKind.Local).AddTicks(8558), "Et possimus fuga nemo hic quibusdam ut.", null, "Voluptatem non accusamus nam ea." },
                    { 11, "1", 1, "Aspernatur id aut.", new DateTime(2019, 8, 25, 12, 30, 20, 24, DateTimeKind.Local).AddTicks(7436), "Vero voluptas suscipit quasi ut laudantium nam corrupti.", null, "Unde corporis vel fuga libero minus." },
                    { 15, "3", 1, "Reprehenderit sit molestias est tempore ut harum ducimus.", new DateTime(2019, 4, 14, 18, 24, 37, 471, DateTimeKind.Local).AddTicks(8740), "Vitae nihil quia aliquid ut magnam tempore molestiae quia odit.", null, "Quia sed nihil corporis beatae ut qui." },
                    { 21, "1", 1, "Voluptatibus quo officiis harum occaecati atque officiis dolorem nisi.", new DateTime(2019, 7, 28, 11, 2, 10, 943, DateTimeKind.Local).AddTicks(9677), "Dicta voluptatem id commodi delectus.", null, "Quaerat impedit deleniti sunt officia possimus." },
                    { 29, "1", 1, "Aut ratione voluptatibus dignissimos.", new DateTime(2019, 6, 29, 4, 57, 22, 541, DateTimeKind.Local).AddTicks(2833), "Iure hic voluptatum.", null, "Saepe accusamus qui hic ea." },
                    { 35, "1", 1, "Molestiae omnis earum repudiandae delectus qui ut.", new DateTime(2019, 5, 23, 13, 55, 56, 26, DateTimeKind.Local).AddTicks(2264), "Quia vero molestiae laboriosam ullam eos.", null, "Aperiam consequuntur aut." },
                    { 38, "3", 1, "Mollitia ducimus culpa.", new DateTime(2020, 3, 1, 5, 5, 32, 247, DateTimeKind.Local).AddTicks(879), "Ut occaecati qui dignissimos officiis aperiam suscipit repellat sint.", null, "Exercitationem maiores nobis placeat quo mollitia asperiores quo." },
                    { 45, "2", 1, "Dicta at est maiores minus voluptatem temporibus rerum voluptates.", new DateTime(2019, 5, 17, 22, 46, 55, 258, DateTimeKind.Local).AddTicks(2232), "Tempore non voluptates cupiditate perspiciatis assumenda voluptate omnis dolorum quia.", null, "Nam eligendi facilis reiciendis." },
                    { 48, "1", 1, "Cupiditate nemo aperiam sit porro ea ab iusto.", new DateTime(2019, 12, 31, 7, 46, 21, 845, DateTimeKind.Local).AddTicks(890), "Dicta iusto alias.", null, "Nulla modi accusantium qui deleniti ut mollitia." },
                    { 37, "1", 5, "Tempora ea perspiciatis soluta quis quo.", new DateTime(2020, 3, 24, 14, 34, 17, 204, DateTimeKind.Local).AddTicks(8268), "Ut quaerat quia necessitatibus vero.", null, "Perspiciatis omnis qui numquam et." },
                    { 50, "2", 1, "Cupiditate sed voluptatum repellendus ratione commodi.", new DateTime(2019, 6, 25, 19, 6, 9, 124, DateTimeKind.Local).AddTicks(723), "Libero quibusdam molestias.", null, "Architecto ipsa omnis eum aliquam perferendis eligendi quaerat." },
                    { 7, "3", 2, "Dolorem sint deleniti nesciunt qui minus dolores necessitatibus.", new DateTime(2019, 4, 28, 14, 52, 36, 96, DateTimeKind.Local).AddTicks(1691), "Molestiae neque explicabo sunt earum iure aut nemo et quo.", null, "Sunt suscipit omnis quasi." },
                    { 8, "1", 2, "Officiis optio dolores aspernatur est dolorem natus voluptas velit.", new DateTime(2019, 8, 6, 6, 30, 44, 128, DateTimeKind.Local).AddTicks(9810), "Magni sapiente eligendi fuga tempore vitae consequuntur dicta.", null, "Neque cumque ad accusantium corporis et corrupti numquam eum officiis." },
                    { 10, "1", 2, "Voluptatem assumenda optio omnis possimus consequatur quisquam unde.", new DateTime(2019, 5, 31, 21, 22, 39, 328, DateTimeKind.Local).AddTicks(2332), "Deleniti quas facilis perferendis quisquam.", null, "Totam quia dolor." },
                    { 22, "1", 2, "Consequatur non aut et sed ea harum nihil libero repudiandae.", new DateTime(2020, 3, 28, 2, 21, 36, 526, DateTimeKind.Local).AddTicks(6189), "Modi in ducimus sit ut omnis qui sed.", null, "Tenetur ut rerum impedit quia aspernatur quas voluptates quia consectetur." },
                    { 23, "1", 2, "Soluta vel voluptatem maxime.", new DateTime(2020, 2, 7, 4, 11, 6, 83, DateTimeKind.Local).AddTicks(1103), "Est dolorem velit earum eaque at et autem.", null, "Et alias eos odio minima voluptatem praesentium et." },
                    { 24, "2", 2, "Mollitia sunt maxime quia repellendus qui.", new DateTime(2019, 5, 3, 10, 19, 11, 797, DateTimeKind.Local).AddTicks(4128), "Fugit ipsum enim odio rerum omnis laudantium ducimus autem.", null, "Laudantium beatae labore velit ipsum ducimus molestiae hic facilis sit." },
                    { 27, "2", 2, "Numquam eveniet non officiis amet sapiente explicabo vero atque sint.", new DateTime(2019, 6, 16, 12, 44, 51, 765, DateTimeKind.Local).AddTicks(6467), "Voluptatibus non et voluptatem.", null, "Id officia dignissimos est." },
                    { 31, "3", 2, "Praesentium cumque ex nihil.", new DateTime(2019, 12, 7, 14, 25, 1, 178, DateTimeKind.Local).AddTicks(1039), "Ipsum aut ad dicta minus.", null, "Eveniet sit ducimus sint sed quod in." },
                    { 43, "1", 2, "Dolores hic molestias animi explicabo quibusdam.", new DateTime(2020, 1, 22, 14, 34, 51, 335, DateTimeKind.Local).AddTicks(6116), "Sit nulla corrupti officia.", null, "Officiis consequatur dolores dolorum eum maxime molestiae nesciunt est." },
                    { 44, "2", 2, "Est porro et amet repudiandae corrupti harum velit sit.", new DateTime(2020, 2, 25, 16, 27, 40, 975, DateTimeKind.Local).AddTicks(2658), "Voluptatem doloremque ut omnis harum earum odio.", null, "Quo reiciendis sint." },
                    { 3, "2", 2, "Voluptatem aut quia autem porro consectetur dignissimos fugit.", new DateTime(2019, 8, 18, 12, 6, 3, 477, DateTimeKind.Local).AddTicks(8641), "Atque velit impedit qui dicta quisquam dolore accusamus perferendis totam.", null, "Eius ut ex magni tempora." },
                    { 42, "2", 5, "Et mollitia et aut expedita et.", new DateTime(2020, 1, 23, 6, 19, 7, 533, DateTimeKind.Local).AddTicks(8142), "Magnam aliquam enim aut in aut architecto quaerat accusamus.", null, "In voluptatem assumenda tempora deserunt quo molestiae." }
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
