using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Labb4.Migrations
{
    public partial class SeconMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Interest",
                columns: new[] { "InterestID", "Description", "Title" },
                values: new object[,]
                {
                    { 4, "Escaping the real world for some time", "Reading" },
                    { 5, "Expressing creativity through colors and brushstrokes", "Painting" },
                    { 6, "Crafting stories, poems, or articles to convey thoughts and emotions", "Writing" },
                    { 7, "Engaging in physical activities to stay fit and competitive", "Sports" },
                    { 8, "Cultivating plants and flowers to create beautiful outdoor spaces", "Gardening" },
                    { 9, "Playing instruments or singing to create melodies and evoke emotions", "Music" },
                    { 10, "Moving rhythmically to music, expressing oneself through body movements", "Dancing" },
                    { 11, "Exploring natural landscapes on foot, enjoying scenic views and fresh air", "Hiking" },
                    { 12, "Practicing mindfulness, flexibility, and relaxation through physical postures and breathing exercises", "Yoga" }
                });

            migrationBuilder.InsertData(
                table: "Link",
                columns: new[] { "LinkID", "LinkName", "LinkURL" },
                values: new object[,]
                {
                    { 4, "Goodreads", "https://www.goodreads.com" },
                    { 5, "Artists Network", "https://www.artistsnetwork.com" },
                    { 6, "Medium", "https://medium.com" },
                    { 7, "ESPN", "https://www.espn.com" },
                    { 8, "The Spruce", "https://www.thespruce.com" },
                    { 9, "Spotify", "https://www.spotify.com" },
                    { 10, "Dance Spirit", "https://www.dancespirit.com" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonID", "PersonLName", "PersonName", "PhoneNumber" },
                values: new object[,]
                {
                    { 4, "Johnson", "Emily", "555-987" },
                    { 5, "Brown", "Michael", "555-456" },
                    { 6, "Davis", "Olivia", "555-789" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Interest",
                keyColumn: "InterestID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "LinkID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "LinkID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "LinkID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "LinkID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "LinkID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "LinkID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "LinkID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonID",
                keyValue: 6);
        }
    }
}
