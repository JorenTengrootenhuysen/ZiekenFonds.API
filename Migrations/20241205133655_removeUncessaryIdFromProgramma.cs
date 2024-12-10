using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZiekenFonds.API.Migrations
{
    /// <inheritdoc />
    public partial class removeUncessaryIdFromProgramma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Programma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Programma",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
