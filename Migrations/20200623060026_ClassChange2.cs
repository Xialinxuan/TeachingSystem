using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class ClassChange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
