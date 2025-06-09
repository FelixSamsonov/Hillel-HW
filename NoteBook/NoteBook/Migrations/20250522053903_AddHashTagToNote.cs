using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteBook.Migrations
{
    /// <inheritdoc />
    public partial class AddHashTagToNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HashTag",
                table: "Notes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HashTag",
                table: "Notes");
        }
    }
}
