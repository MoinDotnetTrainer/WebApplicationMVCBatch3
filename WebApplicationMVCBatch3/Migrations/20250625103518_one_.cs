using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationMVCBatch3.Migrations
{
    /// <inheritdoc />
    public partial class one_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "twos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OneEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_twos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    twoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ones_twos_twoId",
                        column: x => x.twoId,
                        principalTable: "twos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ones_twoId",
                table: "ones",
                column: "twoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ones");

            migrationBuilder.DropTable(
                name: "twos");
        }
    }
}
