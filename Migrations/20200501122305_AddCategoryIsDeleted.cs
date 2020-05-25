using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class AddCategoryIsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c6b0452-d9c6-4444-aa92-fc5d84083134", "7ab28494-6d6e-4220-a585-197a2da96aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d6fe7da-0e2e-47a4-8154-1dd0ac5cf9bf", "2c50b82e-b76d-45b5-8a1a-9870e5f10845" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76bcefa7-4354-46da-867c-db6c59379efb", "6e371fee-9c8c-4910-b9a8-34a4bc7bfb6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6eaeefab-0bf8-438d-ae07-e21f4d5d7f26", "de326066-2c06-4e42-beb9-841edbdc6a56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78d3cb35-0408-42f7-8ffd-0f2524f7825b", "d380c3b0-7752-49ff-ab2b-74c9ea750074" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43c6d614-7b3f-4492-a72a-cfb62ea26939", "22b8a3fb-12fe-4049-b12e-e760e239f79e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24fd1086-a1e1-497c-a64e-583a00e51ad4", "12780757-92a2-4a88-b75d-1bc87a78e2c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08d8f26d-ad18-4a56-8935-c314b5f2c7e4", "106f57e7-ef97-42f6-8859-b8f8bde4a75d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "730f6126-d4d8-43a0-9f37-1ede45600df3", "60471582-3f42-4525-8466-e916c52ebeb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8f11742-1d0a-484a-9804-5a5b162f3762", "c1b40196-fd8a-4f22-83a6-c6c524df45d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3e7b5ed-2f77-4ac5-8db4-cf75d0d6f0b6", "b9d38b78-b3d5-4340-80e6-615334d59ecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d293cf0-670f-4df8-9909-2a04a5fd3411", "ae80d7b6-06b4-45b6-867a-b28961830f94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "751c0e2b-25eb-4826-b645-1f5476529980", "428021c1-10c6-43a9-a66e-7cf9dc0effa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a2aa1d7-4947-4dbc-8e27-0d90e90a7606", "6a51d920-9efa-47fb-ad20-3f8811b5a95a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "369b20b4-13aa-4840-9db1-3b3764b157c1", "c2525280-e3c3-4f6d-bfc3-5361e230741d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "066caf5a-f956-4175-8504-2d08f3fd2c8f", "d71cb98d-4d45-47b9-8a2a-bae4a09166f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76c3d357-e351-4782-9b45-d314439eebe1", "c5af809a-d1e5-41ee-aac4-25a0ef7a33e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2282ea0-70df-4e63-a209-51c3c4268a6a", "203f1911-df0b-46bc-a163-1718ff1fb962" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa5d08b3-4c12-4b65-8baf-b67e19ef11ef", "d3475b10-a34f-4053-8778-3cc0a183f890" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "befc2bd8-6a46-4af3-a4e4-f1ada1be4e01", "0d8aaf51-a2e5-4b60-b730-4c5ced3cd2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c370b7e6-641b-416d-b0ce-8ea2fa3a0974", "65a6fa53-6db4-425b-bb08-97dbd6b68810" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b87ae99e-9070-4a12-90db-9cc5c0bac51e", "25ea4cb8-3566-4023-9f94-a813b43eeec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9748ce01-c481-4c40-b130-8de4845c104f", "d910639c-6ca4-4e3d-be0c-d988411192d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e064970f-c356-4080-b7a1-d85d50fb07e5", "55dee3c5-d1b5-4e9f-ba8e-d7e196a03c43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d707f05-b75f-40eb-ac3b-cbc6bbea9d5e", "8618054f-4d7d-46ad-bb2f-46052e293d1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdc5d75e-dc1f-40c4-9e5e-fe623d2aee38", "11c93bf8-02fa-4b1b-80d3-27d281ce5223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55d9a0f9-5124-4125-86c1-a644867ffc2e", "8ef03094-ea5c-484b-b990-92807c814e71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "063f0091-77d2-4382-b70d-9aed908c05d5", "078621ba-7d3a-4038-a4f4-081e8053fb3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "648f1874-216c-4198-ae6a-55405d7c0fbd", "4c27d54a-1a21-48e1-b3ed-9f53cb09ac95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccdf1d47-9b16-4767-baf9-2a03b514c744", "30458459-37f8-4ff4-849d-44caa9f8a6ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "743c4683-78eb-4c31-b80c-75fc6d0006ec", "fdc2415a-ffcd-4a9f-92d7-dc8dfed2ef14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e58e94b-c064-4a39-8b9a-36fc2f9d4d96", "781eb865-826b-4128-bc80-b084ac4eb459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f952ba06-ee5f-4d0a-b747-933a7c09a10e", "aa2fe695-5d5f-47b1-8ee7-cccb1d2f3032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e51cccd3-50f9-4835-a51f-4e192696ec85", "92eaf96b-4ef3-4614-9b93-105549aab8c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5aa779b6-4c2f-49bf-999b-55aed614bc90", "3ab1be8a-0469-4884-8245-7291258570bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e31f713e-7bca-47f2-8ac5-becb02bbc79a", "9f0c63ff-418d-4c8e-9a38-5efa2df7ff18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6a22af4-7d4d-427e-a95d-ee4c8de78293", "5f2adc00-7b14-40d2-84a4-cfa90c5a1e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f803e719-2fc3-425b-85b9-e00a8a6aec78", "666a9d1f-eea8-4d8b-983e-c8df91162aa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48628795-bfb8-4927-bfb2-b02d430e5dc5", "b6d63cf5-1b7e-4e24-a98f-9de26a864334" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06be00c9-bd54-402f-8ee9-4c49c2a816f0", "18484611-a61f-462a-9e1d-44a952298039" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e85c064f-5b1a-495d-9fcf-024bf41b4e2d", "27080239-6ca1-42a8-a3e1-f1e57227e2b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34fe49fc-7d00-4082-98d2-b96858992e3f", "a2e0371f-5121-46b0-a46e-34fb482caa12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac7f5581-674c-46b2-962e-aa6f3a6f392e", "460ba0c7-0b74-4ef4-80df-0213c715f13a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "033e8bf2-1d5a-4d6b-87bb-c7fb278a2993", "1afb563a-a96f-448b-97bd-5589e56c03e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01186b08-05c3-4427-869d-03f81452af3d", "caee8839-3897-4bdb-88f4-3fd6cc46d718" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de4a7d61-d4ea-4dfc-972d-dda5794b8fe1", "b56ea065-1d0e-4483-9dff-8be58fee6058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56c82fa6-5626-401c-b96f-9a14bfa9aa3d", "d8a2acbc-6c5b-4580-857f-8d57d1e7e406" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64b7679a-5e37-4855-a501-04aa78382e98", "665834c6-2dd2-4b30-be55-936637045511" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94473fd3-b74e-4116-a911-e4cf9af5077d", "83fdad1a-e236-4ebc-ac7e-1aae70190d31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "829ec4e4-1b02-4748-bfc8-222e2731d874", "c39ffd0f-9055-49da-839f-9ed90e6ceedb" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 31, 19, 37, 8, 798, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 8, 6, 17, 49, 38, 844, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 6, 22, 56, 44, 598, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 20, 14, 49, 6, 364, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 8, 9, 20, 20, 59, 998, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 31, 18, 59, 52, 843, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 22, 18, 45, 30, 288, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 5, 6, 12, 42, 17, 147, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 9, 10, 22, 26, 9, 988, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 5, 12, 20, 37, 19, 35, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 11, 21, 51, 867, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 21, 20, 34, 51, 265, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 8, 2, 10, 55, 24, 592, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 21, 15, 28, 11, 200, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 17, 15, 33, 0, 812, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 19, 17, 43, 48, 842, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 30, 20, 40, 23, 13, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2020, 1, 13, 19, 50, 25, 865, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 25, 17, 20, 0, 497, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 5, 7, 0, 4, 9, 482, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 6, 7, 20, 49, 6, 365, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 12, 3, 22, 25, 42, 638, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 28, 10, 11, 12, 60, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 4, 16, 11, 8, 22, 695, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 18, 17, 56, 0, 941, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 17, 13, 31, 42, 339, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 30, 15, 38, 9, 591, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 17, 17, 15, 4, 755, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2020, 1, 7, 10, 31, 0, 894, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 4, 7, 10, 13, 47, 943, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 4, 6, 6, 23, 17, 247, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 8, 10, 21, 18, 14, 981, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 29, 5, 27, 55, 100, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 12, 13, 14, 28, 33, 692, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 6, 14, 10, 46, 18, 227, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 23, 22, 34, 32, 793, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 10, 5, 2, 13, 56, 774, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 8, 6, 20, 34, 9, 423, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 12, 11, 1, 11, 54, 577, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 17, 1, 8, 4, 25, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 24, 13, 39, 49, 768, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 3, 12, 4, 42, 6, 134, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 30, 13, 23, 54, 342, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 4, 7, 19, 36, 43, 206, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 7, 11, 5, 40, 20, 621, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 27, 19, 54, 21, 634, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 12, 10, 4, 51, 15, 510, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 4, 15, 20, 8, 43, 325, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 9, 12, 7, 58, 18, 354, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 10, 2, 13, 31, 22, 771, DateTimeKind.Local).AddTicks(3360));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "544466fa-8c3d-4b3e-9710-6fe8615202ed", "e514b5b0-e255-40c1-9cad-595fea95a576" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d6c568de-0672-465d-998c-9a9f8b855f01", "708a0b40-49f4-4a30-8690-40a82dbcfd03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6880d00-c6f7-4e50-b1ce-370423486164", "48f84ea6-48f7-46e9-831c-46d0a8eee71d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "062f6adb-4c8d-4d37-bfcb-a37135f67e82", "77704053-f207-42ef-8ea2-f0d53b4a88b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c617b8e-0269-4c10-b3bf-3798069c5baf", "3df7d5eb-37c3-426b-bf4a-ab2fdd66e33b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f83c65a0-b03f-48be-826a-b4e7f3a66a72", "19592ea8-efec-4b53-90cb-1becf1846595" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b4e70144-9a87-4271-b009-ab507a03df63", "f09a862e-82a0-49f1-920e-c8f1ba6afdae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4ea837b-a8d1-4213-8ddc-4345b55d2bfb", "99b42375-39b6-4cd0-a5da-d5f56718b890" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f47dec9-f815-41a9-99c5-50be5d459cbc", "f8909ef3-3f87-4346-ac4c-3ee81c7c37cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "117e0f8d-7b98-413b-8cdc-1a07f69f1a81", "5d8a1f4a-339d-4881-a618-1235d137716b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2988557d-aab4-44f8-8d8d-f877a571bbd8", "6fa2d63c-4d02-45b3-82e6-0ab4cab45464" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "781bc122-2ef9-4392-af66-1ab7925495a1", "e52b8481-d865-4fa1-a1ce-199f06bb3e99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d70d2b63-206d-49a3-9fd4-1f176a28152a", "f339be56-5c94-46c4-897b-0ff0fd13daca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd679eca-84f9-47fe-8e61-728de4ac6a6e", "ee74a25d-f848-4426-97f3-4de058566424" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e599f1d-ab20-44a0-89bc-1b34b525f9d0", "848ebd15-cee9-43eb-903d-b5491c59c8e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b13bf85-57be-46f9-aec8-fae8098c4e00", "d659ae8c-0ef8-4b54-a66a-963c79328fb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3097d03-9e3c-41b4-b351-b7d8b9efd0ce", "da9d35e3-d7ed-4846-812b-ad3ee20bfa91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8420df7-3da9-4eb9-8bd8-d53f9fce6332", "d9147839-9c8b-4999-976f-cedd2ac7f856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e95d89c-3754-4276-88be-de2bb26be8da", "88d50557-fbd8-4a2c-9aa5-e28688310221" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d922456-e73e-4a00-bbee-4d638ae0216b", "f68931f4-4a7a-477f-8281-bf057e0a1e72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc0cf144-0a3f-4c4e-a709-e3842fff6409", "88ecd971-24df-4a6d-93c2-c88cbe6a8f5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64d501b8-c6b5-4fb1-8f1f-4dec597e1e61", "63e04a04-c1d4-4d6a-a738-73b72e8614c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9658a5d-eedb-4816-afc8-ce1b180082fa", "463bcc71-1144-42f4-9487-f0a4cd61e428" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d683964-61a2-41bf-a6ed-38cec0e22bab", "5f8da1fe-ed56-45cf-b42d-6d09b6be6ba4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7867e7d4-3acd-4944-bf16-61035afa91fd", "a3b4a1c5-cc42-4e79-bb37-991a4986e8e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fecb08a4-01df-44d4-90dd-fe359057be3f", "7c028028-074e-4b29-aa72-f710c994c5ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3716433-72c1-4823-a419-29c7d4169229", "92a25b19-7ba9-4d70-81c8-1810d5f51a70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37cd6a71-364e-476d-96e1-f358d035f945", "78f93110-ed8a-4cd1-afc9-98eb277a6796" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "937f198f-fb7e-4bcd-ab2b-ee188eabf62d", "3b0eefc0-21d6-4e7a-aec5-ef51e4199c59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c090308-a79e-4ad2-b02f-39b474dfa5bc", "92c0d8eb-5396-40ae-bd00-e795bd9a122e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a719e64e-50dd-4ac1-955e-8509d74415b4", "f44ec93f-aa34-479e-a6f7-f49ef258189c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d29861b2-1486-469c-8af3-7d8a3eaa7b13", "e7a30061-3c8f-4560-be5c-8b8a2906616b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4005bc9e-8788-4326-993d-225cec5afc9a", "1c8499e3-4ef2-459e-8d04-da1e0f964aac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d714b511-23b3-4d79-8366-d9f884f0181f", "bf4d97bb-4417-423f-b9c4-0f97bcfb7c19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7d2b7e2-ed42-4e40-b79a-ae77a3e81af4", "23a3a4f1-b0c8-44b4-bbcb-98576b6d5070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "616a41b4-568e-4ffb-831b-e29d7eee4ae9", "d0a1e5d0-2613-40f0-850f-a3fc6c4af59d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a509d74d-6349-4e11-b03c-304c8cab3015", "1779e916-9ca7-43a2-b79b-0fd01b71d75f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49c40ed8-154d-4de5-bde4-419f037b4ba3", "c879753b-3b8f-4d35-8bf6-44cfe2468b73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e3f58cf-76f3-4497-9de2-0a39c0b6a6c6", "776829a6-d9df-4233-9e50-facd68769f74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b3f6f17-53d9-47b3-8eb3-0f4c4c267d74", "bd6be84a-4fb7-4a9e-a1e8-fcb1036d77e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af93320c-c4ae-4de9-91ff-6b7dd224c30d", "767181b3-29cf-47fd-b750-72a2db7b4c6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34e2ae37-d484-4c29-baf4-e6abb602fe35", "c2589093-05dc-4983-bfaf-be7698d7df87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4365a9fc-492f-45da-b5b0-83c8241d2ccc", "328bd777-92a4-417d-9b4c-3277b093615f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cc2b5ec-44ed-48ac-a995-2afc7d404023", "39943c71-08e3-4ef6-9305-28d07b068e8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e092824-f205-41f9-8147-22b108940e2e", "0550799f-b581-43f1-a810-56c77ec963f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f7a7248-be23-41e5-a191-88bcaf189109", "0c194a72-9534-4a0c-b139-8622d315f33f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3772e1f3-7ca2-4b61-9089-0a828a28a713", "f8f54506-29b0-44fa-8d70-9a10d09edc3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3eaaff24-afdd-4a5e-b876-2d5f41ecd2b3", "f4f6afa0-b968-48c1-99d1-dbb157d2d6f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86123756-9423-46bc-8388-92f71d01e146", "7c5af6b9-602b-41b6-968b-a2a8eab2ce83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8b33051-a3c4-4221-bd35-3f63d149b1c3", "98be399d-cf0c-480b-83a2-d8f45f23ebf9" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 31, 16, 51, 2, 636, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 8, 6, 15, 3, 32, 681, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 6, 20, 10, 38, 436, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 20, 12, 3, 0, 201, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 8, 9, 17, 34, 53, 835, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 31, 16, 13, 46, 680, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 22, 15, 59, 24, 125, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 5, 6, 9, 56, 10, 984, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 9, 10, 19, 40, 3, 825, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 5, 12, 17, 51, 12, 872, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 8, 35, 45, 705, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 21, 17, 48, 45, 102, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 8, 2, 8, 9, 18, 429, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 21, 12, 42, 5, 38, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 17, 12, 46, 54, 649, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 19, 14, 57, 42, 679, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 30, 17, 54, 16, 850, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2020, 1, 13, 17, 4, 19, 702, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 25, 14, 33, 54, 334, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 5, 6, 21, 18, 3, 319, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 6, 7, 18, 3, 0, 202, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 12, 3, 19, 39, 36, 476, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 28, 7, 25, 5, 898, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 4, 16, 8, 22, 16, 532, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 18, 15, 9, 54, 778, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 17, 10, 45, 36, 176, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 30, 12, 52, 3, 428, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 17, 14, 28, 58, 592, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2020, 1, 7, 7, 44, 54, 731, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 4, 7, 7, 27, 41, 780, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 4, 6, 3, 37, 11, 85, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 8, 10, 18, 32, 8, 818, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 29, 2, 41, 48, 937, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 12, 13, 11, 42, 27, 530, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 6, 14, 8, 0, 12, 65, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 23, 19, 48, 26, 630, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 10, 4, 23, 27, 50, 611, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 8, 6, 17, 48, 3, 260, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 12, 10, 22, 25, 48, 414, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 22, 21, 57, 862, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 24, 10, 53, 43, 605, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 3, 12, 1, 55, 59, 972, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 30, 10, 37, 48, 180, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 4, 7, 16, 50, 37, 43, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 7, 11, 2, 54, 14, 459, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 27, 17, 8, 15, 471, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 12, 10, 2, 5, 9, 348, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 4, 15, 17, 22, 37, 163, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 9, 12, 5, 12, 12, 191, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 10, 2, 10, 45, 16, 608, DateTimeKind.Local).AddTicks(5719));
        }
    }
}
