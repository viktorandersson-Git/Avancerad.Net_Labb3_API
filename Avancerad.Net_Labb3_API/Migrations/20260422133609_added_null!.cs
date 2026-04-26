using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Avancerad.Net_Labb3_API.Migrations
{
    /// <inheritdoc />
    public partial class added_null : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Koda och bygga system", "Programmering" },
                    { 2, "Snabba sportbilar", "Bilar" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "anna@example.com", "Anna Andersson", "0701234567" },
                    { 2, "bjorn@example.com", "Björn Borg", "0709876543" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "InterestId", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "https://learn.microsoft.com", 1 },
                    { 2, 2, "https://www.topgear.com", 1 },
                    { 3, 1, "https://stackoverflow.com", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInterests",
                columns: new[] { "Id", "InterestId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserInterests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserInterests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserInterests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
