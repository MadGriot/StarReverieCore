using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarReverieCore.Migrations
{
    /// <inheritdoc />
    public partial class AddingBasicLift : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeScores_Characters_CharacterId1",
                table: "AttributeScores");

            migrationBuilder.DropIndex(
                name: "IX_AttributeScores_CharacterId1",
                table: "AttributeScores");

            migrationBuilder.DropColumn(
                name: "CharacterId1",
                table: "AttributeScores");

            migrationBuilder.AddColumn<int>(
                name: "BasicLift",
                table: "AttributeScores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasicLift",
                table: "AttributeScores");

            migrationBuilder.AddColumn<int>(
                name: "CharacterId1",
                table: "AttributeScores",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeScores_CharacterId1",
                table: "AttributeScores",
                column: "CharacterId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeScores_Characters_CharacterId1",
                table: "AttributeScores",
                column: "CharacterId1",
                principalTable: "Characters",
                principalColumn: "Id");
        }
    }
}
