﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bootcamp.Net.ENTITY.Exo.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "ActeurPrincipal", "AnneeSortie", "Genre", "Realisateur", "Titre" },
                values: new object[,]
                {
                    { 1, "Mark Hammil", 1977, "Science-Fiction", "Georges Lucas", "Star Wars : Un nouvel espoir" },
                    { 2, "Mark Hammil", 1980, "Science-Fiction", "Georges Lucas", "Star Wars : L'empire contre-attaque" },
                    { 3, "Mark Hammil", 1983, "Science-Fiction", "Georges Lucas", "Star Wars : Le retour du Jedi" },
                    { 4, "Charlie Hunnam", 2005, "Société", "Lexi Alexander", "Hooligans" },
                    { 5, "Elijah Wood", 2001, "Heroic-Fantasy", "Peter Jackson", "LOTR - La communauté de l'anneau" },
                    { 6, "Elijah Wood", 2002, "Heroic-Fantasy", "Peter Jackson", "LOTR - Les deux tours" },
                    { 7, "Elijah Wood", 2003, "Heroic-Fantasy", "Peter Jackson", "LOTR - Le retour du roi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
