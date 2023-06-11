using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenshinToolsAPI.Migrations
{
    /// <inheritdoc />
    public partial class dayoftheweektableaddedfixedv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DaysOfWeek");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "DaysOfWeek",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
