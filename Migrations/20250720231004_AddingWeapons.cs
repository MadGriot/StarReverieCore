using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarReverieCore.Migrations
{
    /// <inheritdoc />
    public partial class AddingWeapons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Weapon = table.Column<int>(type: "INTEGER", nullable: false),
                    WeaponType = table.Column<int>(type: "INTEGER", nullable: false),
                    DamageType = table.Column<int>(type: "INTEGER", nullable: false),
                    Accuracy = table.Column<int>(type: "INTEGER", nullable: false),
                    Range = table.Column<int>(type: "INTEGER", nullable: false),
                    WeaponWeight = table.Column<decimal>(type: "TEXT", nullable: false),
                    AmmoWeight = table.Column<decimal>(type: "TEXT", nullable: false),
                    RoF = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxAmmo = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentAmmo = table.Column<int>(type: "INTEGER", nullable: false),
                    STRRequirement = table.Column<int>(type: "INTEGER", nullable: false),
                    Bulk = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_SkillId",
                table: "Weapons",
                column: "SkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
