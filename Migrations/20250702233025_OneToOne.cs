using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarReverieCore.Migrations
{
    /// <inheritdoc />
    public partial class OneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttributeScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Strength = table.Column<int>(type: "INTEGER", nullable: false),
                    Dexterity = table.Column<int>(type: "INTEGER", nullable: false),
                    Intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    Constitution = table.Column<int>(type: "INTEGER", nullable: false),
                    HP = table.Column<int>(type: "INTEGER", nullable: false),
                    Will = table.Column<int>(type: "INTEGER", nullable: false),
                    Perception = table.Column<int>(type: "INTEGER", nullable: false),
                    Stamina = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<decimal>(type: "TEXT", nullable: false),
                    BasicMove = table.Column<int>(type: "INTEGER", nullable: false),
                    XP = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeScores_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeScores_Characters_CharacterId1",
                        column: x => x.CharacterId1,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeScores_CharacterId",
                table: "AttributeScores",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeScores_CharacterId1",
                table: "AttributeScores",
                column: "CharacterId1",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeScores");
        }
    }
}
