using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trikotazo_Parduotuve.Migrations
{
    /// <inheritdoc />
    public partial class Suppier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "Phone");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Categories",
                newName: "Description");
        }
    }
}
