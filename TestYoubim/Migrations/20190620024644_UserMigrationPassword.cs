using Microsoft.EntityFrameworkCore.Migrations;

namespace TestYoubim.Migrations
{
    public partial class UserMigrationPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlainPassword",
                table: "User",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlainPassword",
                table: "User");
        }
    }
}
