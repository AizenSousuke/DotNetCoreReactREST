using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLiked",
                table: "Likes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c668841-5175-42a8-a677-eb76b6895f48", "fb613f38-326d-43a6-b998-01010404491a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1885c7d6-69fa-4ec6-bdb3-7791e8400c63", "150b6fae-0a96-40a0-ae63-c7225607e875" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 6, 53, 784, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 9, 53, 787, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 52, 53, 787, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 5, 32, 53, 787, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 5, 2, 53, 787, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 52, 53, 787, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 42, 53, 787, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 32, 53, 787, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 22, 53, 787, DateTimeKind.Local).AddTicks(4686));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLiked",
                table: "Likes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10ed7375-01d1-438a-98ca-f9bf8c1acbd4", "87ba8547-afed-476e-bfba-439b547e44a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03b162b6-0bf3-4bb8-ae84-9837f3106e3c", "5caf945f-afcd-4f4a-87d6-c236e6f6ced1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 43, 31, 251, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 46, 31, 253, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 29, 31, 253, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 5, 9, 31, 253, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 39, 31, 253, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 29, 31, 253, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 19, 31, 253, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 4, 9, 31, 253, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 3, 59, 31, 253, DateTimeKind.Local).AddTicks(9954));
        }
    }
}
