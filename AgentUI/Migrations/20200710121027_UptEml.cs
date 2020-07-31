using Microsoft.EntityFrameworkCore.Migrations;

namespace AgentUI.Migrations
{
    public partial class UptEml : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdvertID",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersID",
                table: "Adverts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_UsersID",
                table: "Adverts",
                column: "UsersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Users_UsersID",
                table: "Adverts",
                column: "UsersID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Users_UsersID",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_UsersID",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "AdvertID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsersID",
                table: "Adverts");
        }
    }
}
