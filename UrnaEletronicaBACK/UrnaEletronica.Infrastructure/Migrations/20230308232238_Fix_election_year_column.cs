using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrnaEletronica.Infrastructure.Migrations
{
    public partial class Fix_election_year_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "ElectionYear",
                table: "Elections",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "ElectionYear",
                table: "Elections",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }
    }
}
