using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddManyToMAnyBetweenAccomodationroomNameAndBed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccomodationRoomNameBed",
                columns: table => new
                {
                    AccomodationRoomNameId = table.Column<int>(type: "int", nullable: false),
                    BedId = table.Column<int>(type: "int", nullable: false),
                    NumOfBedsOfThisType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationRoomNameBed", x => new { x.AccomodationRoomNameId, x.BedId });
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNameBed_AccomodationRoomNames_AccomodationRoomNameId",
                        column: x => x.AccomodationRoomNameId,
                        principalTable: "AccomodationRoomNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNameBed_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationRoomNameBed_BedId",
                table: "AccomodationRoomNameBed",
                column: "BedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationRoomNameBed");
        }
    }
}
