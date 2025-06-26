using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationMVCBatch3.Migrations
{
    /// <inheritdoc />
    public partial class P1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "c1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "p1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C1Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_p1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_p1_AccountName_C1Id",
                        column: x => x.C1Id,
                        principalTable: "AccountName",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_p1_C1Id",
                table: "p1",
                column: "C1Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "c1");

            migrationBuilder.DropTable(
                name: "p1");
        }
    }
}
