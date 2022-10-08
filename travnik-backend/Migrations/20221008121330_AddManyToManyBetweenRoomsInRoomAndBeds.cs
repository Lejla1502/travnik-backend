using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddManyToManyBetweenRoomsInRoomAndBeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomsInRoomBeds",
                columns: table => new
                {
                    RoomsInRoomId = table.Column<int>(type: "int", nullable: false),
                    BedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsInRoomBeds", x => new { x.RoomsInRoomId, x.BedId });
                    table.ForeignKey(
                        name: "FK_RoomsInRoomBeds_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomsInRoomBeds_RoomsInRoom_RoomsInRoomId",
                        column: x => x.RoomsInRoomId,
                        principalTable: "RoomsInRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomsInRoomBeds_BedId",
                table: "RoomsInRoomBeds",
                column: "BedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomsInRoomBeds");
        }
    }
}
