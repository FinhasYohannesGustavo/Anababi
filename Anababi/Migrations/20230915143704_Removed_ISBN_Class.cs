using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anababi.Migrations
{
    /// <inheritdoc />
    public partial class Removed_ISBN_Class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_References_ISBN_ISBNValueId",
                table: "References");

            migrationBuilder.DropTable(
                name: "ISBN");

            migrationBuilder.DropIndex(
                name: "IX_References_ISBNValueId",
                table: "References");

            migrationBuilder.RenameColumn(
                name: "ISBNValueId",
                table: "References",
                newName: "ISBN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "References",
                newName: "ISBNValueId");

            migrationBuilder.CreateTable(
                name: "ISBN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckDigit = table.Column<int>(type: "int", nullable: false),
                    Prefix = table.Column<int>(type: "int", nullable: false),
                    Publication = table.Column<int>(type: "int", nullable: false),
                    Registrant = table.Column<int>(type: "int", nullable: false),
                    RegistrationGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISBN", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_References_ISBNValueId",
                table: "References",
                column: "ISBNValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_References_ISBN_ISBNValueId",
                table: "References",
                column: "ISBNValueId",
                principalTable: "ISBN",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
