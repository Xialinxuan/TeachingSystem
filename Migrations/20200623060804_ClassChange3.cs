using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class ClassChange3 : Migration
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
                keyValue: "0fd07628-4e36-44f9-a781-0628ae7c7a7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5598022b-5b16-468e-b436-124c15efa49f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c76ab141-19f7-438f-a5cf-876bf6e1f0e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcf338cd-e9cc-4277-8c56-fb478078edec");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<List<string>>(
                name: "Students",
                table: "Classes",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c2417e87-0263-469a-9139-91f3d3d8328a", "c33af9df-63d9-49c7-be1f-b9186847f9c8", "Admin", "ADMIN" },
                    { "97f5a672-da81-4012-8ed5-0f5f9f2f18e1", "308eadf4-006d-46bd-9f7b-feacd37f13cc", "Teacher", "TEACHER" },
                    { "26b00550-c5dd-4360-8b14-ea893c8cddc8", "428b39a4-375b-4dae-99c7-2b34235b7b11", "Student", "STUDENT" },
                    { "2b41aaee-695e-49e6-aa4e-2289c6f4512c", "3c0aa4c7-4d65-4c13-9a2b-2aa18652ea55", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26b00550-c5dd-4360-8b14-ea893c8cddc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b41aaee-695e-49e6-aa4e-2289c6f4512c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f5a672-da81-4012-8ed5-0f5f9f2f18e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2417e87-0263-469a-9139-91f3d3d8328a");

            migrationBuilder.DropColumn(
                name: "Students",
                table: "Classes");

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
                    { "0fd07628-4e36-44f9-a781-0628ae7c7a7f", "6c8149c8-aa27-4f30-9be8-4d52590d2f1a", "Admin", "ADMIN" },
                    { "5598022b-5b16-468e-b436-124c15efa49f", "0bd5d6a1-2589-4b18-9cfa-c876b1d99507", "Teacher", "TEACHER" },
                    { "fcf338cd-e9cc-4277-8c56-fb478078edec", "9995c5e7-06a0-4446-8fa3-9b84715ffc1f", "Student", "STUDENT" },
                    { "c76ab141-19f7-438f-a5cf-876bf6e1f0e9", "17d82df9-4972-4c73-a4de-f5839bc9de1d", "Manager", "MANAGER" }
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
