using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddNumberOfBedsToRoomsInRoomBeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfBeds",
                table: "RoomsInRoomBeds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfOtherSpaces",
                table: "RoomNameDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfBeds",
                table: "RoomsInRoomBeds");

            migrationBuilder.DropColumn(
                name: "NumOfOtherSpaces",
                table: "RoomNameDetails");
        }
    }
}
