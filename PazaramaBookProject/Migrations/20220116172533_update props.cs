using Microsoft.EntityFrameworkCore.Migrations;

namespace PazaramaBookProject.Migrations
{
    public partial class updateprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GenreImageUrl",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreImageUrl",
                table: "Genres");
        }
    }
}
