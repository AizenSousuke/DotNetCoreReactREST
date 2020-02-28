using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Sed justo exerci takimata nulla labore nonumy autem eirmod no", "Sample Category" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApplicationUserId", "ApplicationUserId1", "CategoryId", "Content", "DateTime", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, 0, null, 1, "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam", new DateTime(2020, 2, 28, 23, 28, 0, 35, DateTimeKind.Local).AddTicks(8093), null, null, "Autem nibh nulla nonumy lorem" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApplicationUserId", "ApplicationUserId1", "CategoryId", "Content", "DateTime", "Description", "ImageUrl", "Title" },
                values: new object[] { 2, 0, null, 1, "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam", new DateTime(2020, 2, 28, 23, 31, 0, 36, DateTimeKind.Local).AddTicks(4666), null, null, "Autem nibh nulla nonumy lorem" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApplicationUserId", "ApplicationUserId1", "CategoryId", "Content", "DateTime", "Description", "ImageUrl", "Title" },
                values: new object[] { 3, 0, null, 1, "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam", new DateTime(2020, 2, 28, 23, 34, 0, 36, DateTimeKind.Local).AddTicks(4764), null, null, "Autem nibh nulla nonumy lorem" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
