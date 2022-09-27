using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddBedRoomNamesToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BedRoomName_Beds_BedId",
                table: "BedRoomName");

            migrationBuilder.DropForeignKey(
                name: "FK_BedRoomName_RoomNames_RoomNameId",
                table: "BedRoomName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BedRoomName",
                table: "BedRoomName");

            migrationBuilder.RenameTable(
                name: "BedRoomName",
                newName: "BedRoomNames");

            migrationBuilder.RenameIndex(
                name: "IX_BedRoomName_RoomNameId",
                table: "BedRoomNames",
                newName: "IX_BedRoomNames_RoomNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BedRoomNames",
                table: "BedRoomNames",
                columns: new[] { "BedId", "RoomNameId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BedRoomNames_Beds_BedId",
                table: "BedRoomNames",
                column: "BedId",
                principalTable: "Beds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BedRoomNames_RoomNames_RoomNameId",
                table: "BedRoomNames",
                column: "RoomNameId",
                principalTable: "RoomNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BedRoomNames_Beds_BedId",
                table: "BedRoomNames");

            migrationBuilder.DropForeignKey(
                name: "FK_BedRoomNames_RoomNames_RoomNameId",
                table: "BedRoomNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BedRoomNames",
                table: "BedRoomNames");

            migrationBuilder.RenameTable(
                name: "BedRoomNames",
                newName: "BedRoomName");

            migrationBuilder.RenameIndex(
                name: "IX_BedRoomNames_RoomNameId",
                table: "BedRoomName",
                newName: "IX_BedRoomName_RoomNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BedRoomName",
                table: "BedRoomName",
                columns: new[] { "BedId", "RoomNameId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BedRoomName_Beds_BedId",
                table: "BedRoomName",
                column: "BedId",
                principalTable: "Beds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BedRoomName_RoomNames_RoomNameId",
                table: "BedRoomName",
                column: "RoomNameId",
                principalTable: "RoomNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
