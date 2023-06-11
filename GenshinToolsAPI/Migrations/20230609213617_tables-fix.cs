using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenshinToolsAPI.Migrations
{
    /// <inheritdoc />
    public partial class tablesfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LevelUpWeekDay",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LevelUpWeekDay",
                table: "Characters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LevelUpWeekDay",
                table: "Items",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LevelUpWeekDay",
                table: "Characters",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
