using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClubClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class newUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersPermission = table.Column<bool>(type: "bit", nullable: false),
                    MembersPermission = table.Column<bool>(type: "bit", nullable: false),
                    ReportsPermission = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "MembersPermission", "Name", "Password", "ReportsPermission", "UsersPermission" },
                values: new object[,]
                {
                    { 1, "admin1@yahoo.com", false, "admin1", "123", false, true },
                    { 2, "admin2@yahoo.com", true, "admin2", "456", false, false },
                    { 3, "admin3@yahoo.com", false, "admin3", "789", true, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
