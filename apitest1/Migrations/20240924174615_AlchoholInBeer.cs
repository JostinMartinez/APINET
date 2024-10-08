using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apitest1.Migrations
{
    /// <inheritdoc />
    public partial class AlchoholInBeer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Alchohol",
                table: "Beers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alchohol",
                table: "Beers");
        }
    }
}
