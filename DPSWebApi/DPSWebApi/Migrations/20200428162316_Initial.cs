using Microsoft.EntityFrameworkCore.Migrations;

namespace DPSWebApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    PosX = table.Column<int>(nullable: false),
                    PosY = table.Column<int>(nullable: false),
                    Gold = table.Column<int>(nullable: false),
                    Food = table.Column<int>(nullable: false),
                    Production = table.Column<int>(nullable: false),
                    Culture = table.Column<int>(nullable: false),
                    Faith = table.Column<int>(nullable: false),
                    Science = table.Column<int>(nullable: false),
                    Improvement = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Population = table.Column<int>(nullable: false),
                    Specialist = table.Column<int>(nullable: false),
                    Buildings = table.Column<int>(nullable: false),
                    Wonders = table.Column<int>(nullable: false),
                    HomeTileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Tile_HomeTileId",
                        column: x => x.HomeTileId,
                        principalTable: "Tile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_HomeTileId",
                table: "City",
                column: "HomeTileId",
                unique: true);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Tile");
        }
    }
}
