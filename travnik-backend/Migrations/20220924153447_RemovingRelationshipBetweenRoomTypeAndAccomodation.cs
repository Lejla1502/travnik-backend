using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class RemovingRelationshipBetweenRoomTypeAndAccomodation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomNames_Accomodations_AccomodationId",
                table: "RoomNames");

            migrationBuilder.DropIndex(
                name: "IX_RoomNames_AccomodationId",
                table: "RoomNames");

            migrationBuilder.DropColumn(
                name: "AccomodationId",
                table: "RoomNames");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccomodationId",
                table: "RoomNames",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomNames_AccomodationId",
                table: "RoomNames",
                column: "AccomodationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomNames_Accomodations_AccomodationId",
                table: "RoomNames",
                column: "AccomodationId",
                principalTable: "Accomodations",
                principalColumn: "Id");
        }
    }
}
