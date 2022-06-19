using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWTExample.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "FirstName1", "LastName1" },
                    { 2, "FirstName2", "LastName2" },
                    { 3, "FirstName3", "LastName3" },
                    { 4, "FirstName4", "LastName4" },
                    { 5, "FirstName5", "LastName5" },
                    { 6, "FirstName6", "LastName6" },
                    { 7, "FirstName7", "LastName7" },
                    { 8, "FirstName8", "LastName8" },
                    { 9, "FirstName9", "LastName9" },
                    { 10, "FirstName10", "LastName10" },
                    { 11, "FirstName11", "LastName11" },
                    { 12, "FirstName12", "LastName12" },
                    { 13, "FirstName13", "LastName13" },
                    { 14, "FirstName14", "LastName14" },
                    { 15, "FirstName15", "LastName15" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
