using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrnaEletronica.Infrastructure.Migrations
{
    public partial class Password_Citizen_VO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Zipcode",
                table: "Addresses",
                type: "char(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(9)",
                oldMaxLength: 9,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Zipcode",
                table: "Addresses",
                type: "char(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(9)",
                oldMaxLength: 9);
        }
    }
}
