using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreApp01.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployees");
        }
    }
}
