using Microsoft.EntityFrameworkCore.Migrations;

namespace fragranceAPI.Migrations
{
    public partial class createtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fragrances",
                columns: table => new
                {
                    productId = table.Column<string>(type: "varchar(767)", nullable: false),
                    productName = table.Column<string>(type: "text", nullable: true),
                    brandName = table.Column<string>(type: "text", nullable: true),
                    productImage = table.Column<string>(type: "text", nullable: true),
                    productRating = table.Column<string>(type: "text", nullable: true),
                    numberOfReviews = table.Column<string>(type: "text", nullable: true),
                    reviewContent = table.Column<string>(type: "text", nullable: true),
                    productPrice = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fragrances", x => x.productId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fragrances");
        }
    }
}
