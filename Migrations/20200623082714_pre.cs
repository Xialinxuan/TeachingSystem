using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class pre : Migration
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
                    { "cb22791d-1526-4845-b24c-a6d553ac2a98", "98370bd7-2a80-44a5-9e1e-00bb6f3d0ba1", "Admin", "ADMIN" },
                    { "a271acc0-30ae-4e3d-a2cc-b74d7568ca02", "733836f4-fa46-4bd4-b1a8-0923c5d3ebff", "Teacher", "TEACHER" },
                    { "0ca0a2fe-c8e9-4554-ac83-5d1638c39f92", "d92e795c-179d-4c1a-b89a-88a8024e03ab", "Student", "STUDENT" },
                    { "5fdef226-d5c1-4acd-8e00-ec643593ac1a", "4aea5dde-bb74-41ae-a29a-ca2136eccd60", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca0a2fe-c8e9-4554-ac83-5d1638c39f92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fdef226-d5c1-4acd-8e00-ec643593ac1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a271acc0-30ae-4e3d-a2cc-b74d7568ca02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb22791d-1526-4845-b24c-a6d553ac2a98");

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
                    { "01907824-fce4-46b5-99e1-a2bb5c967905", "90cf20c2-0556-4ca4-9f3d-d0e4984815df", "Admin", "ADMIN" },
                    { "1f77af71-f72c-4dc9-9b13-b38db219183a", "dda333e7-7fd5-4723-ad4a-f49a78a46931", "Teacher", "TEACHER" },
                    { "784b6b7b-84e0-4497-89ce-6b8ca7772901", "57648568-3e3b-4d6c-996c-b37522ffd289", "Student", "STUDENT" },
                    { "a7033eeb-e0bd-4aa6-9a0b-5b33f304cc34", "e863109c-e4f3-49bc-84c4-26ab30ad0f8d", "Manager", "MANAGER" }
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
