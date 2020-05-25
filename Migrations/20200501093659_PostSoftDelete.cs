using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class PostSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Posts",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Posts");

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
    }
}
