using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestYoubim.Migrations
{
    public partial class InitialMIgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Node",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdUser = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    VersionFile = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Node", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Node");
        }
    }
}
