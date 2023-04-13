using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace najlepsze_filmy.Migrations
{
    public partial class Migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    RatingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieRatings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieRatings_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Akcja" },
                    { 2, "Komedia" },
                    { 3, "Dramat" },
                    { 4, "Horror" },
                    { 5, "Romans" },
                    { 6, "Przygodowy" },
                    { 7, "Thriller" },
                    { 8, "Sci-Fi" },
                    { 9, "Kryminał" },
                    { 10, "Fantasy" },
                    { 11, "Dokumentalny" },
                    { 12, "Familijny" },
                    { 13, "Animacja" },
                    { 14, "Wojenny" },
                    { 15, "Musical" },
                    { 16, "Historyczny" },
                    { 17, "Przyrodniczy" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Niedostateczna" },
                    { 2, "Dopuszczająca" },
                    { 3, "Dostateczna" },
                    { 4, "Dobra" },
                    { 5, "Bardzo dobra" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Date", "GenreId", "Title" },
                values: new object[,]
                {
                    { 1, "29-Maj-2022", 10, "Władca Pierścieni: Drużyna Pierścienia" },
                    { 2, "29-Maj-2022", 10, "Władca Pierścieni: Dwie wieże" },
                    { 3, "29-Maj-2022", 10, "Władca Pierścieni: Powrót króla" },
                    { 4, "11-Styczeń-2022", 4, "Obecność" },
                    { 5, "20-Styczeń-2022", 10, "Fantastyczne zwierzęta: Tajemnice Dumbledore’a" },
                    { 6, "22-Luty-2022", 1, "Uncharted" },
                    { 7, "01-Marzec-2022", 6, "Piraci z Karaibów: Skrzynia umarlaka" },
                    { 8, "11-Marzec-2022", 4, "Annabelle" },
                    { 9, "18-Marzec-2022", 3, "Joker" },
                    { 10, "24-Kwiecień-2022", 1, "Szybcy i wściekli 9" },
                    { 11, "24-Kwiecień-2022", 10, "Fantastyczne zwierzęta: Zbrodnie Grindelwalda" },
                    { 12, "06-Maj-2022", 1, "Top Gun: Maverick" },
                    { 13, "21-Grudzień-2022", 10, "Hobbit: Niezwykła podróż" },
                    { 14, "22-Grudzień-2022", 10, "Hobbit: Pustkowie Smauga" },
                    { 15, "23-Grudzień-2022", 10, "Hobbit: Bitwa Pięciu Armii" },
                    { 16, "27-Listopad-2022", 6, "King Kong" },
                    { 17, "02-Wrzesień-2022", 8, "Zabójcze maszyny" },
                    { 18, "15-Wrzesień-2022", 6, "Przygody Tintina" },
                    { 19, "14-Czerwiec-2022", 1, "Strażnicy Galaktyki" },
                    { 20, "19-Czerwiec-2022", 10, "Warcraft: Początek" },
                    { 21, "20-Czerwiec-2022", 1, "Thor: Ragnarok" },
                    { 22, "14-Lipiec-2022", 8, "Ewolucja planety małp" },
                    { 23, "14-Sierpień-2022", 8, "Wojna o planetę małp" },
                    { 24, "20-Sierpień-2022", 1, "Doktor Strange" },
                    { 25, "14-Październik-2022", 3, "Życie jest piękne" },
                    { 26, "29-Styczeń-2022", 3, "Green Book" },
                    { 27, "03-Listopad-2022", 2, "Free Guy" },
                    { 28, "14-Listopad-2022", 6, "Wyprawa do dżungli" },
                    { 29, "22-Kwiecień-2022", 6, "Doktor Dolittle" },
                    { 30, "17-Wrzesień-2022", 1, "Venom 2: Carnage" },
                    { 31, "19-Lipiec-2022", 2, "Wasza wysokość" },
                    { 32, "20-lipiec-2022", 2, "Noc w muzeum: Tajemnica grobowca" },
                    { 33, "21-Lipiec-2022", 1, "Raya i ostatni smok" },
                    { 34, "22-Lipiec-2022", 12, "Clifford. Wielki czerwony pies" },
                    { 35, "23-Lipiec-2022", 12, "Fernando" },
                    { 36, "24-Lipiec-2022", 14, "Dunkierka" },
                    { 37, "25-Lipiec-2022", 14, "1917" },
                    { 38, "26-Lipiec-2022", 11, "Sól ziemi" },
                    { 39, "27-Lipiec-2022", 11, "Pina" },
                    { 40, "08-Luty-2022", 5, "Wredne igraszki" },
                    { 41, "10-Luty-2022", 3, "CODA" },
                    { 42, "14-Lipiec-2022", 15, "Kopciuszek" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Date", "GenreId", "Title" },
                values: new object[,]
                {
                    { 43, "11-Lipiec-2022", 2, "Książę w Nowym Jorku 2" },
                    { 44, "23-Luty-2022", 5, "Wieczny singiel" },
                    { 45, "01-Grudzień-2022", 1, "Nie czas umierać" },
                    { 46, "15-Czerwiec-2022", 3, "Czarnobyl 1986" },
                    { 47, "11-Październik-2022", 3, "Sightless" },
                    { 48, "04-Październik-2022", 4, "Brahms: The Boy II" },
                    { 49, "17-Lipiec-2022", 11, "Kiss the Ground" },
                    { 50, "10-Lipiec-2022", 17, "Ośmiornica, nauczycielka życia" },
                    { 51, "26-Grudzień-2022", 6, "Czarna Wdowa" },
                    { 52, "25-Lipiec-2022", 6, "Legion samobójców: The Suicide Squad" },
                    { 53, "26-Maj-2022", 6, "Spider-Man: Bez drogi do domu" }
                });

            migrationBuilder.InsertData(
                table: "MovieRatings",
                columns: new[] { "Id", "MovieId", "RatingId" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 2, 1, 5 },
                    { 3, 1, 5 },
                    { 4, 1, 3 },
                    { 5, 1, 4 },
                    { 6, 2, 4 },
                    { 7, 2, 5 },
                    { 8, 2, 5 },
                    { 9, 3, 5 },
                    { 10, 3, 5 },
                    { 11, 4, 4 },
                    { 12, 4, 3 },
                    { 13, 4, 2 },
                    { 14, 5, 5 },
                    { 15, 5, 5 },
                    { 16, 5, 5 },
                    { 17, 6, 5 },
                    { 18, 6, 4 },
                    { 19, 6, 3 },
                    { 20, 7, 5 },
                    { 21, 7, 5 },
                    { 22, 7, 5 },
                    { 23, 8, 1 },
                    { 24, 8, 5 },
                    { 25, 8, 3 },
                    { 26, 9, 5 },
                    { 27, 9, 4 },
                    { 28, 10, 4 },
                    { 29, 10, 4 },
                    { 30, 11, 5 },
                    { 31, 11, 5 },
                    { 32, 12, 1 },
                    { 33, 12, 1 },
                    { 34, 12, 5 },
                    { 35, 12, 4 },
                    { 36, 12, 3 },
                    { 37, 13, 2 },
                    { 38, 13, 1 },
                    { 39, 14, 4 },
                    { 40, 15, 1 },
                    { 41, 15, 1 },
                    { 42, 16, 5 }
                });

            migrationBuilder.InsertData(
                table: "MovieRatings",
                columns: new[] { "Id", "MovieId", "RatingId" },
                values: new object[,]
                {
                    { 43, 16, 3 },
                    { 44, 16, 2 },
                    { 45, 17, 3 },
                    { 46, 18, 5 },
                    { 47, 18, 4 },
                    { 48, 19, 3 },
                    { 49, 19, 3 },
                    { 50, 19, 3 },
                    { 51, 20, 4 },
                    { 52, 20, 4 },
                    { 53, 21, 5 },
                    { 54, 22, 5 },
                    { 55, 23, 1 },
                    { 56, 24, 4 },
                    { 57, 25, 3 },
                    { 58, 25, 5 },
                    { 59, 26, 2 },
                    { 60, 26, 2 },
                    { 61, 27, 3 },
                    { 62, 27, 4 },
                    { 63, 28, 2 },
                    { 64, 29, 3 },
                    { 65, 30, 5 },
                    { 66, 30, 2 },
                    { 67, 30, 3 },
                    { 68, 31, 3 },
                    { 69, 31, 2 },
                    { 70, 31, 3 },
                    { 71, 32, 4 },
                    { 72, 32, 4 },
                    { 73, 33, 3 },
                    { 74, 33, 1 },
                    { 75, 33, 5 },
                    { 76, 34, 4 },
                    { 77, 35, 4 },
                    { 78, 35, 4 },
                    { 79, 35, 4 },
                    { 80, 35, 4 },
                    { 81, 35, 4 },
                    { 82, 36, 5 },
                    { 83, 36, 5 },
                    { 84, 36, 5 }
                });

            migrationBuilder.InsertData(
                table: "MovieRatings",
                columns: new[] { "Id", "MovieId", "RatingId" },
                values: new object[,]
                {
                    { 85, 36, 5 },
                    { 86, 36, 5 },
                    { 87, 37, 3 },
                    { 88, 37, 2 },
                    { 89, 37, 3 },
                    { 90, 38, 3 },
                    { 91, 38, 3 },
                    { 92, 38, 3 },
                    { 93, 39, 1 },
                    { 94, 39, 1 },
                    { 95, 39, 1 },
                    { 96, 39, 1 },
                    { 97, 40, 2 },
                    { 98, 40, 3 },
                    { 99, 40, 4 },
                    { 100, 40, 2 },
                    { 101, 41, 1 },
                    { 102, 41, 1 },
                    { 103, 41, 1 },
                    { 104, 41, 1 },
                    { 105, 41, 1 },
                    { 106, 41, 1 },
                    { 107, 43, 3 },
                    { 108, 43, 3 },
                    { 109, 43, 3 },
                    { 110, 44, 4 },
                    { 111, 45, 5 },
                    { 112, 45, 5 },
                    { 113, 45, 5 },
                    { 114, 45, 5 },
                    { 115, 45, 5 },
                    { 116, 45, 4 },
                    { 117, 47, 3 },
                    { 118, 47, 4 },
                    { 119, 48, 4 },
                    { 120, 48, 4 },
                    { 121, 48, 4 },
                    { 122, 49, 5 },
                    { 123, 51, 5 },
                    { 124, 51, 5 },
                    { 126, 52, 1 },
                    { 127, 52, 1 }
                });

            migrationBuilder.InsertData(
                table: "MovieRatings",
                columns: new[] { "Id", "MovieId", "RatingId" },
                values: new object[,]
                {
                    { 128, 52, 1 },
                    { 129, 52, 1 },
                    { 130, 53, 5 },
                    { 131, 53, 5 },
                    { 132, 53, 5 },
                    { 133, 53, 5 },
                    { 134, 53, 5 },
                    { 135, 53, 5 },
                    { 136, 53, 5 },
                    { 137, 53, 5 },
                    { 138, 53, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieRatings_MovieId",
                table: "MovieRatings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRatings_RatingId",
                table: "MovieRatings",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieRatings");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
