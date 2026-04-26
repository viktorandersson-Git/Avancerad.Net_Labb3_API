using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avancerad.Net_Labb3_API.Migrations
{
    /// <inheritdoc />
    public partial class addedDTOs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserInterestId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserInterestId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserInterestId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Links_UserInterestId",
                table: "Links",
                column: "UserInterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_UserInterests_UserInterestId",
                table: "Links",
                column: "UserInterestId",
                principalTable: "UserInterests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_UserInterests_UserInterestId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_UserInterestId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "UserInterestId",
                table: "Links");
        }
    }
}
