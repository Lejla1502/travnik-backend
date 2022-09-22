using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddDescriptioToAccTypesAndRelationshipToListings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AccomodationTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AccomodationTypeListing",
                columns: table => new
                {
                    AccomodationTypesId = table.Column<int>(type: "int", nullable: false),
                    ListingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccomodationTypeListing", x => new { x.AccomodationTypesId, x.ListingsId });
                    table.ForeignKey(
                        name: "FK_AccomodationTypeListing_AccomodationTypes_AccomodationTypesId",
                        column: x => x.AccomodationTypesId,
                        principalTable: "AccomodationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccomodationTypeListing_Listings_ListingsId",
                        column: x => x.ListingsId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationTypeListing_ListingsId",
                table: "AccomodationTypeListing",
                column: "ListingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccomodationTypeListing");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AccomodationTypes");
        }
    }
}
