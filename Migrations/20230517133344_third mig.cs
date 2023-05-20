using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Labb4.Migrations
{
    public partial class thirdmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonInterest_LinkID",
                table: "PersonInterest");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterest_LinkID",
                table: "PersonInterest",
                column: "LinkID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonInterest_LinkID",
                table: "PersonInterest");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterest_LinkID",
                table: "PersonInterest",
                column: "LinkID");
        }
    }
}
