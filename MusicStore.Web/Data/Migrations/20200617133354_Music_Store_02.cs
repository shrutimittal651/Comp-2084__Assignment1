using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStore.Web.Data.Migrations
{
    public partial class Music_Store_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Album_AlbumKey",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_AlbumKey",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "AlbumKey",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Song",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumId",
                table: "Song",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Album_AlbumId",
                table: "Song",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "AlbumID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Album_AlbumId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_AlbumId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "AlbumKey",
                table: "Song",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumKey",
                table: "Song",
                column: "AlbumKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Album_AlbumKey",
                table: "Song",
                column: "AlbumKey",
                principalTable: "Album",
                principalColumn: "AlbumID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
