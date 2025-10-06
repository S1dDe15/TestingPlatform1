using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestingPlatform1.Migrations
{
    /// <inheritdoc />
    public partial class InitStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    VkProfileLink = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Login", "MiddleName", "Phone", "VkProfileLink" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2025, 10, 6, 14, 38, 52, 345, DateTimeKind.Unspecified).AddTicks(7976), new TimeSpan(0, 5, 0, 0, 0)), "petr11@gmail.com", "fear", "resh", "petr111", "grat", "79352235412", "http://vk.com/petfdgr11221" },
                    { 2, new DateTimeOffset(new DateTime(2025, 10, 6, 14, 38, 52, 347, DateTimeKind.Unspecified).AddTicks(5099), new TimeSpan(0, 5, 0, 0, 0)), "katya11@gmail.com", "fewar", "reslolh", "katya111", "grherat", "79357775612", "http://vk.com/kathsdha2134" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
