using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bootcamp.Net.ENTITY.Migrations
{
    /// <inheritdoc />
    public partial class configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Games",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Title",
                table: "Games",
                column: "Title",
                unique: true);

            migrationBuilder.AddCheckConstraint(
                name: "PEGI",
                table: "Games",
                sql: "PEGI IN (3,7,12,16,18)");

            migrationBuilder.AddCheckConstraint(
                name: "Price",
                table: "Games",
                sql: "Price > 0");

            migrationBuilder.AddCheckConstraint(
                name: "ReleaseDate",
                table: "Games",
                sql: "ReleaseDate > '1958-10-18'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_Title",
                table: "Games");

            migrationBuilder.DropCheckConstraint(
                name: "PEGI",
                table: "Games");

            migrationBuilder.DropCheckConstraint(
                name: "Price",
                table: "Games");

            migrationBuilder.DropCheckConstraint(
                name: "ReleaseDate",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
