using Microsoft.EntityFrameworkCore.Migrations;

namespace Projektuppgift_CSharp_ASP.NET.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 70, nullable: true),
                    Category = table.Column<string>(type: "TEXT", maxLength: 70, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Length = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 499, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
