using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Middleware.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    SortCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "Name", "SortCode" },
                values: new object[,]
                {
                    { 1, 10101010, -1000.0, "Rich", 101010 },
                    { 2, 64872091, 8000000.0, "Katherine", 100002 },
                    { 3, 44444444, 500.0, "Poppy", 130002 },
                    { 4, 11112222, 100.0, "Haz", 404040 },
                    { 5, 33334444, 50000.0, "Neil", 989898 },
                    { 6, 23232323, 9000.0, "Pippa", 134761 },
                    { 7, 19876543, 50000.0, "Alice", 225588 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");
        }
    }
}
