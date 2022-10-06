using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddOneToOneBetweenRoomNameAndRoomNameDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfBedsOfThisType",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.CreateTable(
                name: "RoomNameDetails",
                columns: table => new
                {
                    RoomNameDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumOfBedrooms = table.Column<int>(type: "int", nullable: false),
                    NumOfLivingrooms = table.Column<int>(type: "int", nullable: false),
                    NumOfBathrooms = table.Column<int>(type: "int", nullable: false),
                    RoomNameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomNameDetails", x => x.RoomNameDetailsId);
                    table.ForeignKey(
                        name: "FK_RoomNameDetails_RoomNames_RoomNameId",
                        column: x => x.RoomNameId,
                        principalTable: "RoomNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomNameDetails_RoomNameId",
                table: "RoomNameDetails",
                column: "RoomNameId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomNameDetails");

            migrationBuilder.AddColumn<int>(
                name: "NumOfBedsOfThisType",
                table: "AccomodationRoomNameBeds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
