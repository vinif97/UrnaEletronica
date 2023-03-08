using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrnaEletronica.Infrastructure.Migrations
{
    public partial class Election_configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ElectionCycles_ElectionId",
                table: "ElectionCycles");

            migrationBuilder.AlterColumn<byte>(
                name: "ElectionYear",
                table: "Elections",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "PoliticalRole",
                table: "ElectionCycles",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Elections_ElectionYear",
                table: "Elections",
                column: "ElectionYear",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectionCycles_ElectionId_PoliticalRole",
                table: "ElectionCycles",
                columns: new[] { "ElectionId", "PoliticalRole" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Elections_ElectionYear",
                table: "Elections");

            migrationBuilder.DropIndex(
                name: "IX_ElectionCycles_ElectionId_PoliticalRole",
                table: "ElectionCycles");

            migrationBuilder.AlterColumn<int>(
                name: "ElectionYear",
                table: "Elections",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "PoliticalRole",
                table: "ElectionCycles",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionCycles_ElectionId",
                table: "ElectionCycles",
                column: "ElectionId");
        }
    }
}
