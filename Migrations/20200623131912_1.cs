using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class _1 : Migration
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
                keyValue: "29643f0d-fb6c-476d-af37-b98eb6675b15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6dddb857-c17c-4212-aa0c-f50e9b6b9c93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96395183-851f-4285-a24e-3c08723b3d04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff020545-0123-4f7f-bb97-d8d53e8c8758");

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
                    { "6b46192a-1464-4215-b682-ab8ef35fe2d7", "29c1845b-c007-4823-8686-90a9f18c7768", "Admin", "ADMIN" },
                    { "aa4d3221-86eb-495d-83a2-ce549f3b2d0f", "df92c243-a7f6-4cf5-8514-eaabdc655116", "Teacher", "TEACHER" },
                    { "5fb758af-a2f7-4b87-b15c-92b1ce6411d2", "34b5f89c-7267-4875-89e4-ad477e283b5b", "Student", "STUDENT" },
                    { "01b089bf-a054-4bbf-a01f-57b05c1005f4", "33382b98-e6fc-4761-9ff3-af762f5f1f9c", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01b089bf-a054-4bbf-a01f-57b05c1005f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fb758af-a2f7-4b87-b15c-92b1ce6411d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b46192a-1464-4215-b682-ab8ef35fe2d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa4d3221-86eb-495d-83a2-ce549f3b2d0f");

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
                    { "29643f0d-fb6c-476d-af37-b98eb6675b15", "38c3fdcd-38e5-4d59-9f13-b2737567ce8e", "Admin", "ADMIN" },
                    { "96395183-851f-4285-a24e-3c08723b3d04", "5e7de6bb-338d-485d-82ef-7fa43f88b87c", "Teacher", "TEACHER" },
                    { "6dddb857-c17c-4212-aa0c-f50e9b6b9c93", "2b8122bf-f418-4ad1-bf18-858f24097fd9", "Student", "STUDENT" },
                    { "ff020545-0123-4f7f-bb97-d8d53e8c8758", "091a4966-efdf-4b81-8b53-0f97a0e50781", "Manager", "MANAGER" }
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
