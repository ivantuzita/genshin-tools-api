using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenshinToolsAPI.Migrations
{
    /// <inheritdoc />
    public partial class usercharacterstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserCharacters",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCharacters");
        }
    }
}
