using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicsHub.Migrations
{
    /// <inheritdoc />
    public partial class Writertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SongId",
                table: "Songs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProducerId",
                table: "Producers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerformerId",
                table: "Performers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_SongId",
                table: "Songs",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Producers_ProducerId",
                table: "Producers",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Performers_PerformerId",
                table: "Performers",
                column: "PerformerId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_AlbumId",
                table: "Albums",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Albums_AlbumId",
                table: "Albums",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Performers_PerformerId",
                table: "Performers",
                column: "PerformerId",
                principalTable: "Performers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producers_Producers_ProducerId",
                table: "Producers",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Songs_SongId",
                table: "Songs",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Albums_AlbumId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Performers_PerformerId",
                table: "Performers");

            migrationBuilder.DropForeignKey(
                name: "FK_Producers_Producers_ProducerId",
                table: "Producers");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Songs_SongId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_SongId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Producers_ProducerId",
                table: "Producers");

            migrationBuilder.DropIndex(
                name: "IX_Performers_PerformerId",
                table: "Performers");

            migrationBuilder.DropIndex(
                name: "IX_Albums_AlbumId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "SongId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "PerformerId",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Albums");
        }
    }
}
