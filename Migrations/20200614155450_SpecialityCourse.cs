using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class SpecialityCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Class",
                table: "CourseBy_Selection");

            migrationBuilder.AddColumn<string>(
                name: "ClassId",
                table: "CourseBy_Selection",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SpecialityCourse",
                columns: table => new
                {
                    SpecialityCourseID = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialityCourse", x => x.SpecialityCourseID);
                    table.ForeignKey(
                        name: "FK_SpecialityCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29fa2800-91a7-4e0f-b716-8617ef24b274", "f7b9828c-5a19-4e6c-9b64-2cc77f99fb00", "Admin", "ADMIN" },
                    { "e5c44027-7a1d-46bf-826e-9d61b61f0b03", "e817acf5-2881-4c6d-a392-a2a4915737e0", "Teacher", "TEACHER" },
                    { "1bebcfe7-9cd3-4d10-b7ad-2b2ea592a106", "c1012094-a3b7-4913-a8f7-d78fc4c26213", "Student", "STUDENT" },
                    { "cf363a24-eb1f-4b49-ba66-097858e38204", "fd603b6e-dc0b-4086-9395-9f18b433dfb7", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecialityCourse_CourseId",
                table: "SpecialityCourse",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecialityCourse");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bebcfe7-9cd3-4d10-b7ad-2b2ea592a106");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29fa2800-91a7-4e0f-b716-8617ef24b274");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf363a24-eb1f-4b49-ba66-097858e38204");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5c44027-7a1d-46bf-826e-9d61b61f0b03");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "CourseBy_Selection");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "CourseBy_Selection",
                type: "text",
                nullable: true);

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
    }
}
