using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class FixListingTypeAndListingRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListingType_Listings_ListingId",
                table: "ListingType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListingType",
                table: "ListingType");

            migrationBuilder.DropIndex(
                name: "IX_ListingType_ListingId",
                table: "ListingType");

            migrationBuilder.DropColumn(
                name: "ListingId",
                table: "ListingType");

            migrationBuilder.RenameTable(
                name: "ListingType",
                newName: "ListingTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListingTypes",
                table: "ListingTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ListingListingType",
                columns: table => new
                {
                    ListingTypesId = table.Column<int>(type: "int", nullable: false),
                    ListingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingListingType", x => new { x.ListingTypesId, x.ListingsId });
                    table.ForeignKey(
                        name: "FK_ListingListingType_Listings_ListingsId",
                        column: x => x.ListingsId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListingListingType_ListingTypes_ListingTypesId",
                        column: x => x.ListingTypesId,
                        principalTable: "ListingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListingListingType_ListingsId",
                table: "ListingListingType",
                column: "ListingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListingListingType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ListingTypes",
                table: "ListingTypes");

            migrationBuilder.RenameTable(
                name: "ListingTypes",
                newName: "ListingType");

            migrationBuilder.AddColumn<int>(
                name: "ListingId",
                table: "ListingType",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListingType",
                table: "ListingType",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ListingType_ListingId",
                table: "ListingType",
                column: "ListingId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListingType_Listings_ListingId",
                table: "ListingType",
                column: "ListingId",
                principalTable: "Listings",
                principalColumn: "Id");
        }
    }
}
