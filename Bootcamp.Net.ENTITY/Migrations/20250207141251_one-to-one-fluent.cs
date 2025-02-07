using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bootcamp.Net.ENTITY.Migrations
{
    /// <inheritdoc />
    public partial class onetoonefluent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameDetails_Games_GameId",
                table: "GameDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_GameDetails_Games_GameId",
                table: "GameDetails",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameDetails_Games_GameId",
                table: "GameDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_GameDetails_Games_GameId",
                table: "GameDetails",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
