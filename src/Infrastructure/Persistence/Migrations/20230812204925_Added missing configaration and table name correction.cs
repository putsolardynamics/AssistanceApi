using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestApiTemplate.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Addedmissingconfigarationandtablenamecorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoLists",
                table: "TodoLists");

            migrationBuilder.RenameTable(
                name: "TodoLists",
                newName: "GeoPositions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeoPositions",
                table: "GeoPositions",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GeoPositions",
                table: "GeoPositions");

            migrationBuilder.RenameTable(
                name: "GeoPositions",
                newName: "TodoLists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoLists",
                table: "TodoLists",
                column: "Id");
        }
    }
}
