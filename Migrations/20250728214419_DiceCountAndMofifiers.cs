using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarReverieCore.Migrations
{
    /// <inheritdoc />
    public partial class DiceCountAndMofifiers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiceCount",
                table: "Weapons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Modifier",
                table: "Weapons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiceCount",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Modifier",
                table: "Weapons");
        }
    }
}
