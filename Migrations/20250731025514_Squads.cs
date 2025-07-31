using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarReverieCore.Migrations
{
    /// <inheritdoc />
    public partial class Squads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SquadId",
                table: "Characters",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SquadId",
                table: "Characters",
                column: "SquadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Squads_SquadId",
                table: "Characters",
                column: "SquadId",
                principalTable: "Squads",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Squads_SquadId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.DropIndex(
                name: "IX_Characters_SquadId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SquadId",
                table: "Characters");
        }
    }
}
