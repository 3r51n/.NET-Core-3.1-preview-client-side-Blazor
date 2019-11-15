using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
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
                    { "46b270f2-f86a-4115-a998-2f38f853c635", "Jane", "Smith", "Medicine" },
                    { "5e199e62-cca7-4d30-9609-21620bafbaf0", "John", "Fisher", "Engineering" },
                    { "cc972ca3-a87a-4259-932d-c6924f692da3", "Pamela", "Baker", "Food Science" },
                    { "b1b81db3-d773-48d8-b2b2-960e7851a328", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
