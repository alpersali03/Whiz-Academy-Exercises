using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FootballChampionship.Migrations
{
    /// <inheritdoc />
    public partial class FixingBugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "England", "Premier League" },
                    { 2, "Spain", "La Liga" },
                    { 3, "Italy", "Serie A" },
                    { 4, "Germany", "Bundesliga" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "FoundedYear", "LeagueId", "Name", "Stadium" },
                values: new object[,]
                {
                    { 1, 1878, 1, "Manchester United", "Old Trafford" },
                    { 2, 1892, 1, "Liverpool", "Anfield" },
                    { 3, 1902, 2, "Real Madrid", "Santiago Bernabéu" },
                    { 4, 1899, 2, "Barcelona", "Camp Nou" },
                    { 5, 1897, 3, "Juventus", "Allianz Stadium" },
                    { 6, 1899, 3, "AC Milan", "San Siro" },
                    { 7, 1900, 4, "Bayern Munich", "Allianz Arena" },
                    { 8, 1909, 4, "Borussia Dortmund", "Signal Iduna Park" }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayScore", "AwayTeamId", "HomeScore", "HomeTeamId", "LeagueId", "MatchDate" },
                values: new object[,]
                {
                    { 1, 1, 2, 2, 1, 1, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 4, 3, 3, 2, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 6, 1, 5, 3, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, 8, 4, 7, 4, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "Name", "Nationality", "Position", "TeamId" },
                values: new object[,]
                {
                    { 1, 39, "Cristiano Ronaldo", "Portugal", "Forward", 3 },
                    { 2, 36, "Lionel Messi", "Argentina", "Forward", 4 },
                    { 3, 29, "Bruno Fernandes", "Portugal", "Midfielder", 1 },
                    { 4, 32, "Virgil van Dijk", "Netherlands", "Defender", 2 },
                    { 5, 30, "Paulo Dybala", "Argentina", "Forward", 5 },
                    { 6, 42, "Zlatan Ibrahimovic", "Sweden", "Forward", 6 },
                    { 7, 35, "Robert Lewandowski", "Poland", "Forward", 7 },
                    { 8, 23, "Erling Haaland", "Norway", "Forward", 8 }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "MatchId", "Minute", "PlayerId" },
                values: new object[,]
                {
                    { 1, 1, 30, 3 },
                    { 2, 1, 45, 4 },
                    { 3, 2, 50, 1 },
                    { 4, 2, 75, 2 },
                    { 5, 3, 60, 5 },
                    { 6, 3, 80, 6 },
                    { 7, 4, 20, 7 },
                    { 8, 4, 90, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
