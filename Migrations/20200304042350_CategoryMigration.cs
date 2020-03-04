using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DotNetCoreReactREST.Migrations
{
    public partial class CategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Stet sit Category");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 2, "Sed justo exerci takimata nulla labore nonumy autem eirmod no", "Aliquam consectetuer Category" },
                    { 3, "Sed justo exerci takimata nulla labore nonumy autem eirmod no", "Et amet Category" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 4, 12, 23, 50, 55, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "DateTime", "Title" },
                values: new object[] { "Sea ullamcorper dolores tempor aliquyam sit sed diam elitr sed. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam", new DateTime(2020, 3, 4, 12, 26, 50, 55, DateTimeKind.Local).AddTicks(5778), "Vero ipsum kasd in dolor" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "DateTime", "Title" },
                values: new object[] { "Nihil cum sit sanctus zzril. Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam", new DateTime(2020, 3, 4, 12, 29, 50, 55, DateTimeKind.Local).AddTicks(5879), "Eos dolores suscipit consetetur dolores sadipscing eos lorem" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Sample Category");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 2, 29, 13, 40, 5, 730, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "DateTime", "Title" },
                values: new object[] { "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam", new DateTime(2020, 2, 29, 13, 43, 5, 731, DateTimeKind.Local).AddTicks(1603), "Autem nibh nulla nonumy lorem" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "DateTime", "Title" },
                values: new object[] { "Consetetur ut lorem lorem imperdiet et nisl eos takimata te diam", new DateTime(2020, 2, 29, 13, 46, 5, 731, DateTimeKind.Local).AddTicks(1703), "Autem nibh nulla nonumy lorem" });
        }
    }
}
