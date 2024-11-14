using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeetleMovies.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreMoviesAndDirectors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Adrian Molina" },
                    { 4, "Lee Unkrich" },
                    { 5, "Brad Bird" },
                    { 6, "Peter Ramsey" },
                    { 7, "Bob Persichetti" },
                    { 8, "Rodney Rothman" },
                    { 9, "Makoto Shinkai" },
                    { 10, "Chris Sanders" },
                    { 11, "Dean DeBlois" },
                    { 12, "Angus MacLane" },
                    { 13, "David Fincher" },
                    { 14, "Anthony Russo" },
                    { 15, "Joe Russo" },
                    { 16, "Antoine Fuqua" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 3, 8.4000000000000004, "Coco", 2017 },
                    { 4, 8.0999999999999996, "The Iron Giant", 1999 },
                    { 5, 8.4000000000000004, "Spider-Man - Into the spider-verse", 2018 },
                    { 6, 8.4000000000000004, "Your Name", 2016 },
                    { 7, 8.0999999999999996, "How to Train Your Dragon", 2010 },
                    { 8, 5.7000000000000002, "Lightyear", 2022 },
                    { 9, 7.7999999999999998, "The Girl with the Dragon Tattoo", 2011 },
                    { 10, 8.4000000000000004, "Avengers: Endgame", 2019 },
                    { 11, 7.2000000000000002, "The Equalizer", 2014 }
                });

            migrationBuilder.InsertData(
                table: "DirectorMovie",
                columns: new[] { "DirectorsId", "MoviesId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 5 },
                    { 8, 5 },
                    { 9, 6 },
                    { 10, 7 },
                    { 11, 7 },
                    { 12, 8 },
                    { 13, 9 },
                    { 14, 10 },
                    { 15, 10 },
                    { 16, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
