using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bootcamp.Net.ENTITY.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "IsNew", "PEGI", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 7, "Premier jeu de la série Zelda.", false, 7, 49.99m, new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda" },
                    { 8, "Jeu de plateforme révolutionnaire.", false, 3, 39.99m, new DateTime(1985, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Bros." },
                    { 9, "RPG en monde ouvert.", false, 18, 59.99m, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3" },
                    { 10, "RPG futuriste immersif.", true, 18, 59.99m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077" },
                    { 11, "Jeu en monde ouvert.", false, 18, 59.99m, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Theft Auto V" },
                    { 12, "RPG en monde ouvert légendaire.", false, 16, 49.99m, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skyrim" },
                    { 13, "Aventures historiques en Italie.", false, 18, 39.99m, new DateTime(2009, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed II" },
                    { 14, "FPS en monde ouvert.", false, 18, 44.99m, new DateTime(2012, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Far Cry 3" },
                    { 15, "Aventures western réalistes.", false, 18, 69.99m, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2" },
                    { 16, "Action et exploration en 3D.", false, 12, 29.99m, new DateTime(2002, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Metroid Prime" },
                    { 17, "Jeu de survie", true, 16, 39.99m, new DateTime(2013, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
