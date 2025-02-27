using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeafLedgure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Rename_GnereName_To_GenreName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GnereName",
                table: "Genre",
                newName: "GenreName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Genre",
                newName: "GnereName");
        }
    }
}
