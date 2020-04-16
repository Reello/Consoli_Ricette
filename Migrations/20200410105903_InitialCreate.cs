using Microsoft.EntityFrameworkCore.Migrations;

namespace Consoli_Ricette.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    authorId = table.Column<string>(nullable: true),
                    authorName = table.Column<string>(nullable: true),
                    difficulty = table.Column<int>(nullable: false),
                    time = table.Column<int>(nullable: false),
                    ingredients = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    procedures = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
