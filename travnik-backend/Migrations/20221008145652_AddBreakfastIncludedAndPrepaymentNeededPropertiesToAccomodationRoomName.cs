using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddBreakfastIncludedAndPrepaymentNeededPropertiesToAccomodationRoomName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BreakfastIncluded",
                table: "AccomodationRoomNames",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PrepaymentNeeded",
                table: "AccomodationRoomNames",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BreakfastIncluded",
                table: "AccomodationRoomNames");

            migrationBuilder.DropColumn(
                name: "PrepaymentNeeded",
                table: "AccomodationRoomNames");
        }
    }
}
