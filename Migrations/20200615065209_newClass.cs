using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class newClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "newClass",
                columns: table => new
                {
                    newClassId = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: true),
                    TeacherID = table.Column<string>(nullable: true),
                    TeacherName = table.Column<string>(nullable: true),
                    StuIDList = table.Column<List<string>>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newClass", x => x.newClassId);
                    table.ForeignKey(
                        name: "FK_newClass_Courses_CourseId",
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
                    { "76cf9b9a-9b15-44e8-8a9f-d556262623ab", "1e4e205a-c334-4606-8c9e-4d16c4de8c02", "Admin", "ADMIN" },
                    { "d55c0c4a-4fb2-47ed-ac1e-034966eef966", "4af0fa6e-6172-4870-99c8-3ebbe2bdd194", "Teacher", "TEACHER" },
                    { "07eb93d9-4301-4511-8f4c-db7690b12f66", "0909f8a1-39a9-466e-8790-1f3ccaae4e65", "Student", "STUDENT" },
                    { "4aeb340b-a5a7-447c-a73f-fe4e176b71f0", "7bdcc98e-7dbe-43de-8bca-8cb7ff8fcfd9", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_newClass_CourseId",
                table: "newClass",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "newClass");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07eb93d9-4301-4511-8f4c-db7690b12f66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aeb340b-a5a7-447c-a73f-fe4e176b71f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76cf9b9a-9b15-44e8-8a9f-d556262623ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d55c0c4a-4fb2-47ed-ac1e-034966eef966");

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
        }
    }
}
