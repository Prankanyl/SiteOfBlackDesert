using Microsoft.EntityFrameworkCore.Migrations;

namespace SiteOfBlackDesert.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryAlchemyAndCooking",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    descriptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAlchemyAndCooking", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryItems",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryitemsname = table.Column<string>(nullable: true),
                    descriptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryItems", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AlchemyAndCooking",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    descriptions = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    CategoryAlchemyAndCookingID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlchemyAndCooking", x => x.id);
                    table.ForeignKey(
                        name: "FK_AlchemyAndCooking_CategoryAlchemyAndCooking_CategoryAlchemyAndCookingID",
                        column: x => x.CategoryAlchemyAndCookingID,
                        principalTable: "CategoryAlchemyAndCooking",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    descriptions = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    damage = table.Column<string>(nullable: true),
                    protection = table.Column<string>(nullable: true),
                    accuracy = table.Column<string>(nullable: true),
                    evasion = table.Column<string>(nullable: true),
                    damage_reduction = table.Column<string>(nullable: true),
                    is_favourite = table.Column<bool>(nullable: false),
                    CategoryItemsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_CategoryItems_CategoryItemsID",
                        column: x => x.CategoryItemsID,
                        principalTable: "CategoryItems",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlchemyAndCooking_CategoryAlchemyAndCookingID",
                table: "AlchemyAndCooking",
                column: "CategoryAlchemyAndCookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryItemsID",
                table: "Items",
                column: "CategoryItemsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlchemyAndCooking");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "CategoryAlchemyAndCooking");

            migrationBuilder.DropTable(
                name: "CategoryItems");
        }
    }
}
