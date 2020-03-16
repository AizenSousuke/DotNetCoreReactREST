using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class cascadeDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fbb3ab3-5d02-41d8-94dd-5d7c81b89e8f", "fd9d46b8-293f-4c61-a5b5-d0c857129f4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c646c47-2cac-489b-8f1e-e36f8e753b1c", "8eb9d649-7b82-4a98-8619-018d1b2a55de" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 37, 13, 286, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 40, 13, 289, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 23, 13, 289, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 18, 3, 13, 289, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 33, 13, 289, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 23, 13, 289, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 13, 13, 289, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 17, 3, 13, 289, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 16, 16, 53, 13, 289, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
