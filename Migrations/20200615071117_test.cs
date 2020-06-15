using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07eb93d9-4301-4511-8f4c-db7690b12f66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aeb340b-a5a7-447c-a73f-fe4e176b71f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76cf9b9a-9b15-44e8-8a9f-d556262623ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d55c0c4a-4fb2-47ed-ac1e-034966eef966");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7784619-63d9-46d1-afdd-0035b4e607fb", "f56e0824-6c5c-4a1d-afc2-2b1420853261", "Admin", "ADMIN" },
                    { "15fbdb29-11f1-48cb-89c5-023cc5112aad", "6fc20187-725d-4a6c-a559-e88462349d4b", "Teacher", "TEACHER" },
                    { "61e3b7c9-eff0-4893-b515-4cf516b6608b", "4d95bef7-0e52-4b2a-8681-39e68716be3f", "Student", "STUDENT" },
                    { "059dba58-ba18-45ff-80b4-02bfa7861a56", "470775d7-fd66-484c-88b8-6dcb034b5505", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "059dba58-ba18-45ff-80b4-02bfa7861a56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15fbdb29-11f1-48cb-89c5-023cc5112aad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61e3b7c9-eff0-4893-b515-4cf516b6608b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7784619-63d9-46d1-afdd-0035b4e607fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76cf9b9a-9b15-44e8-8a9f-d556262623ab", "1e4e205a-c334-4606-8c9e-4d16c4de8c02", "Admin", "ADMIN" },
                    { "d55c0c4a-4fb2-47ed-ac1e-034966eef966", "4af0fa6e-6172-4870-99c8-3ebbe2bdd194", "Teacher", "TEACHER" },
                    { "07eb93d9-4301-4511-8f4c-db7690b12f66", "0909f8a1-39a9-466e-8790-1f3ccaae4e65", "Student", "STUDENT" },
                    { "4aeb340b-a5a7-447c-a73f-fe4e176b71f0", "7bdcc98e-7dbe-43de-8bca-8cb7ff8fcfd9", "Manager", "MANAGER" }
                });
        }
    }
}
