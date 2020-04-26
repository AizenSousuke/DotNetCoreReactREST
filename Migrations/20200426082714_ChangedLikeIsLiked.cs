using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class ChangedLikeIsLiked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLikes_AspNetUsers_ApplicationUserId",
                table: "PostLikes");

            migrationBuilder.DropIndex(
                name: "IX_PostLikes_ApplicationUserId",
                table: "PostLikes");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "PostLikes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
                values: new object[] { "99eb15af-5ef7-4670-b5e9-6790b9eef2aa", "be38fdad-7acf-4de1-b0ba-9bb59be4e365" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "895f1e2e-a38a-456c-976d-50380a3f74aa", "0c57c7b6-b407-447d-afef-1db4a2a0aaa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3122ae9-3734-4222-a59a-d206474a9778", "b9124fc5-e21b-4de8-be1c-022d0b0ade59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25c6f5ee-d1f1-4b6c-8a37-a8c7d4187d8e", "c9c4e844-c2ba-4c76-bd25-5251c4316624" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94daa29b-bb1e-4b76-ac3a-74649b5409ad", "70d9b5b5-b871-4c7a-9d67-9b23d315c948" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9b83808-681b-45b2-a572-6d290de40dd5", "5229edb4-27e4-4ed9-89d9-2392e8da7c5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c69920f-7a82-4a14-a6e8-d4d60231f423", "79dfebb6-006e-47fa-9361-05b778c4ba8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b288aac-f930-473a-b764-7320c925576f", "5ad6302a-7779-425c-9137-1433b801e230" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc7d40b9-55f1-4602-a623-e25e5b2dafb6", "050f470d-f47c-42f8-b481-56c3bb3584d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "05f793f5-4296-4fb1-b8ad-2f4c44e784a5", "cd439a8a-1514-472c-9e22-ba1e34a5cbab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb26ceaf-e438-4624-87fe-0d91532d0715", "d4d7fa57-7017-423f-bd52-25873ca64c12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ad1301b-233d-441f-95de-e38d4031656b", "70f04a63-91dc-442c-b29c-6b7e774d0866" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fa9df00-c349-43d9-bca5-de5a70dcea7e", "ea550583-7555-4c34-80f4-d4cd7b07aca7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d42b2a9f-a65d-44c4-ae09-b53e39e0d53b", "e9f2f7db-e61f-48a4-b3f4-7e44b77ed1a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75942c1e-55ef-4695-afac-c0a7cbedb53b", "69bd2548-3a63-4892-880a-32f4f28b90fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4f11b17-e35b-4ac2-8652-402297be6b66", "0c10c817-3ae8-4d5c-b9f7-830dc548ff3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a6d393d-311e-4828-9d0d-d68fca3e9667", "16b73ba6-f5f2-4138-9723-1f264a55a2c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "574e6a12-f4ed-47d5-9742-f7c53d36771c", "a8036996-ca0e-4e69-800f-07b2ac121be8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d232ab98-ab13-4a01-b028-910bfd225b51", "a9ec5f14-2a2e-43fc-b3d4-24e55cc5fdb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bb25e46-f6cd-4df3-9aa6-4dafd18aca0c", "96b7bcaf-b767-49d5-ab3d-15f2eadf4599" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9921985c-b52a-49a9-a6e5-d54ae76e9f91", "339ad2c9-dc5f-4460-9e49-a801e94c92b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9e75189-3cf2-4544-af61-b03ef13f82f2", "035298fb-0793-4cdd-b7bd-1cbd0dd5da12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14785994-d0ea-42ab-b416-5fd46de44df2", "94ce8381-815f-42be-ab6c-499504682094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6087a75-8cbb-4274-b6e2-83d09df5a975", "6036cd85-2dfa-44ec-b53d-803ad23219bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e991d888-2cab-41cf-9bb5-39c2a49ab25c", "a7647a4e-6fee-4a27-b8e1-fbfaac810ae7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d15a708-d70d-4a42-b6e9-fcf34890311c", "f77eec62-eab8-480c-8e87-b8100f39f595" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4acb7427-6c54-4b71-abd6-292152a4f9fb", "9a20614b-4d45-4f01-9b30-510b6baeeea4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f00389a7-8380-4aa1-ae4c-fd8341de13cf", "42670836-9859-4de0-b53f-ff406c2a3229" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce94aeaf-191c-4752-b543-3434dd61689e", "4766ff55-6fda-41ff-aa1d-f6fe43206703" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a36f6844-0d17-4f5b-b328-83cdaf7186c1", "44893d4a-e436-49e0-8c7a-227f6444aa66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa21b80f-7cee-4d2b-8036-e1f8849ec232", "f93b9562-aee9-484d-bfda-362f636ce85b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "172ae0ce-c53d-4de3-8426-6add398898d5", "332e3b33-b1bc-4599-bea0-e223b2f79218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f7dec73-aaa9-48e1-b718-5b4f7181b1cd", "e6fd40af-35d2-4d7b-8877-d82ae262b371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee1e3f66-c130-4dbd-9b96-a7965aee6570", "f58c7994-d564-4db5-931c-22038855a165" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d000823e-ec33-4769-949e-417834e4748e", "9014c447-23e0-43ef-aac0-1aafe60b7fc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f651fea7-82ab-4201-8962-6dbb451d6b3e", "8f430101-39c3-4959-a3e4-4c31ebe4465b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86c6c807-d02e-4835-a27e-c63ffe6f687d", "da898fc1-59d3-465f-a86b-1e6fe9e53bf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df4235f1-6f37-4f79-8f43-3a6c034294b1", "9987396f-9010-4a36-a496-674313d691df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "accab9c5-a7da-4459-a315-e89e53e4428b", "2eb1436f-0e94-4da8-bac3-95a5daa209f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34017828-be45-4c79-aa13-80c7d929ccfd", "cc6df521-13bf-42b5-81e0-8344b34bac28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "009d5ebe-9b9e-4a6c-a9ee-fc359799a736", "811122b7-987b-437a-8496-813cd04fafa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee948584-0671-4d9c-b009-ac301977b121", "c1dd65da-0c7a-45b6-98bf-648c02c764d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecff01f3-41d9-4c75-8b38-f82c88d01ee2", "06e3dee3-bc09-48ff-8ee6-076e015ce66b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dfe5755e-c37c-4fda-9e50-c6e9fe39a92d", "aac51faa-a488-48ee-8b67-ba25bef50036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b469045-5608-488d-9fec-51036447fa91", "037ff203-4126-4c39-bd7b-998c036930f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4839211-c2df-467d-b66b-b3e87ea6ad63", "0ce87742-5cc8-4a7f-81c1-82ff01a51630" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3650af94-3c96-4ab4-b6e0-943b1865bd41", "718593ba-c868-47d9-b992-c3e92d7084ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5314a7f-61c3-4d6f-ac97-ff90dc436601", "430de590-26e9-4242-8796-952cde0c94a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "899ab852-3364-4742-8a39-77172c624c3d", "e544a890-a6d2-444f-8a60-f1f27b11e928" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "537eebdc-3be2-4d1f-919e-637479e59df4", "ec3f0a37-c6b9-4f38-add0-4eeae8cc971f" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 26, 15, 41, 17, 884, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 8, 1, 13, 53, 47, 929, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 1, 19, 0, 53, 684, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 15, 10, 53, 15, 449, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 8, 4, 16, 25, 9, 83, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 26, 15, 4, 1, 929, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 17, 14, 49, 39, 373, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 5, 1, 8, 46, 26, 232, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 9, 5, 18, 30, 19, 73, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 5, 7, 16, 41, 28, 121, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 13, 7, 26, 0, 953, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 16, 16, 39, 0, 351, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 7, 28, 6, 59, 33, 677, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 16, 11, 32, 20, 286, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 12, 11, 37, 9, 897, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 14, 13, 47, 57, 927, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 25, 16, 44, 32, 99, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2020, 1, 8, 15, 54, 34, 950, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 20, 13, 24, 9, 582, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 5, 1, 20, 8, 18, 567, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 6, 2, 16, 53, 15, 450, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 11, 28, 18, 29, 51, 724, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 23, 6, 15, 21, 146, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 4, 11, 7, 12, 31, 780, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 13, 14, 0, 10, 26, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 12, 9, 35, 51, 424, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 25, 11, 42, 18, 676, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 12, 13, 19, 13, 840, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2020, 1, 2, 6, 35, 9, 979, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 4, 2, 6, 17, 57, 28, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 4, 1, 2, 27, 26, 333, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 8, 5, 17, 22, 24, 66, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 24, 1, 32, 4, 185, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 12, 8, 10, 32, 42, 778, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 6, 9, 6, 50, 27, 313, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 18, 38, 41, 878, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 9, 29, 22, 18, 5, 859, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 8, 1, 16, 38, 18, 508, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 12, 5, 21, 16, 3, 663, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 11, 21, 12, 13, 110, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 19, 9, 43, 58, 853, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 3, 7, 0, 46, 15, 220, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 25, 9, 28, 3, 428, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 4, 2, 15, 40, 52, 291, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 7, 6, 1, 44, 29, 707, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 22, 15, 58, 30, 719, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 12, 5, 0, 55, 24, 596, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 4, 10, 16, 12, 52, 411, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 9, 7, 4, 2, 27, 439, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 9, 27, 9, 35, 31, 856, DateTimeKind.Local).AddTicks(6814));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLiked",
                table: "Likes");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "PostLikes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "331588e0-dc9c-4a33-b24d-4736b9a7b8a0", "38b462ba-e376-4d61-a943-a3b899079219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2bc3209d-f286-48bc-b4db-e1fcd3840e50", "e16410e4-f5ec-46cf-94f8-cdf103339173" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e92c736-1db8-4137-b351-1d74c4c9de82", "3c6848b0-029b-4bd2-9aeb-61409e19a84e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbd011e6-b02c-4919-88a9-a2530e269ad9", "0fec172d-6a3c-41c4-ac76-4e3b31c678f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3cab878a-ff71-4a4a-abcf-3cf4fca5d695", "bc97b9f7-7153-400e-902a-115ceffd9b59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5898c6de-2f1f-4cdb-979a-2628c4964629", "fad98867-b2c2-4fb5-a6e2-ac4c80ffc739" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4df86b39-d1df-464e-93ef-bb554661816e", "3728edf0-12ad-46ab-88e0-7b72466b4a45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d50b79c-7f9d-4645-9544-750d3079d24e", "c01b33e9-43c4-4ce9-a9a9-72ea3456bd60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc2f0692-d3f9-4db7-9b01-666dbab2b6b7", "64da748b-89e3-4ef0-b58c-9241f136fba1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11077021-d975-48f1-89ec-eefccef9a432", "7273b00e-776f-4d9b-a20d-3d1ee47cf1e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "201e7c38-b1c3-4e79-99b0-28ac7327b0fb", "e899c043-df72-4da7-bf3d-9d9b02f3192b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c52c5806-9860-48d6-8bee-7831ce27033e", "57779cf5-0fe5-4a4c-8ee5-22a4e903de1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62b5397d-c888-4395-8274-0f5e9747b465", "a39795eb-9d67-44fd-901b-08bc67da5bd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db143893-e676-4cf2-83c8-7ec7c4380112", "e2603f1a-6126-4563-9be9-033632b99f66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0a632a8-e123-4925-b797-f40cb61af899", "76082787-f9e1-4fd1-bb24-d04d48b40aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43cb92d4-df14-4143-8dcc-71f87a8b9ecc", "8b35ad28-b8b9-4b28-a78b-27790db9f71e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6535e761-e42c-4c31-8207-5c431c02db61", "6b030686-4575-45b2-a2f7-d8e1c4c95d9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8995c5ec-3665-40cd-8a4e-99dd549f2c3f", "3ca0ceef-8481-492f-b33d-4827d947f9aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b388505-305b-414a-a1c2-aa0ecb8bf967", "d5edddf2-f0b0-4df8-a6c1-6398e615831c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fc98791-770f-44c0-91ea-7f727814d748", "e4594e2a-bff5-44fd-af63-2ee6c879921d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5a76f85-9c86-44eb-b577-2c84283d1d65", "9e020e5f-a0dc-4f63-8e9f-99a099d27f04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "011539b4-1d08-44fb-9829-09e0b41e496f", "ef13ecda-21a1-4d2b-8962-f77888b63c0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da7b301b-8abc-4350-8393-ed8e833172c9", "0a1c93ed-a69c-48a8-8aba-1ea4d7a4ddb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dccaf218-7465-4521-bc9c-02509044d778", "4f8c74a0-a600-4c2c-82b6-07c0bc408c12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c330964-5d8d-412c-aa3b-e4c92a491972", "eb3f69ec-366c-4723-95f0-976163652b95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84ae7770-6ba4-4855-acde-521200643122", "0b98953c-5c43-45c6-b46f-e36abd776759" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67643580-a913-4c77-9318-07ae13fa9fcf", "521204d6-ea1a-4a01-a978-e31564abda69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "120db724-017d-427b-b777-14213996cdfb", "c66cf4d9-527c-4b54-bc30-c553647c0a8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d28efa26-ac48-469c-9979-46c61920b3e3", "f98818b8-c2ca-4d10-81ff-fe4a6858f1ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14c43a15-56b8-41f1-8765-441cd15ea75b", "c75348e5-f43b-45ba-a370-4556bd77545e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81b4d567-9089-49ba-a249-4978eb810adb", "5ff2cd46-cec7-40a8-bfa6-53f5d6766b5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "495b49d9-dbf2-4ce5-a801-8bbabf97fe39", "bb4dc1a0-8301-44ff-89c8-b97f6cb4fa18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9acb41b7-70df-45c6-9c7f-1262e29da257", "c7d1ba86-1ac7-45c5-9348-5dd46024dfb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9ff4b3c-1dd9-4646-80c1-16f1588d7c44", "cf4671ea-0a3a-4cc5-b703-7689de3bb03c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3380b55e-26d0-4d03-9410-f6d885ce406e", "35f971d3-8db0-4aac-9765-2da257f69d8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f75e7349-b011-406f-8d92-b836abe37076", "3832dbdd-96bd-4a35-810d-779c8f924484" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76ff2216-2770-4096-964d-82df735f5c4d", "32971bac-4261-4a1c-86b3-13d74a4c3927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2065c3be-7569-4849-831b-998b8bc7fc09", "92f48145-2c17-4a5b-a749-e828c46a2474" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "975b9fd9-41cd-499d-901a-ee3eb715c1dc", "5381d076-567a-4be5-9e25-1dfca06daf7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "835ed446-1176-4971-819f-b4ccf65d0420", "b00cccc2-f4c9-43dd-891c-330042b4f577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa040a29-3aac-40dd-acc2-d32ead43ceb2", "9820b4a2-28cb-4a9b-8262-65c4584078be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a702f704-62b7-440d-9703-bc0b4d4c4029", "e32c4e1b-ad14-41d6-9c7e-e30003717832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f9903e5-1fac-4ef5-9eaf-b93ce4457ca5", "d84878a1-4860-4f14-b309-2d5a34f6ad23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07409299-8296-4fbe-a427-ad98ba3810fb", "78067c27-de00-4478-a2f0-ea1f5edb3149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "969c5b98-a546-415d-80f7-c50c105d6668", "7b722767-7a07-4ea9-8c01-e1335148b4d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "988343c7-19f0-4ce3-ac8d-9cd8ee898d3d", "89848f30-a22c-40e3-8e17-b71eb74999c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c41d127c-edd9-459f-9761-f411da72aa06", "6bc524c9-49e7-480e-8295-3adaf9e02ce7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bff0914d-aaf0-4465-9350-8fbe88134e82", "643cd122-cfb6-40f8-9d75-132b75979087" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ef5bbdb-6348-429e-83ae-66df739b0fd9", "70ff9bc9-8ff6-4a3c-b618-d2d2b3232ddc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f31141d-81eb-4d76-8c94-d108ad80c843", "6a2cdded-fe60-4ece-812f-334ac3ca3266" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 15, 23, 10, 53, 853, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 7, 21, 21, 23, 23, 898, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 2, 20, 2, 30, 29, 653, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 4, 18, 22, 51, 418, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 7, 24, 23, 54, 45, 52, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 15, 22, 33, 37, 898, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 6, 22, 19, 15, 342, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 4, 20, 16, 16, 2, 201, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 8, 26, 1, 59, 55, 42, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 4, 27, 0, 11, 4, 90, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 2, 14, 55, 36, 922, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 6, 0, 8, 36, 320, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 7, 17, 14, 29, 9, 646, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 5, 19, 1, 56, 255, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 1, 19, 6, 45, 866, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 3, 21, 17, 33, 896, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 15, 0, 14, 8, 68, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2019, 12, 28, 23, 24, 10, 919, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 9, 20, 53, 45, 551, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 4, 21, 3, 37, 54, 536, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 5, 23, 0, 22, 51, 419, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 11, 18, 1, 59, 27, 693, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 12, 13, 44, 57, 115, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 3, 31, 14, 42, 7, 749, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 2, 21, 29, 45, 995, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 1, 17, 5, 27, 393, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 14, 19, 11, 54, 645, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 1, 20, 48, 49, 809, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2019, 12, 22, 14, 4, 45, 948, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 3, 22, 13, 47, 32, 997, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 3, 21, 9, 57, 2, 302, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 7, 26, 0, 52, 0, 35, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 13, 9, 1, 40, 154, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 11, 27, 18, 2, 18, 747, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 5, 29, 14, 20, 3, 282, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 8, 2, 8, 17, 847, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 9, 19, 5, 47, 41, 828, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 7, 22, 0, 7, 54, 477, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 11, 25, 4, 45, 39, 632, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 1, 4, 41, 49, 79, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 8, 17, 13, 34, 822, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 2, 25, 8, 15, 51, 189, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 14, 16, 57, 39, 397, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 3, 22, 23, 10, 28, 260, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 6, 25, 9, 14, 5, 676, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 11, 23, 28, 6, 688, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 11, 24, 8, 25, 0, 565, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 3, 30, 23, 42, 28, 380, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 8, 27, 11, 32, 3, 408, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 9, 16, 17, 5, 7, 825, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_ApplicationUserId",
                table: "PostLikes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostLikes_AspNetUsers_ApplicationUserId",
                table: "PostLikes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
