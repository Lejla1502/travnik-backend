using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddOneToManyBetweenRoomNameDetailsAndRoomsInRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumOfGuests",
                table: "RoomNameDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RoomsInRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfTheRoom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestsInThisRoom = table.Column<int>(type: "int", nullable: false),
                    PrivateBathroom = table.Column<bool>(type: "bit", nullable: false),
                    RoomNameDetailsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsInRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomsInRoom_RoomNameDetails_RoomNameDetailsId",
                        column: x => x.RoomNameDetailsId,
                        principalTable: "RoomNameDetails",
                        principalColumn: "RoomNameDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomsInRoom_RoomNameDetailsId",
                table: "RoomsInRoom",
                column: "RoomNameDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomsInRoom");

            migrationBuilder.DropColumn(
                name: "NumOfGuests",
                table: "RoomNameDetails");
        }
    }
}
