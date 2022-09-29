using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddManyToManyBetweenAccomodationRoomNameAndBed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccomodationRoomNames",
                table: "AccomodationRoomNames");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AccomodationRoomNames",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccomodationRoomNames",
                table: "AccomodationRoomNames",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AccomodationRoomNameBeds",
                columns: table => new
                {
                    AccomodationRoomNameId = table.Column<int>(type: "int", nullable: false),
                    BedId = table.Column<int>(type: "int", nullable: false),
                    NumOfBeds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationRoomNameBeds", x => new { x.AccomodationRoomNameId, x.BedId });
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNameBeds_AccomodationRoomNames_AccomodationRoomNameId",
                        column: x => x.AccomodationRoomNameId,
                        principalTable: "AccomodationRoomNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNameBeds_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationRoomNames_AccomodationId",
                table: "AccomodationRoomNames",
                column: "AccomodationId");

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationRoomNameBeds_BedId",
                table: "AccomodationRoomNameBeds",
                column: "BedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationRoomNameBeds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccomodationRoomNames",
                table: "AccomodationRoomNames");

            migrationBuilder.DropIndex(
                name: "IX_AccomodationRoomNames_AccomodationId",
                table: "AccomodationRoomNames");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AccomodationRoomNames",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccomodationRoomNames",
                table: "AccomodationRoomNames",
                columns: new[] { "AccomodationId", "RoomNameId" });
        }
    }
}
