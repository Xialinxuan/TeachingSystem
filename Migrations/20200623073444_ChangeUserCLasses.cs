using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class ChangeUserCLasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_UserClasses_UserClassesId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_UserClassesId",
                table: "Classes");

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
                name: "UserClassesId",
                table: "Classes");

            migrationBuilder.AddColumn<List<string>>(
                name: "ClassesId",
                table: "UserClasses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "afea13bd-b6bc-40e5-b1df-936052310a76", "34162b8b-80bf-4946-b434-b5a46604d352", "Admin", "ADMIN" },
                    { "8656801b-2a25-4c47-81ab-8d5e82214bc0", "abec6b54-f27b-42c0-afe7-a6e094d24eac", "Teacher", "TEACHER" },
                    { "32f785ac-d64c-48fe-8415-69a49f96bb37", "a254f4e4-29c8-4c66-bad4-5f92ec766557", "Student", "STUDENT" },
                    { "d6305f11-c32d-457b-b69d-1717367c6930", "ad5103fa-c46e-43ee-853d-fdcecff64bbc", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32f785ac-d64c-48fe-8415-69a49f96bb37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8656801b-2a25-4c47-81ab-8d5e82214bc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afea13bd-b6bc-40e5-b1df-936052310a76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6305f11-c32d-457b-b69d-1717367c6930");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "UserClasses");

            migrationBuilder.AddColumn<long>(
                name: "UserClassesId",
                table: "Classes",
                type: "bigint",
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

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UserClassesId",
                table: "Classes",
                column: "UserClassesId");

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
