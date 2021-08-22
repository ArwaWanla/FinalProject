using Microsoft.EntityFrameworkCore.Migrations;

namespace fragranceAPI.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reviewContent",
                table: "fragrances");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "reviewContent",
                table: "fragrances",
                type: "text",
                nullable: true);
        }
    }
}
