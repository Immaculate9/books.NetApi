using Microsoft.EntityFrameworkCore.Migrations;

namespace bookcrud.Migrations
{
    public partial class PublisherColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "Publisher");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "Books",
                newName: "Name");
        }
    }
}
