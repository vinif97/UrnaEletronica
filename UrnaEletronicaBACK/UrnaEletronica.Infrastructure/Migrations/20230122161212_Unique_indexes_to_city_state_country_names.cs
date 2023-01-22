using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrnaEletronica.Infrastructure.Migrations
{
    public partial class Unique_indexes_to_city_state_country_names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_States_StateName",
                table: "States",
                column: "StateName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CountryName",
                table: "Countries",
                column: "CountryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityName",
                table: "Cities",
                column: "CityName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_States_StateName",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CountryName",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CityName",
                table: "Cities");
        }
    }
}
