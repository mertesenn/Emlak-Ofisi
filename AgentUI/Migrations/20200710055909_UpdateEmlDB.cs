using Microsoft.EntityFrameworkCore.Migrations;

namespace AgentUI.Migrations
{
    public partial class UpdateEmlDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuildFloor",
                table: "Adverts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRoom",
                table: "Adverts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SquareMeters",
                table: "Adverts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalFloor",
                table: "Adverts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuildFloor",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "NumberOfRoom",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "SquareMeters",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "TotalFloor",
                table: "Adverts");
        }
    }
}
