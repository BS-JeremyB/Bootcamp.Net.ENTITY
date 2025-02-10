using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bootcamp.Net.ENTITY.Exo.Migrations
{
    /// <inheritdoc />
    public partial class Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActeurPrincipal",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Realisateur",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "RealisateurId",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmPersonnes",
                columns: table => new
                {
                    PersonneId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmPersonnes", x => new { x.FilmId, x.PersonneId });
                    table.ForeignKey(
                        name: "FK_FilmPersonnes_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmPersonnes_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                column: "RealisateurId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                column: "RealisateurId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                column: "RealisateurId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                column: "RealisateurId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                column: "RealisateurId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6,
                column: "RealisateurId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7,
                column: "RealisateurId",
                value: 9);

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, "Wood", "Elijah" },
                    { 2, "Hunnam", "Charlie" },
                    { 3, "Ford", "Harisson" },
                    { 4, "Hammil", "Mark" },
                    { 5, "Fisher", "Carrie" },
                    { 6, "Mortensen", "Vigo" },
                    { 7, "Bloom", "Orlando" },
                    { 8, "Alexander", "Lexi" },
                    { 9, "Jackson", "Peter" },
                    { 10, "Lucas", "Georges" }
                });

            migrationBuilder.InsertData(
                table: "FilmPersonnes",
                columns: new[] { "FilmId", "PersonneId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 1 },
                    { 4, 2 },
                    { 5, 1 },
                    { 5, 6 },
                    { 5, 7 },
                    { 6, 1 },
                    { 6, 6 },
                    { 6, 7 },
                    { 7, 1 },
                    { 7, 6 },
                    { 7, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_RealisateurId",
                table: "Films",
                column: "RealisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmPersonnes_PersonneId",
                table: "FilmPersonnes",
                column: "PersonneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Personnes_RealisateurId",
                table: "Films",
                column: "RealisateurId",
                principalTable: "Personnes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Personnes_RealisateurId",
                table: "Films");

            migrationBuilder.DropTable(
                name: "FilmPersonnes");

            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropIndex(
                name: "IX_Films_RealisateurId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "RealisateurId",
                table: "Films");

            migrationBuilder.AddColumn<string>(
                name: "ActeurPrincipal",
                table: "Films",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Realisateur",
                table: "Films",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActeurPrincipal", "Realisateur" },
                values: new object[] { "Mark Hammil", "Georges Lucas" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActeurPrincipal", "Realisateur" },
                values: new object[] { "Mark Hammil", "Georges Lucas" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActeurPrincipal", "Realisateur" },
                values: new object[] { "Mark Hammil", "Georges Lucas" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActeurPrincipal", "Realisateur" },
                values: new object[] { "Charlie Hunnam", "Lexi Alexander" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActeurPrincipal", "Realisateur" },
                values: new object[] { "Elijah Wood", "Peter Jackson" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActeurPrincipal", "Realisateur" },
                values: new object[] { "Elijah Wood", "Peter Jackson" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActeurPrincipal", "Realisateur" },
                values: new object[] { "Elijah Wood", "Peter Jackson" });
        }
    }
}
