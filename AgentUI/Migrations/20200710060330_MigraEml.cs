using Microsoft.EntityFrameworkCore.Migrations;

namespace AgentUI.Migrations
{
    public partial class MigraEml : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertID = table.Column<int>(type: "int", nullable: false),
                    BuildFloor = table.Column<int>(type: "int", nullable: false),
                    NumberOfRoom = table.Column<int>(type: "int", nullable: false),
                    SquareMeters = table.Column<int>(type: "int", nullable: false),
                    TotalFloor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AdvertDetails_Adverts_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Adverts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertDetails_AdvertID",
                table: "AdvertDetails",
                column: "AdvertID",
                unique: true);
        }
    }
}
