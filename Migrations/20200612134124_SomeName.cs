using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class SomeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15d682dd-0514-42d1-844c-e94a7a1ac62f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535a2475-a5a8-41af-b0c2-1056f3904bba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7caf6577-754b-4bd1-aa15-dbd79589a4c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a230dbc9-e4de-4184-9338-9d5b26a56020");

            migrationBuilder.CreateTable(
                name: "CourseBy_Selection",
                columns: table => new
                {
                    CourseBy_SelectionId = table.Column<string>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseBy_Selection", x => x.CourseBy_SelectionId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a09f026-c9e4-4cc3-ab26-1c716afa6baf", "28b2ec5e-8077-4ab6-b3df-d701b8505668", "Admin", "ADMIN" },
                    { "bc4a9cd6-ec61-44ad-a51f-e70f69b1cf03", "029c9810-2c2e-45b7-8e99-baff97a99337", "Teacher", "TEACHER" },
                    { "651f4f4c-3731-42f0-b184-7db2041b2d2b", "0cfb3eec-f4c0-4279-9070-85be5540f8bf", "Student", "STUDENT" },
                    { "4ae5b235-fa2d-40d7-8fbe-78184a372529", "8171efd1-6a60-40ad-8cad-842aa622e674", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseBy_Selection");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ae5b235-fa2d-40d7-8fbe-78184a372529");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a09f026-c9e4-4cc3-ab26-1c716afa6baf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "651f4f4c-3731-42f0-b184-7db2041b2d2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc4a9cd6-ec61-44ad-a51f-e70f69b1cf03");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "535a2475-a5a8-41af-b0c2-1056f3904bba", "033deb12-2663-4a8b-8d93-2f2be0670686", "Admin", "ADMIN" },
                    { "15d682dd-0514-42d1-844c-e94a7a1ac62f", "212bc4d6-1474-4952-8393-920901dd069b", "Teacher", "TEACHER" },
                    { "a230dbc9-e4de-4184-9338-9d5b26a56020", "0ec43f15-a6b9-4334-91de-f8c561b5dd90", "Student", "STUDENT" },
                    { "7caf6577-754b-4bd1-aa15-dbd79589a4c8", "63f6ade5-38dd-490b-8f9d-c2ba766339d9", "Manager", "MANAGER" }
                });
        }
    }
}
