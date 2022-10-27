using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class ChangigngNameFromFeaturesToTopLevelFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationFeatures");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.CreateTable(
                name: "TopLevelFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopLevelFeatures", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationTopLevelFeatures");

            migrationBuilder.DropTable(
                name: "TopLevelFeatures");

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccomodationFeatures",
                columns: table => new
                {
                    AccomodationsId = table.Column<int>(type: "int", nullable: false),
                    FeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationFeatures", x => new { x.AccomodationsId, x.FeaturesId });
                    table.ForeignKey(
                        name: "FK_AccomodationFeatures_Accomodations_AccomodationsId",
                        column: x => x.AccomodationsId,
                        principalTable: "Accomodations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationFeatures_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationFeatures_FeaturesId",
                table: "AccomodationFeatures",
                column: "FeaturesId");
        }
    }
}
