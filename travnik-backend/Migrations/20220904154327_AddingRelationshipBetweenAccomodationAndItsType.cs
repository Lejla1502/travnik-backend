using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddingRelationshipBetweenAccomodationAndItsType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccomodationTypeId",
                table: "Accomodations",
                type: "int",
                nullable: true,
                defaultValue: null);

            migrationBuilder.CreateIndex(
                name: "IX_Accomodations_AccomodationTypeId",
                table: "Accomodations",
                column: "AccomodationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accomodations_AccomodationTypes_AccomodationTypeId",
                table: "Accomodations",
                column: "AccomodationTypeId",
                principalTable: "AccomodationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accomodations_AccomodationTypes_AccomodationTypeId",
                table: "Accomodations");

            migrationBuilder.DropIndex(
                name: "IX_Accomodations_AccomodationTypeId",
                table: "Accomodations");

            migrationBuilder.DropColumn(
                name: "AccomodationTypeId",
                table: "Accomodations");
        }
    }
}
