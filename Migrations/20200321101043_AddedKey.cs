using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class AddedKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22bfd92b-72ea-4b87-8585-6eb3b79ffe44", "afc2116b-7829-4b2f-a5cc-decea002e691" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33b1c6a5-ee60-4f06-88e3-48ff4379aef4", "94d15c94-ec1c-44e5-b040-bc62f5beda2a" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 18, 10, 43, 308, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 18, 13, 43, 308, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 18, 56, 43, 308, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 19, 36, 43, 308, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 19, 6, 43, 308, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 18, 56, 43, 308, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 18, 46, 43, 308, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 18, 36, 43, 308, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 18, 26, 43, 308, DateTimeKind.Local).AddTicks(5840));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b0b0657-095a-424f-9689-6267b7d04ab1", "36e4c6ca-3a85-4852-bf50-989ffce1b031" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0abb7c5-219f-4d50-9ab3-40f7c76c94fe", "fe5a2ab1-28dc-4268-b740-2a924e238350" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 16, 1, 56, 123, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 16, 4, 56, 124, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 16, 47, 56, 124, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 17, 27, 56, 124, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 16, 57, 56, 124, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 16, 47, 56, 124, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 16, 37, 56, 124, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 16, 27, 56, 124, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 16, 17, 56, 124, DateTimeKind.Local).AddTicks(3398));
        }
    }
}
