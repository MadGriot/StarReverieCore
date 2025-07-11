using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarReverieCore.Migrations
{
    /// <inheritdoc />
    public partial class SkillToSkillModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "CharacterId1",
                table: "Skills",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterId1",
                table: "Skills",
                column: "CharacterId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Characters_CharacterId1",
                table: "Skills",
                column: "CharacterId1",
                principalTable: "Characters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Characters_CharacterId1",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_CharacterId1",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CharacterId1",
                table: "Skills");

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Characters",
                type: "TEXT",
                nullable: true);
        }
    }
}
