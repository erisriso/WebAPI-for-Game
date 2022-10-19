using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class SkillSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[] { 1, 30, "Mulyadi" });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[] { 2, 10, "Mulyono" });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[] { 3, 50, "Sukirno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
