using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddListingType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccomodationTypeListing",
                columns: table => new
                {
                    AccomodationTypesId = table.Column<int>(type: "int", nullable: false),
                    ListingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationTypeListing", x => new { x.AccomodationTypesId, x.ListingId });
                    table.ForeignKey(
                        name: "FK_AccomodationTypeListing_AccomodationTypes_AccomodationTypesId",
                        column: x => x.AccomodationTypesId,
                        principalTable: "AccomodationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationTypeListing_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListingType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListingType_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationTypeListing_ListingId",
                table: "AccomodationTypeListing",
                column: "ListingId");

            migrationBuilder.CreateIndex(
                name: "IX_ListingType_ListingId",
                table: "ListingType",
                column: "ListingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationTypeListing");

            migrationBuilder.DropTable(
                name: "ListingType");
        }
    }
}
