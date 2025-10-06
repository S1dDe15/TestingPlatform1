using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingPlatform1.Migrations
{
    /// <inheritdoc />
    public partial class InitStudents2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 10, 6, 3, 51, 51, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 10, 6, 5, 34, 21, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 10, 6, 14, 38, 52, 345, DateTimeKind.Unspecified).AddTicks(7976), new TimeSpan(0, 5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 10, 6, 14, 38, 52, 347, DateTimeKind.Unspecified).AddTicks(5099), new TimeSpan(0, 5, 0, 0, 0)));
        }
    }
}
