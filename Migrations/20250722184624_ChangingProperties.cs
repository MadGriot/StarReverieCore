using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarReverieCore.Migrations
{
    /// <inheritdoc />
    public partial class ChangingProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weapon",
                table: "Weapons");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Weapons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Weapons");

            migrationBuilder.AddColumn<int>(
                name: "Weapon",
                table: "Weapons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
