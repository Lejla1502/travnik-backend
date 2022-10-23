using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddingNumOfBedsToAccomodationRoomNameBds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccomodationRoomNameBeds",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AccomodationRoomNameBeds",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "NumOfBedsOfThisType",
                table: "AccomodationRoomNameBeds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccomodationRoomNameBeds",
                table: "AccomodationRoomNameBeds",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationRoomNameBeds_AccomodationRoomNameId",
                table: "AccomodationRoomNameBeds",
                column: "AccomodationRoomNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccomodationRoomNameBeds",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.DropIndex(
                name: "IX_AccomodationRoomNameBeds_AccomodationRoomNameId",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.DropColumn(
                name: "NumOfBedsOfThisType",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccomodationRoomNameBeds",
                table: "AccomodationRoomNameBeds",
                columns: new[] { "AccomodationRoomNameId", "BedId" });
        }
    }
}
