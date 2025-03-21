using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GolovicWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedPortfolioItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PortfolioItems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "ProjectUrl" },
                values: new object[,]
                {
                    { 1, "A cat-motivated Tetris game for Windows featuring 20 blocks, standard tetrominoes, and an original BPS scoring systema.", "/images/meowtris.jpg", "Meowtris", "https://github.com/igolovic/meowtris" },
                    { 3, "Cross-platform GUI desktop application that compares files in two folders based on size and binary content, identifying matches and unique files.", "/images/cmpbin.jpg", "CmpBin", "https://github.com/igolovic/cmpbin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
