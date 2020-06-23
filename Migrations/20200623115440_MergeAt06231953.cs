using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeachingSystem.Migrations
{
    public partial class MergeAt06231953 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Classes_ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_UserClasses_UserClassesId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_UserClassesId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers");

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

            migrationBuilder.DropColumn(
                name: "UserClassesId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<List<string>>(
                name: "ClassesId",
                table: "UserClasses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "Students",
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
                name: "Applies",
                columns: table => new
                {
                    ApplyId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(maxLength: 100, nullable: false),
                    ClassId = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applies", x => x.ApplyId);
                    table.ForeignKey(
                        name: "FK_Applies_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applies_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
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
                    table.PrimaryKey("PK_Classrooms", x => x.ClassroomId);
                });

            migrationBuilder.CreateTable(
                name: "SpecialityCourse",
                columns: table => new
                {
                    SpecialityCourseID = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: true)
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
                    { "911321ca-a3f4-4b3d-b9c9-878caa60111c", "1b24559d-1372-4f1a-98b3-86097a8a4924", "Admin", "ADMIN" },
                    { "48ea317a-ab90-4d08-a861-05698fe45983", "b60ce8b0-9651-4b97-94b5-db19b51aecb5", "Teacher", "TEACHER" },
                    { "5fbdf153-a83d-42ff-97f8-78868d0531a4", "f07267d0-7aaf-497c-a995-255eac5032f0", "Student", "STUDENT" },
                    { "5df56d68-cc08-44c0-a935-95ad77382eb5", "50dcee90-9435-4b70-b7be-c3b96fe55ad3", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassroomId",
                table: "Classes",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Applies_ClassId",
                table: "Applies",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Applies_StudentId",
                table: "Applies",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialityCourse_CourseId",
                table: "SpecialityCourse",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Classrooms_ClassroomId",
                table: "Classes",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Classrooms_ClassroomId",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "Applies");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "SpecialityCourse");

            migrationBuilder.DropIndex(
                name: "IX_Classes_ClassroomId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48ea317a-ab90-4d08-a861-05698fe45983");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5df56d68-cc08-44c0-a935-95ad77382eb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fbdf153-a83d-42ff-97f8-78868d0531a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "911321ca-a3f4-4b3d-b9c9-878caa60111c");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "UserClasses");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Students",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeachTime",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TestTime",
                table: "Classes");

            migrationBuilder.AddColumn<long>(
                name: "UserClassesId",
                table: "Classes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassId",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UserClassesId",
                table: "Classes",
                column: "UserClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Classes_ClassId",
                table: "AspNetUsers",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_UserClasses_UserClassesId",
                table: "Classes",
                column: "UserClassesId",
                principalTable: "UserClasses",
                principalColumn: "UserClassesId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
