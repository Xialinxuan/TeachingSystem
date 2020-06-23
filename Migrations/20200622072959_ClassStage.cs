using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeachingSystem.Migrations
{
    public partial class ClassStage : Migration
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
                    { "9eb36fb2-2887-453c-85b1-e707bb6ce3ba", "b2078dd8-407a-41f2-8f20-e5449f1d81c9", "Admin", "ADMIN" },
                    { "11941600-f785-4307-ac9d-a50dc5ced85b", "3d84b86a-33df-41f6-b24b-5e288dfd6d04", "Teacher", "TEACHER" },
                    { "f164fbaf-c497-49e4-b935-d981e27b62a5", "c1573430-6534-4089-acae-1c4a3d29cbdc", "Student", "STUDENT" },
                    { "f94dcf50-bcf2-4d25-9870-dd8faa68efc5", "191c3461-779e-4034-890f-f68097626640", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassroomId",
                table: "Classes",
                column: "ClassroomId");

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
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "SpecialityCourse");

            migrationBuilder.DropIndex(
                name: "IX_Classes_ClassroomId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11941600-f785-4307-ac9d-a50dc5ced85b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eb36fb2-2887-453c-85b1-e707bb6ce3ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f164fbaf-c497-49e4-b935-d981e27b62a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f94dcf50-bcf2-4d25-9870-dd8faa68efc5");

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
