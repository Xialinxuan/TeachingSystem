using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeachingSystem.Migrations
{
    public partial class NewStage : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<List<int>>(
                name: "TeachTime",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestTime",
                table: "Classes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Classroom",
                columns: table => new
                {
                    ClassroomId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Campus = table.Column<string>(nullable: true),
                    Building = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<int>(nullable: false),
                    ClassroomName = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.ClassroomId);
                });

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
                    { "4c1466bf-3620-4b08-a0a2-974ca66c9d1a", "4f3a6bc5-d511-4f59-8c17-d1a37102d550", "Admin", "ADMIN" },
                    { "19f04d4e-4a8c-42b1-b1df-a781c08833a2", "26d9f430-62f5-4193-ad23-d17fd5f68504", "Teacher", "TEACHER" },
                    { "bb316b3c-e9a4-4d67-a1ac-b58082059d5e", "06fcc5c1-fad1-4a94-848b-776bb7098400", "Student", "STUDENT" },
                    { "1a026109-eda9-4823-be66-fb75ff2f6de0", "c7b7f1f6-884d-4250-a4b2-085fb67abdc4", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassroomId",
                table: "Classes",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_newClass_CourseId",
                table: "newClass",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialityCourse_CourseId",
                table: "SpecialityCourse",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Classroom_ClassroomId",
                table: "Classes",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Classroom_ClassroomId",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "Classroom");

            migrationBuilder.DropTable(
                name: "newClass");

            migrationBuilder.DropTable(
                name: "SpecialityCourse");

            migrationBuilder.DropIndex(
                name: "IX_Classes_ClassroomId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19f04d4e-4a8c-42b1-b1df-a781c08833a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a026109-eda9-4823-be66-fb75ff2f6de0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c1466bf-3620-4b08-a0a2-974ca66c9d1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb316b3c-e9a4-4d67-a1ac-b58082059d5e");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeachTime",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TestTime",
                table: "Classes");

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
