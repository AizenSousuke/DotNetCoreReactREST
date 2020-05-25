using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreReactREST.Migrations
{
    public partial class Properties : Migration
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "a6a08e01-7932-46ac-9082-138a4e60eb7e", "DinoBreitenberg.Hills19@gmail.com", "DINOBREITENBERG.HILLS19@GMAIL.COM", "DINO BREITENBERG", "2044479b-3edc-42fd-b67a-664b312e7b2e", "Dino Breitenberg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "d69943f4-2259-40ab-9efa-f35a9e58753d", "CamrynGorczany69@yahoo.com", "CAMRYNGORCZANY69@YAHOO.COM", "CAMRYN GORCZANY", "f90bd22e-bb6c-4c0d-8726-1b6a2192938f", "Camryn Gorczany" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "4244cef3-63bb-4689-8ac4-45bd7cd5eb81", "ZachariahJohns.Kertzmann@yahoo.com", "ZACHARIAHJOHNS.KERTZMANN@YAHOO.COM", "ZACHARIAH JOHNS", "5b62ac07-b33f-4d45-ac1b-c709bf33c03e", "Zachariah Johns" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "e1d75afb-ece0-4150-b7b2-32d454b69966", "LenoraCronin90@gmail.com", "LENORACRONIN90@GMAIL.COM", "LENORA CRONIN", "2901468d-1131-402f-8da8-eafc0af2d2b9", "Lenora Cronin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "6c6350f7-7680-47a6-b4b7-9d3c9c01fc62", "NayeliBins62@yahoo.com", "NAYELIBINS62@YAHOO.COM", "NAYELI BINS", "288c7733-4361-4395-a882-3d47d23c778f", "Nayeli Bins" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "9092b1dd-f20a-4734-8b20-bd87f85e8818", "KhalilYost40@yahoo.com", "KHALILYOST40@YAHOO.COM", "KHALIL YOST", "1b25347d-da43-4bda-82c8-8fb8e3a7327a", "Khalil Yost" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "dd0310fe-14ce-45f1-9c04-45a3f952f63f", "BettyHerzog.Ortiz@hotmail.com", "BETTYHERZOG.ORTIZ@HOTMAIL.COM", "BETTY HERZOG", "9695d993-c4ff-431e-aeef-87299a0c8653", "Betty Herzog" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "4919c2df-957f-4d6d-9aef-f3ae2ddc5fb5", "TerranceFrami63@hotmail.com", "TERRANCEFRAMI63@HOTMAIL.COM", "TERRANCE FRAMI", "ec437456-4575-4c40-ae6b-bf58f4effea8", "Terrance Frami" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "95a5fd0d-8bce-4e2d-8ecd-c80df75d72ca", "SadyeNitzsche.Fisher@gmail.com", "SADYENITZSCHE.FISHER@GMAIL.COM", "SADYE NITZSCHE", "80f80ee9-cff4-48c9-89fe-fade8151ff6b", "Sadye Nitzsche" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "82267577-f907-4c72-a43e-def24079942c", "DaveDavis5@gmail.com", "DAVEDAVIS5@GMAIL.COM", "DAVE DAVIS", "0910059e-f8ab-42ae-9a06-f4e92d295e69", "Dave Davis" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "e3818005-4930-4cfb-aad0-3f3578cf904d", "QuintonMurazik.Terry31@gmail.com", "QUINTONMURAZIK.TERRY31@GMAIL.COM", "QUINTON MURAZIK", "66766dac-45a2-4527-ac2b-36048813a415", "Quinton Murazik" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "41811f8c-9cf2-41a6-86f2-69e51db3657a", "GisselleLockman_Boyer@hotmail.com", "GISSELLELOCKMAN_BOYER@HOTMAIL.COM", "GISSELLE LOCKMAN", "bbb99ca9-3248-4825-aa56-477aa66ff3e5", "Gisselle Lockman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "2428a0bf-9694-49e4-8160-ec1938665bf6", "ShermanJohns55@gmail.com", "SHERMANJOHNS55@GMAIL.COM", "SHERMAN JOHNS", "1bbcb24c-9446-4402-9597-6d4d2dec8826", "Sherman Johns" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "86d18def-f29a-470e-b332-61d289a56820", "TreverMcKenzie_Gulgowski70@hotmail.com", "TREVERMCKENZIE_GULGOWSKI70@HOTMAIL.COM", "TREVER MCKENZIE", "d687481d-8910-4c7e-85d8-f600bcd0633e", "Trever McKenzie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "dc9aeeef-9be0-4011-877f-c3f74bddc8cc", "AbeZemlak.Hintz@yahoo.com", "ABEZEMLAK.HINTZ@YAHOO.COM", "ABE ZEMLAK", "d9206d46-dd93-421f-8530-a65c978f4667", "Abe Zemlak" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "29221819-ce78-4222-9394-fef0893c7f5a", "KiaraEffertz22@hotmail.com", "KIARAEFFERTZ22@HOTMAIL.COM", "KIARA EFFERTZ", "66b7a925-fb73-443d-b9cf-37da3de57f46", "Kiara Effertz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "1a3a827d-f61e-4017-8bdb-0698fe34f2d6", "FlorenceOHara.Welch40@hotmail.com", "FLORENCEOHARA.WELCH40@HOTMAIL.COM", "FLORENCE O'HARA", "521fbc38-47f4-4e8c-852f-dd16f6b609f4", "Florence O'Hara" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "62560854-e716-450a-8280-c552e9d3a8b1", "PattieReilly.Erdman9@gmail.com", "PATTIEREILLY.ERDMAN9@GMAIL.COM", "PATTIE REILLY", "4b6e5ec7-a098-4eff-832a-ed30b4b8cf2c", "Pattie Reilly" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "f2cc1346-a47f-4db9-9811-0834578cb731", "MarkKrajcik.Friesen97@yahoo.com", "MARKKRAJCIK.FRIESEN97@YAHOO.COM", "MARK KRAJCIK", "920856ad-13dd-45bd-a222-4e32fcc38f42", "Mark Krajcik" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "66120acf-e5e4-477c-834e-19b09a46d61a", "ElianBecker.Windler50@hotmail.com", "ELIANBECKER.WINDLER50@HOTMAIL.COM", "ELIAN BECKER", "f78aefb5-2e1a-4ff9-a412-dfbfe70b48ba", "Elian Becker" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "1ce954b4-21bb-47eb-ade9-60b0973b01b4", "LisandroBreitenberg.Mertz76@gmail.com", "LISANDROBREITENBERG.MERTZ76@GMAIL.COM", "LISANDRO BREITENBERG", "74ea8aad-7763-440b-af88-937611cf1092", "Lisandro Breitenberg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "c4e80127-a854-474d-902d-7ec745369a4d", "SusanaBlanda37@yahoo.com", "SUSANABLANDA37@YAHOO.COM", "SUSANA BLANDA", "a6a67b2a-5d59-488b-bbcf-703be4098030", "Susana Blanda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "3702126b-24f4-4d6b-aeeb-1c3ddc06d425", "BeaulahQuitzon_Rath@hotmail.com", "BEAULAHQUITZON_RATH@HOTMAIL.COM", "BEAULAH QUITZON", "9ca056a1-ae9f-44cf-8afd-b7dd8927a0a9", "Beaulah Quitzon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "bf0a485a-9a3d-40f5-905d-14eca8460a96", "BradleyWuckert.Rutherford31@hotmail.com", "BRADLEYWUCKERT.RUTHERFORD31@HOTMAIL.COM", "BRADLEY WUCKERT", "59fcedb0-f440-4993-ba78-1350f068d8c7", "Bradley Wuckert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "35a80b8d-4502-4093-b638-6f2c558f230b", "LuraBoyle_Mosciski24@yahoo.com", "LURABOYLE_MOSCISKI24@YAHOO.COM", "LURA BOYLE", "f35ca837-03a1-4c26-98da-e2b436152588", "Lura Boyle" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "aa7a8546-abd0-42e7-8096-da1dc88926b5", "AndrewMetz57@gmail.com", "ANDREWMETZ57@GMAIL.COM", "ANDREW METZ", "1b938f52-0547-44bf-94bc-5196802a24a6", "Andrew Metz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "72868e7e-6ede-4ed6-add5-06ed91279725", "StephaniaCruickshank_Cruickshank@yahoo.com", "STEPHANIACRUICKSHANK_CRUICKSHANK@YAHOO.COM", "STEPHANIA CRUICKSHANK", "a30049c1-6eab-4d7c-8c86-597249f745a1", "Stephania Cruickshank" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "38559257-11ef-462a-8290-4fcca125de2e", "DaneHarber.Jacobs62@hotmail.com", "DANEHARBER.JACOBS62@HOTMAIL.COM", "DANE HARBER", "c2b3f417-70ce-4cfb-a282-38f002e60e60", "Dane Harber" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "33042e03-939d-48e4-98ee-4a4e2e1ba1ca", "AlanaStehr7@gmail.com", "ALANASTEHR7@GMAIL.COM", "ALANA STEHR", "1b0ca783-23a7-4921-b9df-fe28543a9c9c", "Alana Stehr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "79020267-f55c-46cf-95b2-cc19e04b918b", "RoelCrona.Lehner@hotmail.com", "ROELCRONA.LEHNER@HOTMAIL.COM", "ROEL CRONA", "33819466-4651-4d03-877a-e9bdc8a25d7c", "Roel Crona" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "5b10a590-7b07-44db-ac9f-6c2615d218fe", "MafaldaAbernathy2@hotmail.com", "MAFALDAABERNATHY2@HOTMAIL.COM", "MAFALDA ABERNATHY", "62eb4087-8656-439f-82fc-2f99c6ab7de4", "Mafalda Abernathy" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "56e7edf2-8449-4982-a314-e087140794ae", "MalachiWilderman.Kovacek65@hotmail.com", "MALACHIWILDERMAN.KOVACEK65@HOTMAIL.COM", "MALACHI WILDERMAN", "3e63d296-496d-4319-a18d-2f0b237cacb4", "Malachi Wilderman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "493ffa13-821d-4268-a578-56980f633fff", "CallieWhite_Wunsch70@hotmail.com", "CALLIEWHITE_WUNSCH70@HOTMAIL.COM", "CALLIE WHITE", "c25ff754-6c24-4273-8c81-2c393c95995a", "Callie White" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "b9326fbb-3064-4c1f-a63d-09e4edf94184", "ArmandKub.Padberg32@gmail.com", "ARMANDKUB.PADBERG32@GMAIL.COM", "ARMAND KUB", "f2f8d211-6391-4e44-9710-67fdfa536c26", "Armand Kub" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "49e164a0-94ae-42ca-bc88-cdc96f1fc778", "GraceHaag.Hudson1@hotmail.com", "GRACEHAAG.HUDSON1@HOTMAIL.COM", "GRACE HAAG", "37cfd1bd-0608-4c97-b203-59117588c92f", "Grace Haag" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "466a8515-1ac8-4bbe-a956-f1cddb90ddb7", "StephenFeil.Bauch@yahoo.com", "STEPHENFEIL.BAUCH@YAHOO.COM", "STEPHEN FEIL", "43f63e4b-c762-4f77-a206-e2d7d137883f", "Stephen Feil" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "c2afa671-b9df-486b-bbd0-9a43e7958439", "NorbertWintheiser.Hintz@hotmail.com", "NORBERTWINTHEISER.HINTZ@HOTMAIL.COM", "NORBERT WINTHEISER", "22866f84-8a48-47b4-93cb-08ecfa614c91", "Norbert Wintheiser" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "e8f7198f-60ac-4544-97b0-d77d30bebafb", "GayGleason_White@gmail.com", "GAYGLEASON_WHITE@GMAIL.COM", "GAY GLEASON", "7851d060-8d6c-472e-9752-8be3867b49f8", "Gay Gleason" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "c072ef56-7de2-4ae2-a7a7-be75f96b964d", "VerlaMayer17@hotmail.com", "VERLAMAYER17@HOTMAIL.COM", "VERLA MAYER", "e087892d-976a-4e88-a8c9-78834ecc01de", "Verla Mayer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "f36eee47-b09e-4b45-907a-729ce8c3e32c", "ZacharySkiles.Abernathy@hotmail.com", "ZACHARYSKILES.ABERNATHY@HOTMAIL.COM", "ZACHARY SKILES", "9376c25b-87a8-4429-973c-ce27d625ac42", "Zachary Skiles" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "86819de4-b8d9-4b5b-96b4-b3ddbf807156", "JaimeWintheiser_Anderson26@hotmail.com", "JAIMEWINTHEISER_ANDERSON26@HOTMAIL.COM", "JAIME WINTHEISER", "66f659a5-6cfa-4439-a775-4e579cb6aac4", "Jaime Wintheiser" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "538881f1-454c-403e-ba5c-8ae90f41f11d", "HiltonHane1@gmail.com", "HILTONHANE1@GMAIL.COM", "HILTON HANE", "ffad3bfe-251b-4bad-be7a-e280585cd20a", "Hilton Hane" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "74c36412-0c65-44fd-8688-02e33b52f7c7", "IzabellaHessel.Hamill@yahoo.com", "IZABELLAHESSEL.HAMILL@YAHOO.COM", "IZABELLA HESSEL", "491184e9-0e01-4c3b-a925-d650ee417987", "Izabella Hessel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "f085d533-f8c2-4b81-9cdd-0bfee654cdba", "FlorencioGlover.Schaden76@yahoo.com", "FLORENCIOGLOVER.SCHADEN76@YAHOO.COM", "FLORENCIO GLOVER", "a50b6a38-0896-4e92-bf02-956585b99674", "Florencio Glover" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "942754d2-d67d-452b-8f88-1d88703b9242", "AriAdams_Luettgen@hotmail.com", "ARIADAMS_LUETTGEN@HOTMAIL.COM", "ARI ADAMS", "29426846-f04b-4d6a-881f-ac4eccda31df", "Ari Adams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "fa97bdd2-a7ab-47f3-911b-c89eadcb572b", "DameonFisher_Schmitt@gmail.com", "DAMEONFISHER_SCHMITT@GMAIL.COM", "DAMEON FISHER", "3d28bf5d-2116-41db-b5ad-55447e7f53ab", "Dameon Fisher" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "2a027374-9ebf-4833-a92d-28f30cb9426e", "TatumBreitenberg.Bradtke41@hotmail.com", "TATUMBREITENBERG.BRADTKE41@HOTMAIL.COM", "TATUM BREITENBERG", "1a8a2ab1-b467-4860-af69-8adc2f2ba27d", "Tatum Breitenberg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "1d6b214a-6b93-42df-982d-cb518f4582f8", "MadelineDare35@hotmail.com", "MADELINEDARE35@HOTMAIL.COM", "MADELINE DARE", "5ff63c45-019e-42f2-bfe9-8cbfeab55d19", "Madeline Dare" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "4732ae03-4d9d-4786-b1f2-b1dc55044258", "ArielProsacco44@yahoo.com", "ARIELPROSACCO44@YAHOO.COM", "ARIEL PROSACCO", "2c5459e0-fcc4-4d24-94c6-39f5ffec197a", "Ariel Prosacco" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "5c25933f-d919-4028-90cf-eb79b6c496ed", "GlennaDonnelly43@hotmail.com", "GLENNADONNELLY43@HOTMAIL.COM", "GLENNA DONNELLY", "e4b8af36-0aee-4f6a-84c1-a8e61c45c10b", "Glenna Donnelly" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 1, 27, 19, 35, 11, 79, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 8, 2, 17, 47, 41, 124, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 3, 2, 22, 54, 46, 879, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 1, 16, 14, 47, 8, 644, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2019, 8, 5, 20, 19, 2, 278, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2019, 8, 27, 18, 57, 55, 123, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2020, 3, 18, 18, 43, 32, 568, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2019, 5, 2, 12, 40, 19, 427, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2019, 9, 6, 22, 24, 12, 268, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2019, 5, 8, 20, 35, 21, 315, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2020, 3, 14, 11, 19, 54, 147, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2019, 7, 17, 20, 32, 53, 545, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2019, 7, 29, 10, 53, 26, 872, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2020, 1, 17, 15, 26, 13, 481, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2019, 6, 13, 15, 31, 3, 92, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2020, 2, 15, 17, 41, 51, 122, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2019, 7, 26, 20, 38, 25, 293, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2020, 1, 9, 19, 48, 28, 145, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2019, 9, 21, 17, 18, 2, 777, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2019, 5, 3, 0, 2, 11, 762, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2019, 6, 3, 20, 47, 8, 645, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2019, 11, 29, 22, 23, 44, 918, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2019, 6, 24, 10, 9, 14, 340, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2020, 4, 12, 11, 6, 24, 975, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2019, 6, 14, 17, 54, 3, 221, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2019, 9, 13, 13, 29, 44, 619, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2019, 8, 26, 15, 36, 11, 871, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2019, 7, 13, 17, 13, 7, 35, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2020, 1, 3, 10, 29, 3, 174, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2020, 4, 3, 10, 11, 50, 223, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2020, 4, 2, 6, 21, 19, 528, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2019, 8, 6, 21, 16, 17, 261, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2020, 3, 25, 5, 25, 57, 380, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2019, 12, 9, 14, 26, 35, 972, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2019, 6, 10, 10, 44, 20, 507, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2020, 3, 19, 22, 32, 35, 73, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2019, 10, 1, 2, 11, 59, 54, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2019, 8, 2, 20, 32, 11, 703, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2019, 12, 7, 1, 9, 56, 857, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2020, 3, 13, 1, 6, 6, 305, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2019, 9, 20, 13, 37, 52, 48, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2020, 3, 8, 4, 40, 8, 414, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2019, 7, 26, 13, 21, 56, 623, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2020, 4, 3, 19, 34, 45, 486, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2019, 7, 7, 5, 38, 22, 901, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2019, 9, 23, 19, 52, 23, 914, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2019, 12, 6, 4, 49, 17, 790, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2020, 4, 11, 20, 6, 45, 606, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2019, 9, 8, 7, 56, 20, 634, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2019, 9, 28, 13, 29, 25, 51, DateTimeKind.Local).AddTicks(4352));
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "331588e0-dc9c-4a33-b24d-4736b9a7b8a0", "Bennett.Hills19@gmail.com", null, null, "38b462ba-e376-4d61-a943-a3b899079219", "Dino" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "2bc3209d-f286-48bc-b4db-e1fcd3840e50", "Dortha69@yahoo.com", null, null, "e16410e4-f5ec-46cf-94f8-cdf103339173", "Camryn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "9e92c736-1db8-4137-b351-1d74c4c9de82", "Harvey.Kertzmann@yahoo.com", null, null, "3c6848b0-029b-4bd2-9aeb-61409e19a84e", "Zachariah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "fbd011e6-b02c-4919-88a9-a2530e269ad9", "Carol90@gmail.com", null, null, "0fec172d-6a3c-41c4-ac76-4e3b31c678f7", "Lenora" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "3cab878a-ff71-4a4a-abcf-3cf4fca5d695", "Anya62@yahoo.com", null, null, "bc97b9f7-7153-400e-902a-115ceffd9b59", "Nayeli" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "5898c6de-2f1f-4cdb-979a-2628c4964629", "Wyatt40@yahoo.com", null, null, "fad98867-b2c2-4fb5-a6e2-ac4c80ffc739", "Khalil" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "4df86b39-d1df-464e-93ef-bb554661816e", "Floy.Ortiz@hotmail.com", null, null, "3728edf0-12ad-46ab-88e0-7b72466b4a45", "Betty" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "5d50b79c-7f9d-4645-9544-750d3079d24e", "Dejon63@hotmail.com", null, null, "c01b33e9-43c4-4ce9-a9a9-72ea3456bd60", "Terrance" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "bc2f0692-d3f9-4db7-9b01-666dbab2b6b7", "Lucy.Fisher@gmail.com", null, null, "64da748b-89e3-4ef0-b58c-9241f136fba1", "Sadye" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "11077021-d975-48f1-89ec-eefccef9a432", "Chesley5@gmail.com", null, null, "7273b00e-776f-4d9b-a20d-3d1ee47cf1e3", "Dave" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "201e7c38-b1c3-4e79-99b0-28ac7327b0fb", "Lisandro.Terry31@gmail.com", null, null, "e899c043-df72-4da7-bf3d-9d9b02f3192b", "Quinton" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "c52c5806-9860-48d6-8bee-7831ce27033e", "Karson_Boyer@hotmail.com", null, null, "57779cf5-0fe5-4a4c-8ee5-22a4e903de1d", "Gisselle" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "62b5397d-c888-4395-8274-0f5e9747b465", "Harry55@gmail.com", null, null, "a39795eb-9d67-44fd-901b-08bc67da5bd7", "Sherman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "db143893-e676-4cf2-83c8-7ec7c4380112", "Laisha_Gulgowski70@hotmail.com", null, null, "e2603f1a-6126-4563-9be9-033632b99f66", "Trever" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "a0a632a8-e123-4925-b797-f40cb61af899", "Zachery.Hintz@yahoo.com", null, null, "76082787-f9e1-4fd1-bb24-d04d48b40aa3", "Abe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "43cb92d4-df14-4143-8dcc-71f87a8b9ecc", "Courtney22@hotmail.com", null, null, "8b35ad28-b8b9-4b28-a78b-27790db9f71e", "Kiara" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "6535e761-e42c-4c31-8207-5c431c02db61", "Maci.Welch40@hotmail.com", null, null, "6b030686-4575-45b2-a2f7-d8e1c4c95d9d", "Florence" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "8995c5ec-3665-40cd-8a4e-99dd549f2c3f", "Mittie.Erdman9@gmail.com", null, null, "3ca0ceef-8481-492f-b33d-4827d947f9aa", "Pattie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "1b388505-305b-414a-a1c2-aa0ecb8bf967", "Jarrell.Friesen97@yahoo.com", null, null, "d5edddf2-f0b0-4df8-a6c1-6398e615831c", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "9fc98791-770f-44c0-91ea-7f727814d748", "Amir.Windler50@hotmail.com", null, null, "e4594e2a-bff5-44fd-af63-2ee6c879921d", "Elian" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "e5a76f85-9c86-44eb-b577-2c84283d1d65", "Bennett.Mertz76@gmail.com", null, null, "9e020e5f-a0dc-4f63-8e9f-99a099d27f04", "Lisandro" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "011539b4-1d08-44fb-9829-09e0b41e496f", "Ara37@yahoo.com", null, null, "ef13ecda-21a1-4d2b-8962-f77888b63c0c", "Susana" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "da7b301b-8abc-4350-8393-ed8e833172c9", "Melody_Rath@hotmail.com", null, null, "0a1c93ed-a69c-48a8-8aba-1ea4d7a4ddb4", "Beaulah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "dccaf218-7465-4521-bc9c-02509044d778", "Wilhelm.Rutherford31@hotmail.com", null, null, "4f8c74a0-a600-4c2c-82b6-07c0bc408c12", "Bradley" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "1c330964-5d8d-412c-aa3b-e4c92a491972", "Avis_Mosciski24@yahoo.com", null, null, "eb3f69ec-366c-4723-95f0-976163652b95", "Lura" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "84ae7770-6ba4-4855-acde-521200643122", "Lavina57@gmail.com", null, null, "0b98953c-5c43-45c6-b46f-e36abd776759", "Andrew" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "67643580-a913-4c77-9318-07ae13fa9fcf", "Casey_Cruickshank@yahoo.com", null, null, "521204d6-ea1a-4a01-a978-e31564abda69", "Stephania" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "120db724-017d-427b-b777-14213996cdfb", "Ernest.Jacobs62@hotmail.com", null, null, "c66cf4d9-527c-4b54-bc30-c553647c0a8c", "Dane" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "d28efa26-ac48-469c-9979-46c61920b3e3", "Ruby7@gmail.com", null, null, "f98818b8-c2ca-4d10-81ff-fe4a6858f1ee", "Alana" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "14c43a15-56b8-41f1-8765-441cd15ea75b", "Carlotta.Lehner@hotmail.com", null, null, "c75348e5-f43b-45ba-a370-4556bd77545e", "Roel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "81b4d567-9089-49ba-a249-4978eb810adb", "Abdullah2@hotmail.com", null, null, "5ff2cd46-cec7-40a8-bfa6-53f5d6766b5a", "Mafalda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "495b49d9-dbf2-4ce5-a801-8bbabf97fe39", "Vallie.Kovacek65@hotmail.com", null, null, "bb4dc1a0-8301-44ff-89c8-b97f6cb4fa18", "Malachi" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "9acb41b7-70df-45c6-9c7f-1262e29da257", "Unique_Wunsch70@hotmail.com", null, null, "c7d1ba86-1ac7-45c5-9348-5dd46024dfb5", "Callie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "a9ff4b3c-1dd9-4646-80c1-16f1588d7c44", "Jaylan.Padberg32@gmail.com", null, null, "cf4671ea-0a3a-4cc5-b703-7689de3bb03c", "Armand" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "3380b55e-26d0-4d03-9410-f6d885ce406e", "Elmira.Hudson1@hotmail.com", null, null, "35f971d3-8db0-4aac-9765-2da257f69d8c", "Grace" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "f75e7349-b011-406f-8d92-b836abe37076", "Darwin.Bauch@yahoo.com", null, null, "3832dbdd-96bd-4a35-810d-779c8f924484", "Stephen" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "76ff2216-2770-4096-964d-82df735f5c4d", "Virgil.Hintz@hotmail.com", null, null, "32971bac-4261-4a1c-86b3-13d74a4c3927", "Norbert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "2065c3be-7569-4849-831b-998b8bc7fc09", "Dimitri_White@gmail.com", null, null, "92f48145-2c17-4a5b-a749-e828c46a2474", "Gay" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "975b9fd9-41cd-499d-901a-ee3eb715c1dc", "King17@hotmail.com", null, null, "5381d076-567a-4be5-9e25-1dfca06daf7b", "Verla" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "835ed446-1176-4971-819f-b4ccf65d0420", "River.Abernathy@hotmail.com", null, null, "b00cccc2-f4c9-43dd-891c-330042b4f577", "Zachary" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "fa040a29-3aac-40dd-acc2-d32ead43ceb2", "Violet_Anderson26@hotmail.com", null, null, "9820b4a2-28cb-4a9b-8262-65c4584078be", "Jaime" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "a702f704-62b7-440d-9703-bc0b4d4c4029", "Eriberto1@gmail.com", null, null, "e32c4e1b-ad14-41d6-9c7e-e30003717832", "Hilton" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "3f9903e5-1fac-4ef5-9eaf-b93ce4457ca5", "Forrest.Hamill@yahoo.com", null, null, "d84878a1-4860-4f14-b309-2d5a34f6ad23", "Izabella" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "07409299-8296-4fbe-a427-ad98ba3810fb", "Dominique.Schaden76@yahoo.com", null, null, "78067c27-de00-4478-a2f0-ea1f5edb3149", "Florencio" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "969c5b98-a546-415d-80f7-c50c105d6668", "Adan_Luettgen@hotmail.com", null, null, "7b722767-7a07-4ea9-8c01-e1335148b4d5", "Ari" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "988343c7-19f0-4ce3-ac8d-9cd8ee898d3d", "Dayna_Schmitt@gmail.com", null, null, "89848f30-a22c-40e3-8e17-b71eb74999c1", "Dameon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "c41d127c-edd9-459f-9761-f411da72aa06", "Berenice.Bradtke41@hotmail.com", null, null, "6bc524c9-49e7-480e-8295-3adaf9e02ce7", "Tatum" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "bff0914d-aaf0-4465-9350-8fbe88134e82", "Charity35@hotmail.com", null, null, "643cd122-cfb6-40f8-9d75-132b75979087", "Madeline" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "0ef5bbdb-6348-429e-83ae-66df739b0fd9", "Maye44@yahoo.com", null, null, "70ff9bc9-8ff6-4a3c-b618-d2d2b3232ddc", "Ariel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "9f31141d-81eb-4d76-8c94-d108ad80c843", "Clint43@hotmail.com", null, null, "6a2cdded-fe60-4ece-812f-334ac3ca3266", "Glenna" });

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
