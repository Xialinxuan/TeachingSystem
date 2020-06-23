using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeachingSystem.Migrations
{
    public partial class applies : Migration
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
                    { "31f1e846-4bee-43f5-b4e3-6d1743a469c9", "ba8994db-7594-4543-8bd0-dd312e02e12c", "Admin", "ADMIN" },
                    { "05a25a05-c6eb-4c29-80a0-45cd26b2754e", "367fa378-434f-453f-be19-5cf8c044735c", "Teacher", "TEACHER" },
                    { "40d39ac6-3bad-4ddf-8775-7dc2987e397d", "35dd9db8-3651-428c-88ee-5f03f1d031e3", "Student", "STUDENT" },
                    { "c5a29d09-81f8-40cd-be53-ce030576e3d5", "1970c364-2b94-4f38-aae7-e06e7e9d1be2", "Manager", "MANAGER" }
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
