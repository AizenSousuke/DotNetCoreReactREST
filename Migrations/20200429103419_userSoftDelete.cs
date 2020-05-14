using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class userSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4960c38-916a-4931-8f45-62b394ccdad0", "62958640-7210-4b23-816a-8ab80291904f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50fb1ebd-f391-43c6-aaa7-3506a5cc461e", "22033968-2d8e-4b8e-9628-918d965f505b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f44d2ef1-28ab-4910-8b7b-0033eead9443", "cdb6eaa7-bea1-4f64-993b-0ad8f36fbeee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a96025a8-aa04-4b58-a892-bbfd31610039", "316ce480-b6b4-44ff-afd2-7ab1052243b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c7dd60b-94c7-47db-88db-4ca2cd02aac4", "83dab81f-02f3-4c2b-a548-a36d0caf3a4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f966d5e0-29c5-4b35-a409-228a13e6b264", "2bac3687-d5b8-493b-a9e3-aa1a8a14e77c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a55834b8-8894-48cb-9ac2-11519c048469", "03349d0f-6655-40c0-8cb9-f04a7eb83efb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3513eeb1-2fc0-4cc8-9852-763481bb6af1", "d7a1bfb2-db6a-4a74-9ef7-5fbfc4593268" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ac557bd-f2d2-4d36-bac1-fb192fe45cc9", "dffce0ab-1c4d-46f6-914c-6ba4d55832b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2cd77607-53ff-4502-be5e-936e6f3ba05a", "c51d753e-ffb2-4c4d-8694-6537eec4d1c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89f34988-8092-4bbb-96d9-280e3079d261", "9da0bbac-563f-48b6-9b4d-d9e235f26d60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9b6991e-b370-4d02-8eae-aee820ce0323", "fd61e52d-f39f-4536-a024-619791d6be4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1979313b-9063-48c0-b252-8b3fef67fe7c", "d76b41e6-3414-47af-b422-76a25a203aac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14a1b9a4-2015-4f1f-91ad-6e2919480caa", "359f0e2c-89c9-4325-9f13-56144c7ee36d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ce3eb01-342f-4084-9ece-f7a30ae23cd8", "4d13b6ec-3038-4209-9b57-e4c7830bab3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "072c877d-21c3-4463-a524-6903d9a97bdf", "8ef50f05-d55f-437c-868b-27d5839530c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "756be1d1-9ac1-442f-8249-a8363bb4b7a5", "73d7aed7-b95a-4703-baf1-ef7168070504" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb1d9e7f-1a6f-4e2c-bd11-ef67e51f106d", "469377bb-2a69-4d3b-a87d-8b5339234b5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "642118e7-5e09-4fa5-988f-59770190aaf2", "712191de-68a4-4eaa-80e0-d2a71eb682de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a6db3e2-5db3-4ca4-a7d8-50047ccbb940", "80c577db-5e00-43af-92d4-0acaff9132cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba4ea58a-34f5-45fd-865e-adda812cb36c", "35f6bdac-a226-402c-831e-3246bf2f96b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "587567ef-4417-4c52-b7d8-b4deca3626e1", "37478830-b62a-414e-913d-545c8218fda3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9131e11e-0cf4-48b1-a171-6a1ed91c8749", "1bab04f2-fcb1-48fa-9dfe-3a3a93be91c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a331abd-410e-49db-b9d0-a4cd39860dda", "4e1599f8-ab72-4c1b-8e2c-cbb0f086e5af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38d739a9-bb29-41dc-b712-0bdfa2948079", "e12ee922-9ad6-44e3-9671-3dce628fa476" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f1da677-06b0-40f1-b51a-41ceb8e48050", "83c89bff-fa0a-42f8-895d-d82b3f6b5a6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51ecf3ec-edd5-4e91-a9a6-ac781ea66fc4", "7bf7b30d-5cb0-4fc5-9f8e-feb3f0f10d57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9174a26-2cca-4650-ac5e-d94c7ff115c7", "f017b639-8a2f-4c7c-ab5a-5dd9edfd374d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c25635d4-23df-4f7c-ab03-49862d75187d", "794042e9-3a8f-4eb9-ab72-a46068203270" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0676cc4-bf38-4770-8810-cac7acbfe95c", "78f60ad8-297a-4238-b859-4b02d25d7745" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de10b207-78e1-466f-a9b2-feca324046e3", "462f861f-28b2-4cc4-b7b3-e4a93cabd1f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fe7620f-e593-46d7-932a-e362f7b9529c", "13321b28-4943-4281-bd49-cc316400bcd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ca5bee5-6b1c-4c32-a071-98d96ed8d477", "dd8d09ce-0402-4480-84ea-814bb1ca8f25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39e1c349-18e7-439d-8a18-d2cf3dbc2ef8", "e1b68d13-8d21-4e56-a6f8-8f92d797595a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db2e23fd-558a-4ce2-873c-71815e40ff86", "778d59f7-0b5e-4773-bc4d-18971b4f05a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88d83408-88d9-48c7-9acc-942d375fccf4", "03532b5a-1d43-4842-b121-6239f9760c53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4bf6a20b-87d1-4e9d-8d55-cc1d8ca66631", "96cabf1c-df20-441c-b12b-2e6a6572674c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5047cf8d-963d-468f-b14b-1121fdf016a2", "590cc730-7b35-437e-ab5d-f27fa9541886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f529376-871b-4aa3-97aa-02f9b167c17a", "c51a67f9-6206-41a7-860f-3e64eb656a16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20ee4cc6-8972-44b8-908f-3ba3d5b1569e", "c3d11475-8d9e-45c6-8b4e-02ad14d7c61a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54317cf7-0dd0-4cbe-979e-62b2a049f7f1", "b8741a19-25c6-4d7a-ae0b-d8acf396077c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4015c1f5-dfad-4fe5-8037-52f8d579e093", "c8bbcd41-5baa-479e-adf1-7ef4234171b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45659a9f-1b3f-4b6f-a866-243b19146963", "a7b12d71-e4cb-4892-8d89-33efc40611c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0c456cd-b7d1-4616-a5f9-074ad75a97d8", "5f8b9d56-31df-4031-baa0-a3d036332d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6736025-7681-4d08-8b13-af138139953d", "a4acd21e-d6af-46d0-afb1-93482cabeaf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5e47297-7f10-4067-9a35-8dc22ca6ccf8", "5e9c057a-1cad-446d-a9a1-3a1fe556392e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc7d1d9d-4671-4b67-8997-4a8b7dffd57a", "5276cda6-373b-4a15-bce5-26c5820e28be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b93b21c8-bf82-4eeb-a199-54d0f3cffd8c", "b38875e2-a03a-4de2-b1dd-cbd66b4eb24b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0f1c277-0bbb-4945-aee1-4179ac4cbc0a", "c7453bc4-9759-43d6-856a-d057c52b0617" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d5d698c-0bd4-4c7d-a82d-cece144a7b39", "c1112920-4543-4805-80a1-68f2525bfe74" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 29, 17, 48, 22, 889, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 8, 4, 16, 0, 52, 934, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 4, 21, 7, 58, 689, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 18, 13, 0, 20, 454, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 8, 7, 18, 32, 14, 88, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 29, 17, 11, 6, 933, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 20, 16, 56, 44, 378, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 5, 4, 10, 53, 31, 237, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 9, 8, 20, 37, 24, 78, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 5, 10, 18, 48, 33, 125, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 9, 33, 5, 957, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 19, 18, 46, 5, 355, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 7, 31, 9, 6, 38, 682, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 19, 13, 39, 25, 291, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 15, 13, 44, 14, 902, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 17, 15, 55, 2, 932, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 28, 18, 51, 37, 103, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2020, 1, 11, 18, 1, 39, 955, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 23, 15, 31, 14, 587, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 5, 4, 22, 15, 23, 572, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 6, 5, 19, 0, 20, 455, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 12, 1, 20, 36, 56, 729, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 26, 8, 22, 26, 150, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 4, 14, 9, 19, 36, 785, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 16, 16, 7, 15, 31, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 15, 11, 42, 56, 429, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 28, 13, 49, 23, 681, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 15, 15, 26, 18, 845, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2020, 1, 5, 8, 42, 14, 984, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 4, 5, 8, 25, 2, 33, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 4, 4, 4, 34, 31, 338, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 8, 8, 19, 29, 29, 71, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 27, 3, 39, 9, 190, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 12, 11, 12, 39, 47, 782, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 6, 12, 8, 57, 32, 317, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 20, 45, 46, 883, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 10, 3, 0, 25, 10, 864, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 8, 4, 18, 45, 23, 513, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 12, 8, 23, 23, 8, 667, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 14, 23, 19, 18, 115, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 22, 11, 51, 3, 858, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 3, 10, 2, 53, 20, 224, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 28, 11, 35, 8, 433, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 4, 5, 17, 47, 57, 296, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 7, 9, 3, 51, 34, 711, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 25, 18, 5, 35, 724, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 12, 8, 3, 2, 29, 600, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 4, 13, 18, 19, 57, 416, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 9, 10, 6, 9, 32, 444, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 9, 30, 11, 42, 36, 861, DateTimeKind.Local).AddTicks(4552));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6a08e01-7932-46ac-9082-138a4e60eb7e", "2044479b-3edc-42fd-b67a-664b312e7b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d69943f4-2259-40ab-9efa-f35a9e58753d", "f90bd22e-bb6c-4c0d-8726-1b6a2192938f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4244cef3-63bb-4689-8ac4-45bd7cd5eb81", "5b62ac07-b33f-4d45-ac1b-c709bf33c03e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1d75afb-ece0-4150-b7b2-32d454b69966", "2901468d-1131-402f-8da8-eafc0af2d2b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c6350f7-7680-47a6-b4b7-9d3c9c01fc62", "288c7733-4361-4395-a882-3d47d23c778f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9092b1dd-f20a-4734-8b20-bd87f85e8818", "1b25347d-da43-4bda-82c8-8fb8e3a7327a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd0310fe-14ce-45f1-9c04-45a3f952f63f", "9695d993-c4ff-431e-aeef-87299a0c8653" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4919c2df-957f-4d6d-9aef-f3ae2ddc5fb5", "ec437456-4575-4c40-ae6b-bf58f4effea8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95a5fd0d-8bce-4e2d-8ecd-c80df75d72ca", "80f80ee9-cff4-48c9-89fe-fade8151ff6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82267577-f907-4c72-a43e-def24079942c", "0910059e-f8ab-42ae-9a06-f4e92d295e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3818005-4930-4cfb-aad0-3f3578cf904d", "66766dac-45a2-4527-ac2b-36048813a415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41811f8c-9cf2-41a6-86f2-69e51db3657a", "bbb99ca9-3248-4825-aa56-477aa66ff3e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2428a0bf-9694-49e4-8160-ec1938665bf6", "1bbcb24c-9446-4402-9597-6d4d2dec8826" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86d18def-f29a-470e-b332-61d289a56820", "d687481d-8910-4c7e-85d8-f600bcd0633e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dc9aeeef-9be0-4011-877f-c3f74bddc8cc", "d9206d46-dd93-421f-8530-a65c978f4667" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29221819-ce78-4222-9394-fef0893c7f5a", "66b7a925-fb73-443d-b9cf-37da3de57f46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a3a827d-f61e-4017-8bdb-0698fe34f2d6", "521fbc38-47f4-4e8c-852f-dd16f6b609f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62560854-e716-450a-8280-c552e9d3a8b1", "4b6e5ec7-a098-4eff-832a-ed30b4b8cf2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2cc1346-a47f-4db9-9811-0834578cb731", "920856ad-13dd-45bd-a222-4e32fcc38f42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "66120acf-e5e4-477c-834e-19b09a46d61a", "f78aefb5-2e1a-4ff9-a412-dfbfe70b48ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ce954b4-21bb-47eb-ade9-60b0973b01b4", "74ea8aad-7763-440b-af88-937611cf1092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4e80127-a854-474d-902d-7ec745369a4d", "a6a67b2a-5d59-488b-bbcf-703be4098030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3702126b-24f4-4d6b-aeeb-1c3ddc06d425", "9ca056a1-ae9f-44cf-8afd-b7dd8927a0a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bf0a485a-9a3d-40f5-905d-14eca8460a96", "59fcedb0-f440-4993-ba78-1350f068d8c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "35a80b8d-4502-4093-b638-6f2c558f230b", "f35ca837-03a1-4c26-98da-e2b436152588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa7a8546-abd0-42e7-8096-da1dc88926b5", "1b938f52-0547-44bf-94bc-5196802a24a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72868e7e-6ede-4ed6-add5-06ed91279725", "a30049c1-6eab-4d7c-8c86-597249f745a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38559257-11ef-462a-8290-4fcca125de2e", "c2b3f417-70ce-4cfb-a282-38f002e60e60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33042e03-939d-48e4-98ee-4a4e2e1ba1ca", "1b0ca783-23a7-4921-b9df-fe28543a9c9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79020267-f55c-46cf-95b2-cc19e04b918b", "33819466-4651-4d03-877a-e9bdc8a25d7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b10a590-7b07-44db-ac9f-6c2615d218fe", "62eb4087-8656-439f-82fc-2f99c6ab7de4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56e7edf2-8449-4982-a314-e087140794ae", "3e63d296-496d-4319-a18d-2f0b237cacb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "493ffa13-821d-4268-a578-56980f633fff", "c25ff754-6c24-4273-8c81-2c393c95995a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9326fbb-3064-4c1f-a63d-09e4edf94184", "f2f8d211-6391-4e44-9710-67fdfa536c26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49e164a0-94ae-42ca-bc88-cdc96f1fc778", "37cfd1bd-0608-4c97-b203-59117588c92f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "466a8515-1ac8-4bbe-a956-f1cddb90ddb7", "43f63e4b-c762-4f77-a206-e2d7d137883f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c2afa671-b9df-486b-bbd0-9a43e7958439", "22866f84-8a48-47b4-93cb-08ecfa614c91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8f7198f-60ac-4544-97b0-d77d30bebafb", "7851d060-8d6c-472e-9752-8be3867b49f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c072ef56-7de2-4ae2-a7a7-be75f96b964d", "e087892d-976a-4e88-a8c9-78834ecc01de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f36eee47-b09e-4b45-907a-729ce8c3e32c", "9376c25b-87a8-4429-973c-ce27d625ac42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86819de4-b8d9-4b5b-96b4-b3ddbf807156", "66f659a5-6cfa-4439-a775-4e579cb6aac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "538881f1-454c-403e-ba5c-8ae90f41f11d", "ffad3bfe-251b-4bad-be7a-e280585cd20a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74c36412-0c65-44fd-8688-02e33b52f7c7", "491184e9-0e01-4c3b-a925-d650ee417987" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f085d533-f8c2-4b81-9cdd-0bfee654cdba", "a50b6a38-0896-4e92-bf02-956585b99674" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "942754d2-d67d-452b-8f88-1d88703b9242", "29426846-f04b-4d6a-881f-ac4eccda31df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa97bdd2-a7ab-47f3-911b-c89eadcb572b", "3d28bf5d-2116-41db-b5ad-55447e7f53ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a027374-9ebf-4833-a92d-28f30cb9426e", "1a8a2ab1-b467-4860-af69-8adc2f2ba27d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d6b214a-6b93-42df-982d-cb518f4582f8", "5ff63c45-019e-42f2-bfe9-8cbfeab55d19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4732ae03-4d9d-4786-b1f2-b1dc55044258", "2c5459e0-fcc4-4d24-94c6-39f5ffec197a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c25933f-d919-4028-90cf-eb79b6c496ed", "e4b8af36-0aee-4f6a-84c1-a8e61c45c10b" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 27, 19, 35, 11, 79, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 8, 2, 17, 47, 41, 124, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 2, 22, 54, 46, 879, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 16, 14, 47, 8, 644, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 8, 5, 20, 19, 2, 278, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 27, 18, 57, 55, 123, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 18, 43, 32, 568, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 5, 2, 12, 40, 19, 427, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 9, 6, 22, 24, 12, 268, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 5, 8, 20, 35, 21, 315, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 14, 11, 19, 54, 147, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 17, 20, 32, 53, 545, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 7, 29, 10, 53, 26, 872, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 17, 15, 26, 13, 481, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 13, 15, 31, 3, 92, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 15, 17, 41, 51, 122, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 26, 20, 38, 25, 293, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2020, 1, 9, 19, 48, 28, 145, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 21, 17, 18, 2, 777, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 5, 3, 0, 2, 11, 762, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 6, 3, 20, 47, 8, 645, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 11, 29, 22, 23, 44, 918, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 24, 10, 9, 14, 340, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 4, 12, 11, 6, 24, 975, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 14, 17, 54, 3, 221, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 13, 13, 29, 44, 619, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 26, 15, 36, 11, 871, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 13, 17, 13, 7, 35, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2020, 1, 3, 10, 29, 3, 174, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 4, 3, 10, 11, 50, 223, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 4, 2, 6, 21, 19, 528, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 8, 6, 21, 16, 17, 261, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 25, 5, 25, 57, 380, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 12, 9, 14, 26, 35, 972, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 6, 10, 10, 44, 20, 507, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 19, 22, 32, 35, 73, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 10, 1, 2, 11, 59, 54, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 8, 2, 20, 32, 11, 703, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 12, 7, 1, 9, 56, 857, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 13, 1, 6, 6, 305, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 20, 13, 37, 52, 48, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 3, 8, 4, 40, 8, 414, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 26, 13, 21, 56, 623, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 4, 3, 19, 34, 45, 486, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 7, 7, 5, 38, 22, 901, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 23, 19, 52, 23, 914, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 12, 6, 4, 49, 17, 790, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 4, 11, 20, 6, 45, 606, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 9, 8, 7, 56, 20, 634, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 9, 28, 13, 29, 25, 51, DateTimeKind.Local).AddTicks(4352));
        }
    }
}
