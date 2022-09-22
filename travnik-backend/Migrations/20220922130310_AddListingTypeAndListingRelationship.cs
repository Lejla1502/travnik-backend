using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddListingTypeAndListingRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListingType_Listings_ListingId",
                table: "ListingType");

            migrationBuilder.AlterColumn<int>(
                name: "ListingId",
                table: "ListingType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ListingType_Listings_ListingId",
                table: "ListingType",
                column: "ListingId",
                principalTable: "Listings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListingType_Listings_ListingId",
                table: "ListingType");

            migrationBuilder.AlterColumn<int>(
                name: "ListingId",
                table: "ListingType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ListingType_Listings_ListingId",
                table: "ListingType",
                column: "ListingId",
                principalTable: "Listings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
