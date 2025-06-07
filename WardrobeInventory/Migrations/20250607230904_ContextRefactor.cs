using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WardrobeInventory.Migrations
{
    /// <inheritdoc />
    public partial class ContextRefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WardrobeItem",
                table: "WardrobeItem");

            migrationBuilder.RenameTable(
                name: "WardrobeItem",
                newName: "WardrobeItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WardrobeItems",
                table: "WardrobeItems",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WardrobeItems",
                table: "WardrobeItems");

            migrationBuilder.RenameTable(
                name: "WardrobeItems",
                newName: "WardrobeItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WardrobeItem",
                table: "WardrobeItem",
                column: "Id");
        }
    }
}
