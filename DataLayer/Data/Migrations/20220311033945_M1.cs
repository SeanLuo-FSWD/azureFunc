using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "1386d9b1-3cd8-4192-80d8-f02ef8df1d3a", "Jane", "Smith", "Medicine" },
                    { "31ec3741-a58d-4ee1-bc17-b60ff8991943", "Pamela", "Baker", "Food Science" },
                    { "4b9e62b6-2d12-45dc-ba7a-04c1423377d7", "John", "Fisher", "Engineering" },
                    { "e56b326a-85f8-47ef-8e4e-e2546bd53244", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
