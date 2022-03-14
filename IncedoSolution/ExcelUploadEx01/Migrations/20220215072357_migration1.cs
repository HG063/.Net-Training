using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelUploadEx01.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    TestCaseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TestScenerio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestCaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestSteps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualResult = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stars", x => x.TestCaseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stars");
        }
    }
}
