using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

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
                keyValue: "05a25a05-c6eb-4c29-80a0-45cd26b2754e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31f1e846-4bee-43f5-b4e3-6d1743a469c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40d39ac6-3bad-4ddf-8775-7dc2987e397d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5a29d09-81f8-40cd-be53-ce030576e3d5");

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
                    { "29643f0d-fb6c-476d-af37-b98eb6675b15", "38c3fdcd-38e5-4d59-9f13-b2737567ce8e", "Admin", "ADMIN" },
                    { "96395183-851f-4285-a24e-3c08723b3d04", "5e7de6bb-338d-485d-82ef-7fa43f88b87c", "Teacher", "TEACHER" },
                    { "6dddb857-c17c-4212-aa0c-f50e9b6b9c93", "2b8122bf-f418-4ad1-bf18-858f24097fd9", "Student", "STUDENT" },
                    { "ff020545-0123-4f7f-bb97-d8d53e8c8758", "091a4966-efdf-4b81-8b53-0f97a0e50781", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { "31f1e846-4bee-43f5-b4e3-6d1743a469c9", "ba8994db-7594-4543-8bd0-dd312e02e12c", "Admin", "ADMIN" },
                    { "05a25a05-c6eb-4c29-80a0-45cd26b2754e", "367fa378-434f-453f-be19-5cf8c044735c", "Teacher", "TEACHER" },
                    { "40d39ac6-3bad-4ddf-8775-7dc2987e397d", "35dd9db8-3651-428c-88ee-5f03f1d031e3", "Student", "STUDENT" },
                    { "c5a29d09-81f8-40cd-be53-ce030576e3d5", "1970c364-2b94-4f38-aae7-e06e7e9d1be2", "Manager", "MANAGER" }
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
