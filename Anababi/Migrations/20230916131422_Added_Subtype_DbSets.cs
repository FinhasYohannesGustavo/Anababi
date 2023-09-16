using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anababi.Migrations
{
    /// <inheritdoc />
    public partial class Added_Subtype_DbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "References",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "References",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "File",
                table: "References",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "References",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumOfCopies",
                table: "References",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_References_LocationId",
                table: "References",
                column: "LocationId");

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

            migrationBuilder.DropIndex(
                name: "IX_References_LocationId",
                table: "References");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "References");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "References");

            migrationBuilder.DropColumn(
                name: "File",
                table: "References");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "References");

            migrationBuilder.DropColumn(
                name: "NumOfCopies",
                table: "References");
        }
    }
}
