using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationMVCBatch3.Migrations
{
    /// <inheritdoc />
    public partial class One_oneex3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wives",
                columns: table => new
                {
                    RefID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wives", x => x.RefID);
                });

            migrationBuilder.CreateTable(
                name: "husbands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wifeRefID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_husbands", x => x.ID);
                    table.ForeignKey(
                        name: "FK_husbands_wives_wifeRefID",
                        column: x => x.wifeRefID,
                        principalTable: "wives",
                        principalColumn: "RefID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_husbands_wifeRefID",
                table: "husbands",
                column: "wifeRefID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "husbands");

            migrationBuilder.DropTable(
                name: "wives");
        }
    }
}
