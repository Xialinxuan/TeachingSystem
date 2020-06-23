using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeachingSystem.Migrations
{
    public partial class ApplyBegin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Classes_ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers");

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
                name: "UserID",
                table: "SpecialityCourse");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "SpecialityCourse");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<List<string>>(
                name: "Students",
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01907824-fce4-46b5-99e1-a2bb5c967905", "90cf20c2-0556-4ca4-9f3d-d0e4984815df", "Admin", "ADMIN" },
                    { "1f77af71-f72c-4dc9-9b13-b38db219183a", "dda333e7-7fd5-4723-ad4a-f49a78a46931", "Teacher", "TEACHER" },
                    { "784b6b7b-84e0-4497-89ce-6b8ca7772901", "57648568-3e3b-4d6c-996c-b37522ffd289", "Student", "STUDENT" },
                    { "a7033eeb-e0bd-4aa6-9a0b-5b33f304cc34", "e863109c-e4f3-49bc-84c4-26ab30ad0f8d", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applies_ClassId",
                table: "Applies",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Applies_StudentId",
                table: "Applies",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applies");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01907824-fce4-46b5-99e1-a2bb5c967905");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f77af71-f72c-4dc9-9b13-b38db219183a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "784b6b7b-84e0-4497-89ce-6b8ca7772901");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7033eeb-e0bd-4aa6-9a0b-5b33f304cc34");

            migrationBuilder.DropColumn(
                name: "Students",
                table: "Classes");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "SpecialityCourse",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "SpecialityCourse",
                type: "text",
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
                    { "9eb36fb2-2887-453c-85b1-e707bb6ce3ba", "b2078dd8-407a-41f2-8f20-e5449f1d81c9", "Admin", "ADMIN" },
                    { "11941600-f785-4307-ac9d-a50dc5ced85b", "3d84b86a-33df-41f6-b24b-5e288dfd6d04", "Teacher", "TEACHER" },
                    { "f164fbaf-c497-49e4-b935-d981e27b62a5", "c1573430-6534-4089-acae-1c4a3d29cbdc", "Student", "STUDENT" },
                    { "f94dcf50-bcf2-4d25-9870-dd8faa68efc5", "191c3461-779e-4034-890f-f68097626640", "Manager", "MANAGER" }
                });

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
        }
    }
}
