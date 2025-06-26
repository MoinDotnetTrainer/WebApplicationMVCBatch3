using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationMVCBatch3.Migrations
{
    /// <inheritdoc />
    public partial class P12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "c12",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c12", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "p12",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C12Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_p12", x => x.Id);
                    table.ForeignKey(
                        name: "FK_p12_c12_C12Id",
                        column: x => x.C12Id,
                        principalTable: "c12",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_p12_C12Id",
                table: "p12",
                column: "C12Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "p12");

            migrationBuilder.DropTable(
                name: "c12");
        }
    }
}
