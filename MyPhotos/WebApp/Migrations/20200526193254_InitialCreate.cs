using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Model_App",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    Add_date = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Last_updated = table.Column<DateTime>(nullable: false),
                    Zone = table.Column<string>(nullable: true),
                    Person = table.Column<string>(nullable: true),
                    Event = table.Column<string>(nullable: true),
                    Automobile = table.Column<string>(nullable: true),
                    Other_tags = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model_App", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Model_App");
        }
    }
}
