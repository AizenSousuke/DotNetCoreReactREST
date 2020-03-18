using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class addedComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dda94582-9a74-42ff-a0a4-5e9e5c8efc55", "9198f46b-ac4c-4de1-b6b5-f182499fe218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36d7e544-44d2-4f28-894f-df520ed185de", "b930f51a-b5d2-4081-9416-2c0150a11674" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "DateTime", "IsAnonymous", "PostId" },
                values: new object[] { 3, "1", "Cool Beans!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 13, 0, 40, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 16, 0, 42, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 59, 0, 42, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 39, 0, 42, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 9, 0, 42, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 59, 0, 42, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 49, 0, 42, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 39, 0, 42, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 29, 0, 42, DateTimeKind.Local).AddTicks(6982));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bb9df3c-a786-4285-93a5-9fc13569bd5f", "f6240ce8-55cc-44b3-aebc-0f4eccbfca5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "849dc3ab-acbc-4653-a7d8-5204f3b6f7fb", "730e3474-e093-4d4b-ba06-d0e88dc9af8c" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 2, 16, 32, 876, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 2, 19, 32, 880, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 2, 32, 880, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 42, 32, 880, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 12, 32, 880, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 2, 32, 880, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 2, 52, 32, 880, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 2, 42, 32, 880, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 2, 32, 32, 880, DateTimeKind.Local).AddTicks(2582));
        }
    }
}
