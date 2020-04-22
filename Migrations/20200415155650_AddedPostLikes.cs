using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class AddedPostLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostLikes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsLiked = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLikes_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostLikes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "331588e0-dc9c-4a33-b24d-4736b9a7b8a0", "38b462ba-e376-4d61-a943-a3b899079219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2bc3209d-f286-48bc-b4db-e1fcd3840e50", "e16410e4-f5ec-46cf-94f8-cdf103339173" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e92c736-1db8-4137-b351-1d74c4c9de82", "3c6848b0-029b-4bd2-9aeb-61409e19a84e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbd011e6-b02c-4919-88a9-a2530e269ad9", "0fec172d-6a3c-41c4-ac76-4e3b31c678f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3cab878a-ff71-4a4a-abcf-3cf4fca5d695", "bc97b9f7-7153-400e-902a-115ceffd9b59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5898c6de-2f1f-4cdb-979a-2628c4964629", "fad98867-b2c2-4fb5-a6e2-ac4c80ffc739" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4df86b39-d1df-464e-93ef-bb554661816e", "3728edf0-12ad-46ab-88e0-7b72466b4a45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d50b79c-7f9d-4645-9544-750d3079d24e", "c01b33e9-43c4-4ce9-a9a9-72ea3456bd60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc2f0692-d3f9-4db7-9b01-666dbab2b6b7", "64da748b-89e3-4ef0-b58c-9241f136fba1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11077021-d975-48f1-89ec-eefccef9a432", "7273b00e-776f-4d9b-a20d-3d1ee47cf1e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "201e7c38-b1c3-4e79-99b0-28ac7327b0fb", "e899c043-df72-4da7-bf3d-9d9b02f3192b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c52c5806-9860-48d6-8bee-7831ce27033e", "57779cf5-0fe5-4a4c-8ee5-22a4e903de1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62b5397d-c888-4395-8274-0f5e9747b465", "a39795eb-9d67-44fd-901b-08bc67da5bd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db143893-e676-4cf2-83c8-7ec7c4380112", "e2603f1a-6126-4563-9be9-033632b99f66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0a632a8-e123-4925-b797-f40cb61af899", "76082787-f9e1-4fd1-bb24-d04d48b40aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43cb92d4-df14-4143-8dcc-71f87a8b9ecc", "8b35ad28-b8b9-4b28-a78b-27790db9f71e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6535e761-e42c-4c31-8207-5c431c02db61", "6b030686-4575-45b2-a2f7-d8e1c4c95d9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8995c5ec-3665-40cd-8a4e-99dd549f2c3f", "3ca0ceef-8481-492f-b33d-4827d947f9aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b388505-305b-414a-a1c2-aa0ecb8bf967", "d5edddf2-f0b0-4df8-a6c1-6398e615831c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fc98791-770f-44c0-91ea-7f727814d748", "e4594e2a-bff5-44fd-af63-2ee6c879921d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5a76f85-9c86-44eb-b577-2c84283d1d65", "9e020e5f-a0dc-4f63-8e9f-99a099d27f04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "011539b4-1d08-44fb-9829-09e0b41e496f", "ef13ecda-21a1-4d2b-8962-f77888b63c0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da7b301b-8abc-4350-8393-ed8e833172c9", "0a1c93ed-a69c-48a8-8aba-1ea4d7a4ddb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dccaf218-7465-4521-bc9c-02509044d778", "4f8c74a0-a600-4c2c-82b6-07c0bc408c12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c330964-5d8d-412c-aa3b-e4c92a491972", "eb3f69ec-366c-4723-95f0-976163652b95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84ae7770-6ba4-4855-acde-521200643122", "0b98953c-5c43-45c6-b46f-e36abd776759" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67643580-a913-4c77-9318-07ae13fa9fcf", "521204d6-ea1a-4a01-a978-e31564abda69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "120db724-017d-427b-b777-14213996cdfb", "c66cf4d9-527c-4b54-bc30-c553647c0a8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d28efa26-ac48-469c-9979-46c61920b3e3", "f98818b8-c2ca-4d10-81ff-fe4a6858f1ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14c43a15-56b8-41f1-8765-441cd15ea75b", "c75348e5-f43b-45ba-a370-4556bd77545e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81b4d567-9089-49ba-a249-4978eb810adb", "5ff2cd46-cec7-40a8-bfa6-53f5d6766b5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "495b49d9-dbf2-4ce5-a801-8bbabf97fe39", "bb4dc1a0-8301-44ff-89c8-b97f6cb4fa18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9acb41b7-70df-45c6-9c7f-1262e29da257", "c7d1ba86-1ac7-45c5-9348-5dd46024dfb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9ff4b3c-1dd9-4646-80c1-16f1588d7c44", "cf4671ea-0a3a-4cc5-b703-7689de3bb03c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3380b55e-26d0-4d03-9410-f6d885ce406e", "35f971d3-8db0-4aac-9765-2da257f69d8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f75e7349-b011-406f-8d92-b836abe37076", "3832dbdd-96bd-4a35-810d-779c8f924484" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76ff2216-2770-4096-964d-82df735f5c4d", "32971bac-4261-4a1c-86b3-13d74a4c3927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2065c3be-7569-4849-831b-998b8bc7fc09", "92f48145-2c17-4a5b-a749-e828c46a2474" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "975b9fd9-41cd-499d-901a-ee3eb715c1dc", "5381d076-567a-4be5-9e25-1dfca06daf7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "835ed446-1176-4971-819f-b4ccf65d0420", "b00cccc2-f4c9-43dd-891c-330042b4f577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa040a29-3aac-40dd-acc2-d32ead43ceb2", "9820b4a2-28cb-4a9b-8262-65c4584078be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a702f704-62b7-440d-9703-bc0b4d4c4029", "e32c4e1b-ad14-41d6-9c7e-e30003717832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f9903e5-1fac-4ef5-9eaf-b93ce4457ca5", "d84878a1-4860-4f14-b309-2d5a34f6ad23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07409299-8296-4fbe-a427-ad98ba3810fb", "78067c27-de00-4478-a2f0-ea1f5edb3149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "969c5b98-a546-415d-80f7-c50c105d6668", "7b722767-7a07-4ea9-8c01-e1335148b4d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "988343c7-19f0-4ce3-ac8d-9cd8ee898d3d", "89848f30-a22c-40e3-8e17-b71eb74999c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c41d127c-edd9-459f-9761-f411da72aa06", "6bc524c9-49e7-480e-8295-3adaf9e02ce7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bff0914d-aaf0-4465-9350-8fbe88134e82", "643cd122-cfb6-40f8-9d75-132b75979087" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ef5bbdb-6348-429e-83ae-66df739b0fd9", "70ff9bc9-8ff6-4a3c-b618-d2d2b3232ddc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f31141d-81eb-4d76-8c94-d108ad80c843", "6a2cdded-fe60-4ece-812f-334ac3ca3266" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 15, 23, 10, 53, 853, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 7, 21, 21, 23, 23, 898, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 2, 20, 2, 30, 29, 653, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 4, 18, 22, 51, 418, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 7, 24, 23, 54, 45, 52, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 15, 22, 33, 37, 898, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 6, 22, 19, 15, 342, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 4, 20, 16, 16, 2, 201, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 8, 26, 1, 59, 55, 42, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 4, 27, 0, 11, 4, 90, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 2, 14, 55, 36, 922, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 6, 0, 8, 36, 320, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 7, 17, 14, 29, 9, 646, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 5, 19, 1, 56, 255, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 1, 19, 6, 45, 866, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 3, 21, 17, 33, 896, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 15, 0, 14, 8, 68, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2019, 12, 28, 23, 24, 10, 919, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 9, 20, 53, 45, 551, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 4, 21, 3, 37, 54, 536, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 5, 23, 0, 22, 51, 419, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 11, 18, 1, 59, 27, 693, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 12, 13, 44, 57, 115, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 3, 31, 14, 42, 7, 749, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 2, 21, 29, 45, 995, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 1, 17, 5, 27, 393, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 14, 19, 11, 54, 645, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 1, 20, 48, 49, 809, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2019, 12, 22, 14, 4, 45, 948, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 3, 22, 13, 47, 32, 997, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 9, 57, 2, 302, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 7, 26, 0, 52, 0, 35, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 13, 9, 1, 40, 154, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 11, 27, 18, 2, 18, 747, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 5, 29, 14, 20, 3, 282, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 8, 2, 8, 17, 847, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 9, 19, 5, 47, 41, 828, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 7, 22, 0, 7, 54, 477, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 11, 25, 4, 45, 39, 632, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 1, 4, 41, 49, 79, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 8, 17, 13, 34, 822, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 2, 25, 8, 15, 51, 189, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 14, 16, 57, 39, 397, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 3, 22, 23, 10, 28, 260, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 6, 25, 9, 14, 5, 676, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 11, 23, 28, 6, 688, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 11, 24, 8, 25, 0, 565, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 3, 30, 23, 42, 28, 380, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 8, 27, 11, 32, 3, 408, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 9, 16, 17, 5, 7, 825, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_ApplicationUserId",
                table: "PostLikes",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_PostId",
                table: "PostLikes",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostLikes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ac2ef7e-96fa-43e4-8b7f-1b63928424d6", "8b3032d5-07bc-420d-a28e-3673b29677f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f9378fe-9d37-41eb-8dc3-177b28a81c9c", "dd369dd3-a58c-41f3-a9f5-f35ce188a25a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c6ce2d6-306a-4561-bb15-fa4e5dc49d13", "093b1012-6004-4062-a7c9-920bdba66a10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29ae7b04-2e7f-4704-bdf7-07e45ea5c0d4", "70991554-3a53-4800-a612-35933dcad4d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3011df40-7ee3-4959-860e-221db2daf8f8", "13d541d7-93a4-48ab-9c4d-48b15270d9a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1731bc97-d0c0-4288-a3a8-6351bf6090ac", "8dfc647b-b92a-421e-8c8b-fe4a66c4cb1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf05f902-62eb-42ca-a9c3-188b9f561b9c", "70c8cf4b-dd49-406c-bf20-a08958a11c62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92ecbf40-3e8c-4d64-a0c1-60ff2ccb8a13", "2119422d-29bc-48db-b006-1a4ef6d6c3b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fae322e3-1d31-4618-89df-5f318a970021", "26d068c0-e35e-4989-9224-4c5ffdbda700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a26bd11-a8b1-4f9b-a0eb-e53b4d0db291", "4d30aa9d-f347-48b5-acfa-c2c0bd9212f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ea195b0-4c39-417c-b06f-cd554cf29e8f", "2730189f-edd6-413d-9664-e7db5cfb3789" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abaa1319-11b2-4631-8c6b-37dfa290245c", "8ebaee64-37d5-410f-9824-b151528dfef5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20c321b7-49fe-4cc4-a1dd-7ce2920d38aa", "671a860b-8f3e-4913-8c7f-c810d32e51aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1d06bc9-8385-4802-8cfb-63b3bab77fe7", "d30c18e9-9634-4fbc-b775-4192e6f306ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "114e023c-4ae3-4872-854a-a2a852f019b9", "1cabed33-c261-4b14-ab98-a48f8dbca7a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "003bab83-4c28-47af-8368-2d4b41aab811", "5940adde-ee92-413e-acf9-4764bd4038a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4aa9c545-4005-4926-883e-4b25860f0b65", "1a5953a9-cf7f-42a1-8150-7d17c7cda444" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12990660-81f4-4fa2-a3ba-8971694cd429", "1c74ad3c-a2e1-4120-8908-5d5160eac46e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9ac6c6f-6e72-4a6b-b45d-58e228656f19", "08dddfd6-dffb-4740-9419-1bb311b0d4cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9cfb8a76-9422-4a67-ba3a-6642864bedf1", "a5d8ee7b-8e67-40c7-8105-31d2e1a1d137" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc9a62d4-d68c-4856-89cf-a4a0cb29b6b7", "ac6d74b4-0272-4de6-9b14-0c8951b07856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fedb40a-1b63-4b26-80a4-1d303f98727d", "40fbfc7b-53b3-45e8-ae05-27cf64804648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5dae1dad-92ed-4656-91aa-f4e580d2fbf7", "22de2c04-c566-4703-8b4c-7ec913976e86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3dcc9887-ba0f-4b85-9467-57ab6e19167b", "1521e0ad-92f7-421e-9887-e5a24d56eda5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3e43e34e-8c3e-4620-8675-b1aca9f175d3", "3b891580-9fcb-4e7a-8cde-de42d3ac3de6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "211b59ae-4470-415a-9d06-f0d5b8fce261", "9a900d22-0211-417a-9ed2-785c10d79eb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b93bc05-9db7-434e-acbf-32a6f73ba8f1", "9e81597e-5267-4457-bdd1-b5f2de1e0c24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a87468bf-9cdc-4ea9-9962-d98b22cfb8f5", "51fc8ade-8fd5-40bc-bbd1-aa5272bcf4db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "640ac742-a6e4-4086-87a0-9b22c779f0fd", "d1f5a3a0-536b-40ee-a6d3-7dd6940f8a84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07e2d59a-fda2-4219-b757-d2e37813338c", "05941abc-c526-46da-a4b0-a7d6f0007b04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "234940ef-be5e-4964-a239-c80df09cf203", "3574202f-7115-4492-a2c3-8d4db96569a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0797f82-38c9-43e9-a992-58236a5401fb", "84e32548-df7d-4b86-8430-0af6b4464a5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c9d2158-8c71-464a-ad95-ef7ea78959ea", "16673c05-8a3d-4ff3-a1dd-89007021cebe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac01fc79-02a8-4bc1-802d-d283d3264f27", "2e5c2c75-2207-493d-89de-dc1dcbd43040" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f894be3-b3a1-40ad-bea0-a5bcd89ea3ec", "eacf2847-b405-469c-802e-01b3abcf1093" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bad7fc9-2a29-4ffe-a53c-0e2b295ce2fd", "78a1a7b7-b878-4bfc-adc8-5ed16cf71ca4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e75b5a6-e4a6-44d1-98fa-1723703712d2", "44380374-ce6c-4411-b553-e418c7ae5f57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28dc263b-107a-4341-bd15-0c86adeb19aa", "3186dd5a-f4d9-46a6-a211-6654528b6333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a1265fc-e89b-425d-a194-ae2d5237915f", "6cc87ded-12b0-41e0-a8e6-7286e116ab19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e853fd1-8ec8-40f7-b992-150203270f7b", "8e582169-5da0-4f3c-87f4-01b31e2ba5e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7970442d-e58d-4d25-a31f-e4bda6cc4e3b", "f23edae4-3b73-4e0d-96df-886bd128eca8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a77aff07-66b3-4a02-83fb-10ba8f33f034", "8ad634e4-1308-4086-aac6-163e8f61b069" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ab8c107-f5d5-452e-8083-9e4cb7058594", "4e12c725-cadf-4e5e-8517-1083bb99e201" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6d3785b-5438-4f12-9f07-e3be4a10a484", "6371396c-b4e0-4444-bdad-2ec52279b591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a6aac1b-2a43-47b5-a9cb-a88621b91742", "a944f7ea-4b5d-4560-91c1-92e3c25f7ebe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30cc53d7-aef5-441c-a080-17ee38184bfa", "4cc7a8d8-2e71-464f-a9b3-6e312faf8745" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d9d7b20-f972-4b5c-9f19-4e85b653ddfe", "abbf9670-5123-40f4-922e-a93ff9a83061" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df0ce17e-c304-48e0-942c-0cb425fdcd4f", "858fe75b-10fd-4954-a2db-4f6dc2d97c11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87d43c34-d375-4bc5-99f8-cf17c5bbfc79", "ac414909-6163-43e0-82ea-7eb33f829c74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7249b78d-4653-4843-bb8e-e1643daade44", "509e9ec9-61c8-46a3-b1e2-9603fca31348" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2019, 12, 28, 17, 48, 4, 54, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 7, 3, 16, 0, 34, 100, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 2, 1, 21, 7, 39, 855, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2019, 12, 17, 13, 0, 1, 620, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 7, 6, 18, 31, 55, 254, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 7, 28, 17, 10, 48, 99, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 2, 17, 16, 56, 25, 544, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 4, 2, 10, 53, 12, 403, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 8, 7, 20, 37, 5, 244, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 4, 8, 18, 48, 14, 291, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 2, 13, 9, 32, 47, 123, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 6, 17, 18, 45, 46, 521, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 6, 29, 9, 6, 19, 848, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2019, 12, 18, 13, 39, 6, 457, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 5, 14, 13, 43, 56, 68, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 1, 16, 15, 54, 44, 98, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 6, 26, 18, 51, 18, 269, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2019, 12, 10, 18, 1, 21, 121, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 8, 22, 15, 30, 55, 753, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 4, 2, 22, 15, 4, 738, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 5, 4, 19, 0, 1, 621, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 10, 30, 20, 36, 37, 895, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 5, 25, 8, 22, 7, 316, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 3, 13, 9, 19, 17, 951, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 5, 15, 16, 6, 56, 197, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 8, 14, 11, 42, 37, 595, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 7, 27, 13, 49, 4, 847, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 6, 13, 15, 26, 0, 11, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2019, 12, 4, 8, 41, 56, 150, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 3, 4, 8, 24, 43, 199, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 3, 3, 4, 34, 12, 504, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 7, 7, 19, 29, 10, 237, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 2, 24, 3, 38, 50, 356, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 11, 9, 12, 39, 28, 948, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 5, 11, 8, 57, 13, 483, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 2, 18, 20, 45, 28, 49, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 9, 1, 0, 24, 52, 30, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 7, 3, 18, 45, 4, 679, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 11, 6, 23, 22, 49, 833, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 2, 11, 23, 18, 59, 281, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 8, 21, 11, 50, 45, 24, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 2, 7, 2, 53, 1, 390, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 6, 26, 11, 34, 49, 599, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 3, 4, 17, 47, 38, 462, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 6, 7, 3, 51, 15, 877, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 8, 24, 18, 5, 16, 890, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 11, 6, 3, 2, 10, 766, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 3, 12, 18, 19, 38, 582, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 8, 9, 6, 9, 13, 610, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 8, 29, 11, 42, 18, 27, DateTimeKind.Local).AddTicks(4398));
        }
    }
}