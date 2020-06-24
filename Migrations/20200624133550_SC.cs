using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class SC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Belong",
                table: "SpecialityCourse",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f30cf9b-a828-42be-8ee0-242b9fd61793", "5ab0363d-5c6d-4554-b635-14af8b0aa9d1", "Admin", "ADMIN" },
                    { "cc7cb9a8-41b8-4dd5-9499-15a5e61e2b45", "3df965e8-d2c1-4c64-89cb-c4b405f71587", "Teacher", "TEACHER" },
                    { "83b7b9f2-09f1-4a4d-8d8e-36b1b68c2d1b", "10e4c77f-7fd8-4bc7-9787-44aa705bb8e2", "Student", "STUDENT" },
                    { "b15f4f92-62d2-4cfd-8e4f-533caf29aaad", "5cf8f417-85cd-4d1b-ab3d-e808a88efebd", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f30cf9b-a828-42be-8ee0-242b9fd61793");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83b7b9f2-09f1-4a4d-8d8e-36b1b68c2d1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b15f4f92-62d2-4cfd-8e4f-533caf29aaad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc7cb9a8-41b8-4dd5-9499-15a5e61e2b45");

            migrationBuilder.DropColumn(
                name: "Belong",
                table: "SpecialityCourse");

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
        }
    }
}
