using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace weddit_api.Migrations
{
    public partial class AddedLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TextIsLink",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextIsLink",
                table: "Posts");
        }
    }
}
