using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class RemovedVoteClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "DateTime",
                value: new DateTime(2020, 2, 29, 13, 43, 5, 731, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 2, 29, 13, 46, 5, 731, DateTimeKind.Local).AddTicks(1703));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 2, 28, 18, 18, 28, 577, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 2, 28, 18, 21, 28, 581, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 2, 28, 18, 24, 28, 582, DateTimeKind.Local).AddTicks(86));
        }
    }
}
