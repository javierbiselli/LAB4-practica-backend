using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Director_Function_FunctionId",
                table: "Director");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Function_FunctionId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_FunctionId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Director_FunctionId",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "FunctionId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "FunctionId",
                table: "Director");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Function",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Function_MovieId",
                table: "Function",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Function_Movie_MovieId",
                table: "Function",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Function_Movie_MovieId",
                table: "Function");

            migrationBuilder.DropIndex(
                name: "IX_Function_MovieId",
                table: "Function");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Function");

            migrationBuilder.AddColumn<int>(
                name: "FunctionId",
                table: "Movie",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FunctionId",
                table: "Director",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_FunctionId",
                table: "Movie",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_FunctionId",
                table: "Director",
                column: "FunctionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Director_Function_FunctionId",
                table: "Director",
                column: "FunctionId",
                principalTable: "Function",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Function_FunctionId",
                table: "Movie",
                column: "FunctionId",
                principalTable: "Function",
                principalColumn: "Id");
        }
    }
}
