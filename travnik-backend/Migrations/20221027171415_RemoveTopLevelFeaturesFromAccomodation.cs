using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class RemoveTopLevelFeaturesFromAccomodation : Migration
    {
       
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationTopLevelFeatures");

            migrationBuilder.AddColumn<int>(
                name: "TopLevelFeaturesId",
                table: "Accomodations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccomodationRoomNameTopLevelFeatures",
                columns: table => new
                {
                    AccomodationRoomNamesId = table.Column<int>(type: "int", nullable: false),
                    TopLevelFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationRoomNameTopLevelFeatures", x => new { x.AccomodationRoomNamesId, x.TopLevelFeaturesId });
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNameTopLevelFeatures_AccomodationRoomNames_AccomodationRoomNamesId",
                        column: x => x.AccomodationRoomNamesId,
                        principalTable: "AccomodationRoomNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationRoomNameTopLevelFeatures_TopLevelFeatures_TopLevelFeaturesId",
                        column: x => x.TopLevelFeaturesId,
                        principalTable: "TopLevelFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accomodations_TopLevelFeaturesId",
                table: "Accomodations",
                column: "TopLevelFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationRoomNameTopLevelFeatures_TopLevelFeaturesId",
                table: "AccomodationRoomNameTopLevelFeatures",
                column: "TopLevelFeaturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accomodations_TopLevelFeatures_TopLevelFeaturesId",
                table: "Accomodations",
                column: "TopLevelFeaturesId",
                principalTable: "TopLevelFeatures",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accomodations_TopLevelFeatures_TopLevelFeaturesId",
                table: "Accomodations");

            migrationBuilder.DropTable(
                name: "AccomodationRoomNameTopLevelFeatures");

            migrationBuilder.DropIndex(
                name: "IX_Accomodations_TopLevelFeaturesId",
                table: "Accomodations");

            migrationBuilder.DropColumn(
                name: "TopLevelFeaturesId",
                table: "Accomodations");

            migrationBuilder.CreateTable(
                name: "AccomodationTopLevelFeatures",
                columns: table => new
                {
                    AccomodationsId = table.Column<int>(type: "int", nullable: false),
                    FeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationTopLevelFeatures", x => new { x.AccomodationsId, x.FeaturesId });
                    table.ForeignKey(
                        name: "FK_AccomodationTopLevelFeatures_Accomodations_AccomodationsId",
                        column: x => x.AccomodationsId,
                        principalTable: "Accomodations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationTopLevelFeatures_TopLevelFeatures_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "TopLevelFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationTopLevelFeatures_FeaturesId",
                table: "AccomodationTopLevelFeatures",
                column: "FeaturesId");
        }
    }
}
