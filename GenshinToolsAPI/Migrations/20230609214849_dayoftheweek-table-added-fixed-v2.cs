using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenshinToolsAPI.Migrations
{
    /// <inheritdoc />
    public partial class dayoftheweektableaddedfixedv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DaysOfWeek",
                table: "DaysOfWeek");

            migrationBuilder.RenameColumn(
                name: "DayOfWeek",
                table: "DaysOfWeek",
                newName: "WeekDayId");

            migrationBuilder.AlterColumn<int>(
                name: "WeekDayId",
                table: "DaysOfWeek",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeekDayId",
                table: "DaysOfWeek",
                newName: "DayOfWeek");

            migrationBuilder.AlterColumn<int>(
                name: "DayOfWeek",
                table: "DaysOfWeek",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DaysOfWeek",
                table: "DaysOfWeek",
                column: "DayOfWeek");
        }
    }
}
