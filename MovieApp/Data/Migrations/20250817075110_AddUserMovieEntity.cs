using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUserMovieEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Watched",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Actors",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Awards",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BoxOffice",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImdbID",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImdbRating",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImdbVotes",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Metascore",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Plot",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rated",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Released",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Runtime",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Writer",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UserMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserRating = table.Column<int>(type: "INTEGER", nullable: false),
                    UserDescription = table.Column<string>(type: "TEXT", nullable: false),
                    AmountWatched = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstWatchedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastWatchedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMovies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserMovies_MovieId",
                table: "UserMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMovies_UserId",
                table: "UserMovies",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMovies");

            migrationBuilder.DropColumn(
                name: "Actors",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Awards",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "BoxOffice",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImdbID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImdbRating",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImdbVotes",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Metascore",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Plot",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Rated",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Released",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Runtime",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Writer",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Movies",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Watched",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
