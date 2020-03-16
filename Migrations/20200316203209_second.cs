using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1a1818d-6342-4cd5-be36-6de660fa0a3a", "48c0b81f-fc68-4d07-adc3-cb3739047409" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ff4ced5-1446-4b32-bcbe-7e65cca45d14", "77b03375-059c-416e-a1b0-973969d56c86" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 32, 8, 968, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 35, 8, 971, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 18, 8, 971, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 58, 8, 971, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 28, 8, 971, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 18, 8, 971, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 8, 8, 971, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 58, 8, 971, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 48, 8, 971, DateTimeKind.Local).AddTicks(5937));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4cf14146-5947-487e-8868-55a6d506c025", "f17eea44-f7d8-4007-a3b1-3e0fd730ef75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af0108a7-be05-4372-858c-7f7ef3ce4789", "749c8f01-088e-4053-bd2c-0d90392bc645" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 25, 30, 491, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 28, 30, 494, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 11, 30, 494, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 51, 30, 494, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 21, 30, 494, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 11, 30, 494, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 1, 30, 494, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 51, 30, 494, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 41, 30, 494, DateTimeKind.Local).AddTicks(3247));
        }
    }
}
