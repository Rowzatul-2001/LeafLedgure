using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeafLedgure.Data.Migrations
{
    /// <inheritdoc />
    public partial class pbid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "Product",
                newName: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Product",
                newName: "Publisher");
        }
    }
}
