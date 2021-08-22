using Microsoft.EntityFrameworkCore.Migrations;

namespace fragranceAPI.Migrations
{
    public partial class edit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "reviewContent",
                table: "fragrances",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reviewContent",
                table: "fragrances");
        }
    }
}
