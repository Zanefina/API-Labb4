using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Labb4.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interest",
                columns: table => new
                {
                    InterestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interest", x => x.InterestID);
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    LinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.LinkID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "PersonInterest",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestID = table.Column<int>(type: "int", nullable: false),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    LinkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInterest", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PersonInterest_Interest_InterestID",
                        column: x => x.InterestID,
                        principalTable: "Interest",
                        principalColumn: "InterestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonInterest_Link_LinkID",
                        column: x => x.LinkID,
                        principalTable: "Link",
                        principalColumn: "LinkID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonInterest_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Interest",
                columns: new[] { "InterestID", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Capturing moments throught pictures", "Photography" },
                    { 2, "Exploring new places and new cultures", "Travel" },
                    { 3, "Preparing and sharing delicious meals", "Cooking" }
                });

            migrationBuilder.InsertData(
                table: "Link",
                columns: new[] { "LinkID", "LinkName", "LinkURL" },
                values: new object[,]
                {
                    { 1, "Instagram Profile", "https://www.instagram.com" },
                    { 2, "Lonely Planet Website", "https://www.lonelyplanter.com" },
                    { 3, "Food Website", "https://www.foodnetwork.com" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonID", "PersonLName", "PersonName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Smith", "John", "555-123" },
                    { 2, "Doe", "Jane", "555-678" },
                    { 3, "Johnsson", "David", "555-345" }
                });

            migrationBuilder.InsertData(
                table: "PersonInterest",
                columns: new[] { "ID", "InterestID", "LinkID", "PersonID" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "PersonInterest",
                columns: new[] { "ID", "InterestID", "LinkID", "PersonID" },
                values: new object[] { 2, 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "PersonInterest",
                columns: new[] { "ID", "InterestID", "LinkID", "PersonID" },
                values: new object[] { 3, 3, 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterest_InterestID",
                table: "PersonInterest",
                column: "InterestID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterest_LinkID",
                table: "PersonInterest",
                column: "LinkID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterest_PersonID",
                table: "PersonInterest",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonInterest");

            migrationBuilder.DropTable(
                name: "Interest");

            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
