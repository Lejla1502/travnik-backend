using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddMAnyToManyBetweenAccomodationRoomNameAndRoomFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccomodationRoomNameRoomFeatures",
                columns: table => new
                {
                    AccomodationRoomNamesId = table.Column<int>(type: "int", nullable: false),
                    RoomFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationRoomNameRoomFeatures", x => new { x.AccomodationRoomNamesId, x.RoomFeaturesId });
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNameRoomFeatures_AccomodationRoomNames_AccomodationRoomNamesId",
                        column: x => x.AccomodationRoomNamesId,
                        principalTable: "AccomodationRoomNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNameRoomFeatures_RoomFeatures_RoomFeaturesId",
                        column: x => x.RoomFeaturesId,
                        principalTable: "RoomFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationRoomNameRoomFeatures_RoomFeaturesId",
                table: "AccomodationRoomNameRoomFeatures",
                column: "RoomFeaturesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationRoomNameRoomFeatures");
        }
    }
}
