using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddManyToManyBetweenAccomodationAndRoomNameWithAdditionalProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccomodationRoomNames",
                columns: table => new
                {
                    AccomodationId = table.Column<int>(type: "int", nullable: false),
                    RoomNameId = table.Column<int>(type: "int", nullable: false),
                    NumOfRoomsOfThisType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationRoomNames", x => new { x.AccomodationId, x.RoomNameId });
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNames_Accomodations_AccomodationId",
                        column: x => x.AccomodationId,
                        principalTable: "Accomodations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNames_RoomNames_RoomNameId",
                        column: x => x.RoomNameId,
                        principalTable: "RoomNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationRoomNames_RoomNameId",
                table: "AccomodationRoomNames",
                column: "RoomNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationRoomNames");
        }
    }
}
