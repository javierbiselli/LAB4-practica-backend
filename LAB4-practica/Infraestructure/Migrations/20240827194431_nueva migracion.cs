using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class nuevamigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Function_Movie_MovieId",
                table: "Function");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Director_FilmDirectorId",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Function",
                table: "Function");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "Function",
                newName: "Functions");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directors");

            migrationBuilder.RenameColumn(
                name: "FilmDirectorId",
                table: "Movies",
                newName: "DirectorId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_FilmDirectorId",
                table: "Movies",
                newName: "IX_Movies_DirectorId");

            migrationBuilder.RenameIndex(
                name: "IX_Function_MovieId",
                table: "Functions",
                newName: "IX_Functions_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Functions",
                table: "Functions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Functions_Movies_MovieId",
                table: "Functions",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Directors_DirectorId",
                table: "Movies",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Functions_Movies_MovieId",
                table: "Functions");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Directors_DirectorId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Functions",
                table: "Functions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameTable(
                name: "Functions",
                newName: "Function");

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "Director");

            migrationBuilder.RenameColumn(
                name: "DirectorId",
                table: "Movie",
                newName: "FilmDirectorId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_DirectorId",
                table: "Movie",
                newName: "IX_Movie_FilmDirectorId");

            migrationBuilder.RenameIndex(
                name: "IX_Functions_MovieId",
                table: "Function",
                newName: "IX_Function_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Function",
                table: "Function",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Function_Movie_MovieId",
                table: "Function",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Director_FilmDirectorId",
                table: "Movie",
                column: "FilmDirectorId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
