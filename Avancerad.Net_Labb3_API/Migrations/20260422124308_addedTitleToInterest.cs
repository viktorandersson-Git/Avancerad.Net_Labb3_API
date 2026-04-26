using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avancerad.Net_Labb3_API.Migrations
{
    /// <inheritdoc />
    public partial class addedTitleToInterest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Interests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Interests");
        }
    }
}
