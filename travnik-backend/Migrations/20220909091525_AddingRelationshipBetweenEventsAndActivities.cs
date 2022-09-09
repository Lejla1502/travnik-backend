using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travnik_backend.Migrations
{
    public partial class AddingRelationshipBetweenEventsAndActivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActivitiesId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ActivitiesId",
                table: "Events",
                column: "ActivitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Activities_ActivitiesId",
                table: "Events",
                column: "ActivitiesId",
                principalTable: "Activities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Activities_ActivitiesId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_ActivitiesId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ActivitiesId",
                table: "Events");
        }
    }
}
