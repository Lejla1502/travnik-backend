using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddManyToManyBetweenBedAndRoomName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedRoomType");

            migrationBuilder.CreateTable(
                name: "BedRoomName",
                columns: table => new
                {
                    BedId = table.Column<int>(type: "int", nullable: false),
                    RoomNameId = table.Column<int>(type: "int", nullable: false),
                    NumberOfBedForThisRoom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedRoomName", x => new { x.BedId, x.RoomNameId });
                    table.ForeignKey(
                        name: "FK_BedRoomName_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BedRoomName_RoomNames_RoomNameId",
                        column: x => x.RoomNameId,
                        principalTable: "RoomNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BedRoomName_RoomNameId",
                table: "BedRoomName",
                column: "RoomNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedRoomName");

            migrationBuilder.CreateTable(
                name: "BedRoomType",
                columns: table => new
                {
                    BedsId = table.Column<int>(type: "int", nullable: false),
                    RoomTypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedRoomType", x => new { x.BedsId, x.RoomTypesId });
                    table.ForeignKey(
                        name: "FK_BedRoomType_Beds_BedsId",
                        column: x => x.BedsId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BedRoomType_RoomTypes_RoomTypesId",
                        column: x => x.RoomTypesId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BedRoomType_RoomTypesId",
                table: "BedRoomType",
                column: "RoomTypesId");
        }
    }
}
