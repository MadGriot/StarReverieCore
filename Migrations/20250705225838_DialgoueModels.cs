using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarReverieCore.Migrations
{
    /// <inheritdoc />
    public partial class DialgoueModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dialogues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpeakerDialogue = table.Column<string>(type: "TEXT", nullable: false),
                    SpeakerFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    SpeakerMiddleName = table.Column<string>(type: "TEXT", nullable: false),
                    SpeakerLastName = table.Column<string>(type: "TEXT", nullable: false),
                    ParentDialogueId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dialogues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dialogues_Dialogues_ParentDialogueId",
                        column: x => x.ParentDialogueId,
                        principalTable: "Dialogues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dialogues_ParentDialogueId",
                table: "Dialogues",
                column: "ParentDialogueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dialogues");
        }
    }
}
