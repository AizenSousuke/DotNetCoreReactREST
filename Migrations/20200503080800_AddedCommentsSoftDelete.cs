using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class AddedCommentsSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Comments");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c29df0c-7c93-4614-9034-6be4354abdc7", "fc30ce58-20d3-4a6d-9ee5-9b4d9fdd898a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39e6b319-cf6b-4bb0-821a-5b5c2b1694f7", "a55e2fb4-a505-497e-b660-b545862c937a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d4e38b5-b8ff-483a-97b2-1b985b576979", "f9505bd5-d962-4bfb-be0e-ef56340c7bad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "244f9122-ce5f-4e52-9ef5-bb2fc328872b", "289c9314-d84d-41ed-ac10-d07817c43965" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "870fe9a8-3a01-4382-b776-9d584c396c3f", "4b750dd4-e5b1-420f-ae46-60ce05a5f0f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "546a39ff-c4f7-4a25-8c8b-67694f043b74", "2a8c87c3-0da9-4b41-81f4-30ef1e0cbfae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bf41c15-349a-473b-adc9-0ce30af79ca7", "2f8e203a-4b8f-4e4d-9638-057213df1172" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70b2195a-fe4e-457a-a4b3-2933991144fa", "2938d450-63f3-4871-a1a5-3dfa16e36b1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48a234dd-e6b2-463b-a005-8520c1d0832d", "50e8e557-1de4-4af9-9b2b-db9b84c7e242" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4007cfd9-497b-433d-a6e2-675b623b15cd", "b8fd95fa-085c-4a9a-a74f-9f7c967ef1ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c011ef63-35a8-4816-a21c-9de654097fbc", "0547142e-0974-4a62-8d91-d67f4264bbe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5a7e317-6ca5-434d-8b94-908d6325a8b6", "a31e1ee5-7853-469b-8fb2-9a7a1fdf45d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83fcba7a-13db-4614-8aea-fe19d9baaf7b", "fb9f8caa-b581-4e3e-803d-950c8094a350" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08b248cc-8d83-4213-a202-9ee9fa44031e", "a3ab9ee2-e28a-4548-a3b6-f7fb9ac7f145" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b96bd95-acc0-4bf8-be99-ae81eeee6a05", "1e3db345-33d7-46f7-8678-2aebc4b8a3ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07892eed-fd1c-4756-9e14-1cd51a615051", "1433caf4-7703-45e1-9b11-22371b69e861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89f19073-8508-4727-87d4-42e7f3dee4f2", "b08331c1-b129-478d-9c19-c846257b3f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa7d382a-2e38-41e8-9b7f-053d0b415909", "3390541d-1440-4877-8aed-ba32556e21f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49652e9b-60b4-43f6-96f0-4372bd2ac3b2", "03736c4f-bdc5-42a8-a4e7-499fe7c3b375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55aa8a0a-ef29-44a0-8270-1377de60adaa", "48a9a06a-7f51-45e4-a293-dbe0c554f044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df839d12-d3f9-43bb-84d6-5a6df3eefc05", "af85bdc4-b7eb-487f-ae88-900a51db3c8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec6ac52c-ed24-4082-84ed-3ff39a24a20e", "5a1019fb-606c-4442-bd8c-98b530ef5e61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f369958f-100b-4939-88b1-725f5f46c3fd", "9032a3ad-0768-4c86-8ddb-b121d3e630c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa06a4de-ee34-4a59-a555-eb88b0270e2b", "4a51569f-4608-44f6-95e5-b7c44c03fd34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "482d66b1-9e7e-4bbe-9c1c-b440dce5bc90", "561ae3e6-8888-4272-9b70-02a20ed1881c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44271542-fbf6-441f-8640-3151d5eed694", "c16fd16f-8866-427d-9a47-405e636514c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d256249-2728-4b93-86eb-887d8e369555", "9d6a69fe-e272-495d-abfd-dcad38cdd746" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c17f826-b157-4d8f-8577-be9f60b6feea", "3021c8f5-fa24-4c21-b360-9654b8495dc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7eb84980-b5e9-4e69-81c8-4403f3e44441", "f167c92f-9499-4019-9897-4e576e07de84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24d4ed82-af5a-462c-a421-c474996c63f5", "602275b9-f9bc-421b-bb31-4f65b9701682" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecdcb1b1-0ca0-4a90-a504-1f6669c94da3", "5235a92e-6f74-40be-b737-3fe23d3d037c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbb11cf9-3b0c-42e5-87b9-566517955bb1", "8c5cc2b4-c36d-4f6f-ae87-5881abe6e377" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e338e224-bc39-4bee-8b74-1f81b1d6da99", "19ba4277-baf2-4793-86a2-d1bb73183516" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a064fb63-7ada-414a-b495-b642bee27767", "4959a6f9-0d7c-42a4-b7e0-da818b52a4d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08e166a8-0ed6-42f9-947f-3b02298b23a0", "f21f423f-89d7-4e0f-a4ad-7a7929064eed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed806a84-f60d-4007-859e-aa3ac4da3a2e", "543b65f0-7e4e-4a7d-83cd-617abdddb88b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37aa3b1b-d4f3-472f-87f6-616d9772df55", "c6910340-31fe-4796-a68b-7bc2b8856dff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9c710cf-af0e-4ff9-9bd9-ec1d1ce0fcc4", "cbe21bce-d682-44fd-bbc1-242efac04762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28bbc8d7-d8eb-4c81-a580-88cd37da041a", "7a5e761b-f7e8-4e68-83dc-fdc7121cc95c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ef6b00d-c78e-492e-b877-e1d3482d6383", "f09c9864-f686-47f8-8b4c-d91e5785cfa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "468a8343-21fa-47e8-96e3-661e0b460b4d", "98343c1c-80e0-4575-b7ad-508a1b23030c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "581b4995-0551-41c0-a784-ff40457dfb28", "95e8e9da-98ae-4ae4-b1e5-e760265009a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ba639c5-e7b8-430d-875e-040674c6b294", "298439ec-259c-4555-92c5-47b255ab9e87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f9c16be-6fcd-4b43-b2f4-2e67775d4262", "fa3e008b-89ff-4522-87e7-fc3a6b82a8d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f68ee74-8550-45ff-8109-3c3ce6766213", "4da35d85-ba6d-4919-b63f-3d5cce813b7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "adbb8f92-5cb8-4683-970a-2b7958c649b9", "4d5deabe-67f7-440d-82ca-3cde8b23538a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "284b719a-5752-4176-a803-aac8e95c4c27", "53feb52a-0559-4b31-85f3-a0641f42f16f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fe6f36e-8b54-4fca-94be-25411257e557", "b5baad7d-9309-4639-bd35-7130ab05c940" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7019795b-5982-4c38-8951-f97da4612580", "c925a1c1-8563-40d6-84e6-baa9c85997a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f16bba4e-0b04-48d9-bbf2-6c1dee4042be", "f047cada-f545-4878-95db-5454fe2670e6" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 2, 2, 15, 22, 3, 734, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 8, 8, 13, 34, 33, 780, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 8, 18, 41, 39, 534, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 22, 10, 34, 1, 299, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 8, 11, 16, 5, 54, 934, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 9, 2, 14, 44, 47, 779, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 24, 14, 30, 25, 223, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 5, 8, 8, 27, 12, 83, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 9, 12, 18, 11, 4, 924, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 5, 14, 16, 22, 13, 971, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 20, 7, 6, 46, 803, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 23, 16, 19, 46, 201, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 8, 4, 6, 40, 19, 527, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 23, 11, 13, 6, 136, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 19, 11, 17, 55, 747, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 21, 13, 28, 43, 778, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 8, 1, 16, 25, 17, 949, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2020, 1, 15, 15, 35, 20, 800, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 27, 13, 4, 55, 433, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 5, 8, 19, 49, 4, 417, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 6, 9, 16, 34, 1, 300, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 12, 5, 18, 10, 37, 574, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 30, 5, 56, 6, 996, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 4, 18, 6, 53, 17, 630, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 20, 13, 40, 55, 877, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 19, 9, 16, 37, 274, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 9, 1, 11, 23, 4, 527, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 19, 12, 59, 59, 691, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2020, 1, 9, 6, 15, 55, 829, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 4, 9, 5, 58, 42, 878, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 4, 8, 2, 8, 12, 183, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 8, 12, 17, 3, 9, 916, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 31, 1, 12, 50, 35, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 12, 15, 10, 13, 28, 628, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 6, 16, 6, 31, 13, 163, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 25, 18, 19, 27, 729, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 10, 6, 21, 58, 51, 709, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 8, 8, 16, 19, 4, 359, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 12, 12, 20, 56, 49, 513, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 20, 52, 58, 960, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 26, 9, 24, 44, 703, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 3, 14, 0, 27, 1, 70, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 8, 1, 9, 8, 49, 278, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 4, 9, 15, 21, 38, 141, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 7, 13, 1, 25, 15, 557, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 29, 15, 39, 16, 570, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 12, 12, 0, 36, 10, 446, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 4, 17, 15, 53, 38, 261, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 9, 14, 3, 43, 13, 290, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 10, 4, 9, 16, 17, 707, DateTimeKind.Local).AddTicks(353));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Comments");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c6b0452-d9c6-4444-aa92-fc5d84083134", "7ab28494-6d6e-4220-a585-197a2da96aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d6fe7da-0e2e-47a4-8154-1dd0ac5cf9bf", "2c50b82e-b76d-45b5-8a1a-9870e5f10845" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76bcefa7-4354-46da-867c-db6c59379efb", "6e371fee-9c8c-4910-b9a8-34a4bc7bfb6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6eaeefab-0bf8-438d-ae07-e21f4d5d7f26", "de326066-2c06-4e42-beb9-841edbdc6a56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78d3cb35-0408-42f7-8ffd-0f2524f7825b", "d380c3b0-7752-49ff-ab2b-74c9ea750074" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43c6d614-7b3f-4492-a72a-cfb62ea26939", "22b8a3fb-12fe-4049-b12e-e760e239f79e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24fd1086-a1e1-497c-a64e-583a00e51ad4", "12780757-92a2-4a88-b75d-1bc87a78e2c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08d8f26d-ad18-4a56-8935-c314b5f2c7e4", "106f57e7-ef97-42f6-8859-b8f8bde4a75d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "730f6126-d4d8-43a0-9f37-1ede45600df3", "60471582-3f42-4525-8466-e916c52ebeb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8f11742-1d0a-484a-9804-5a5b162f3762", "c1b40196-fd8a-4f22-83a6-c6c524df45d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3e7b5ed-2f77-4ac5-8db4-cf75d0d6f0b6", "b9d38b78-b3d5-4340-80e6-615334d59ecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d293cf0-670f-4df8-9909-2a04a5fd3411", "ae80d7b6-06b4-45b6-867a-b28961830f94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "751c0e2b-25eb-4826-b645-1f5476529980", "428021c1-10c6-43a9-a66e-7cf9dc0effa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a2aa1d7-4947-4dbc-8e27-0d90e90a7606", "6a51d920-9efa-47fb-ad20-3f8811b5a95a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "369b20b4-13aa-4840-9db1-3b3764b157c1", "c2525280-e3c3-4f6d-bfc3-5361e230741d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "066caf5a-f956-4175-8504-2d08f3fd2c8f", "d71cb98d-4d45-47b9-8a2a-bae4a09166f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76c3d357-e351-4782-9b45-d314439eebe1", "c5af809a-d1e5-41ee-aac4-25a0ef7a33e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2282ea0-70df-4e63-a209-51c3c4268a6a", "203f1911-df0b-46bc-a163-1718ff1fb962" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa5d08b3-4c12-4b65-8baf-b67e19ef11ef", "d3475b10-a34f-4053-8778-3cc0a183f890" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "befc2bd8-6a46-4af3-a4e4-f1ada1be4e01", "0d8aaf51-a2e5-4b60-b730-4c5ced3cd2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c370b7e6-641b-416d-b0ce-8ea2fa3a0974", "65a6fa53-6db4-425b-bb08-97dbd6b68810" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b87ae99e-9070-4a12-90db-9cc5c0bac51e", "25ea4cb8-3566-4023-9f94-a813b43eeec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9748ce01-c481-4c40-b130-8de4845c104f", "d910639c-6ca4-4e3d-be0c-d988411192d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e064970f-c356-4080-b7a1-d85d50fb07e5", "55dee3c5-d1b5-4e9f-ba8e-d7e196a03c43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d707f05-b75f-40eb-ac3b-cbc6bbea9d5e", "8618054f-4d7d-46ad-bb2f-46052e293d1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdc5d75e-dc1f-40c4-9e5e-fe623d2aee38", "11c93bf8-02fa-4b1b-80d3-27d281ce5223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55d9a0f9-5124-4125-86c1-a644867ffc2e", "8ef03094-ea5c-484b-b990-92807c814e71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "063f0091-77d2-4382-b70d-9aed908c05d5", "078621ba-7d3a-4038-a4f4-081e8053fb3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "648f1874-216c-4198-ae6a-55405d7c0fbd", "4c27d54a-1a21-48e1-b3ed-9f53cb09ac95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccdf1d47-9b16-4767-baf9-2a03b514c744", "30458459-37f8-4ff4-849d-44caa9f8a6ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "743c4683-78eb-4c31-b80c-75fc6d0006ec", "fdc2415a-ffcd-4a9f-92d7-dc8dfed2ef14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e58e94b-c064-4a39-8b9a-36fc2f9d4d96", "781eb865-826b-4128-bc80-b084ac4eb459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f952ba06-ee5f-4d0a-b747-933a7c09a10e", "aa2fe695-5d5f-47b1-8ee7-cccb1d2f3032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e51cccd3-50f9-4835-a51f-4e192696ec85", "92eaf96b-4ef3-4614-9b93-105549aab8c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5aa779b6-4c2f-49bf-999b-55aed614bc90", "3ab1be8a-0469-4884-8245-7291258570bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e31f713e-7bca-47f2-8ac5-becb02bbc79a", "9f0c63ff-418d-4c8e-9a38-5efa2df7ff18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6a22af4-7d4d-427e-a95d-ee4c8de78293", "5f2adc00-7b14-40d2-84a4-cfa90c5a1e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f803e719-2fc3-425b-85b9-e00a8a6aec78", "666a9d1f-eea8-4d8b-983e-c8df91162aa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48628795-bfb8-4927-bfb2-b02d430e5dc5", "b6d63cf5-1b7e-4e24-a98f-9de26a864334" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06be00c9-bd54-402f-8ee9-4c49c2a816f0", "18484611-a61f-462a-9e1d-44a952298039" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e85c064f-5b1a-495d-9fcf-024bf41b4e2d", "27080239-6ca1-42a8-a3e1-f1e57227e2b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34fe49fc-7d00-4082-98d2-b96858992e3f", "a2e0371f-5121-46b0-a46e-34fb482caa12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac7f5581-674c-46b2-962e-aa6f3a6f392e", "460ba0c7-0b74-4ef4-80df-0213c715f13a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "033e8bf2-1d5a-4d6b-87bb-c7fb278a2993", "1afb563a-a96f-448b-97bd-5589e56c03e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01186b08-05c3-4427-869d-03f81452af3d", "caee8839-3897-4bdb-88f4-3fd6cc46d718" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de4a7d61-d4ea-4dfc-972d-dda5794b8fe1", "b56ea065-1d0e-4483-9dff-8be58fee6058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56c82fa6-5626-401c-b96f-9a14bfa9aa3d", "d8a2acbc-6c5b-4580-857f-8d57d1e7e406" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64b7679a-5e37-4855-a501-04aa78382e98", "665834c6-2dd2-4b30-be55-936637045511" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94473fd3-b74e-4116-a911-e4cf9af5077d", "83fdad1a-e236-4ebc-ac7e-1aae70190d31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "829ec4e4-1b02-4748-bfc8-222e2731d874", "c39ffd0f-9055-49da-839f-9ed90e6ceedb" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 31, 19, 37, 8, 798, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 8, 6, 17, 49, 38, 844, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 6, 22, 56, 44, 598, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 20, 14, 49, 6, 364, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 8, 9, 20, 20, 59, 998, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 31, 18, 59, 52, 843, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 22, 18, 45, 30, 288, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 5, 6, 12, 42, 17, 147, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 9, 10, 22, 26, 9, 988, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 5, 12, 20, 37, 19, 35, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 11, 21, 51, 867, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 21, 20, 34, 51, 265, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 8, 2, 10, 55, 24, 592, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 21, 15, 28, 11, 200, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 17, 15, 33, 0, 812, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 19, 17, 43, 48, 842, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 30, 20, 40, 23, 13, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2020, 1, 13, 19, 50, 25, 865, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 25, 17, 20, 0, 497, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 5, 7, 0, 4, 9, 482, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 6, 7, 20, 49, 6, 365, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 12, 3, 22, 25, 42, 638, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 28, 10, 11, 12, 60, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 4, 16, 11, 8, 22, 695, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 18, 17, 56, 0, 941, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 17, 13, 31, 42, 339, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 30, 15, 38, 9, 591, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 17, 17, 15, 4, 755, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2020, 1, 7, 10, 31, 0, 894, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 4, 7, 10, 13, 47, 943, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 4, 6, 6, 23, 17, 247, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 8, 10, 21, 18, 14, 981, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 29, 5, 27, 55, 100, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 12, 13, 14, 28, 33, 692, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 6, 14, 10, 46, 18, 227, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 23, 22, 34, 32, 793, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 10, 5, 2, 13, 56, 774, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 8, 6, 20, 34, 9, 423, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 12, 11, 1, 11, 54, 577, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 17, 1, 8, 4, 25, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 24, 13, 39, 49, 768, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 3, 12, 4, 42, 6, 134, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 30, 13, 23, 54, 342, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 4, 7, 19, 36, 43, 206, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 7, 11, 5, 40, 20, 621, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 27, 19, 54, 21, 634, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 12, 10, 4, 51, 15, 510, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 4, 15, 20, 8, 43, 325, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 9, 12, 7, 58, 18, 354, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 10, 2, 13, 31, 22, 771, DateTimeKind.Local).AddTicks(3360));
        }
    }
}
