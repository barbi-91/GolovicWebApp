using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolovicWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddContactMessagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A cat-motivated Tetris game for Windows featuring 20 blocks, standard tetrominoes, and an original BPS scoring system.");

            migrationBuilder.InsertData(
                table: "PortfolioItems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "ProjectUrl" },
                values: new object[] { 2, "Cross-platform GUI desktop application that compares files in two folders based on size and binary content, identifying matches and unique files.", "/images/cmpbin.jpg", "CmpBin", "https://github.com/igolovic/cmpbin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A cat-motivated Tetris game for Windows featuring 20 blocks, standard tetrominoes, and an original BPS scoring systema.");

            migrationBuilder.InsertData(
                table: "PortfolioItems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "ProjectUrl" },
                values: new object[] { 3, "Cross-platform GUI desktop application that compares files in two folders based on size and binary content, identifying matches and unique files.", "/images/cmpbin.jpg", "CmpBin", "https://github.com/igolovic/cmpbin" });
        }
    }
}
