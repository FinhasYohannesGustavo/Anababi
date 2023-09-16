using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anababi.Migrations
{
    /// <inheritdoc />
    public partial class Added_ReferenceLocation_DbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_References_ReferenceLocation_LocationId",
                table: "References");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferenceLocation",
                table: "ReferenceLocation");

            migrationBuilder.RenameTable(
                name: "ReferenceLocation",
                newName: "ReferenceLocations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferenceLocations",
                table: "ReferenceLocations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_References_ReferenceLocations_LocationId",
                table: "References",
                column: "LocationId",
                principalTable: "ReferenceLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_References_ReferenceLocations_LocationId",
                table: "References");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferenceLocations",
                table: "ReferenceLocations");

            migrationBuilder.RenameTable(
                name: "ReferenceLocations",
                newName: "ReferenceLocation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferenceLocation",
                table: "ReferenceLocation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_References_ReferenceLocation_LocationId",
                table: "References",
                column: "LocationId",
                principalTable: "ReferenceLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
