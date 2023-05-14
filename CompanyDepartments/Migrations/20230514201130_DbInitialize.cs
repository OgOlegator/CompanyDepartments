using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyDepartments.Migrations
{
    /// <inheritdoc />
    public partial class DbInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdParent = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "EmployeeCount", "IdParent", "Name" },
                values: new object[,]
                {
                    { 1, 11, 0, "Отдел по обслуживанию клиентов" },
                    { 2, 4, 1, "Отдел продаж" },
                    { 3, 2, 2, "Отдел оптовых продаж" },
                    { 4, 2, 2, "Отдел розничных продаж" },
                    { 5, 7, 1, "Отдел логистики" },
                    { 6, 2, 5, "Склад" },
                    { 7, 5, 5, "Отдел доставки" },
                    { 8, 7, 0, "Производственный отдел" },
                    { 9, 4, 8, "Инженерный отдел" },
                    { 10, 2, 8, "Отдел проверки качества" },
                    { 11, 1, 8, "Отдел закупок" },
                    { 12, 2, 0, "Бухгалтерия" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
