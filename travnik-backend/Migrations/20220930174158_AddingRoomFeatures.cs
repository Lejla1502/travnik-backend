using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddingRoomFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccomodationRoomNameBed_AccomodationRoomNames_AccomodationRoomNameId",
                table: "AccomodationRoomNameBed");

            migrationBuilder.DropForeignKey(
                name: "FK_AccomodationRoomNameBed_Beds_BedId",
                table: "AccomodationRoomNameBed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccomodationRoomNameBed",
                table: "AccomodationRoomNameBed");

            migrationBuilder.RenameTable(
                name: "AccomodationRoomNameBed",
                newName: "AccomodationRoomNameBeds");

            migrationBuilder.RenameIndex(
                name: "IX_AccomodationRoomNameBed_BedId",
                table: "AccomodationRoomNameBeds",
                newName: "IX_AccomodationRoomNameBeds_BedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccomodationRoomNameBeds",
                table: "AccomodationRoomNameBeds",
                columns: new[] { "AccomodationRoomNameId", "BedId" });

            migrationBuilder.CreateTable(
                name: "RoomFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFeatures", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AccomodationRoomNameBeds_AccomodationRoomNames_AccomodationRoomNameId",
                table: "AccomodationRoomNameBeds",
                column: "AccomodationRoomNameId",
                principalTable: "AccomodationRoomNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccomodationRoomNameBeds_Beds_BedId",
                table: "AccomodationRoomNameBeds",
                column: "BedId",
                principalTable: "Beds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccomodationRoomNameBeds_AccomodationRoomNames_AccomodationRoomNameId",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.DropForeignKey(
                name: "FK_AccomodationRoomNameBeds_Beds_BedId",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.DropTable(
                name: "RoomFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccomodationRoomNameBeds",
                table: "AccomodationRoomNameBeds");

            migrationBuilder.RenameTable(
                name: "AccomodationRoomNameBeds",
                newName: "AccomodationRoomNameBed");

            migrationBuilder.RenameIndex(
                name: "IX_AccomodationRoomNameBeds_BedId",
                table: "AccomodationRoomNameBed",
                newName: "IX_AccomodationRoomNameBed_BedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccomodationRoomNameBed",
                table: "AccomodationRoomNameBed",
                columns: new[] { "AccomodationRoomNameId", "BedId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AccomodationRoomNameBed_AccomodationRoomNames_AccomodationRoomNameId",
                table: "AccomodationRoomNameBed",
                column: "AccomodationRoomNameId",
                principalTable: "AccomodationRoomNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccomodationRoomNameBed_Beds_BedId",
                table: "AccomodationRoomNameBed",
                column: "BedId",
                principalTable: "Beds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
