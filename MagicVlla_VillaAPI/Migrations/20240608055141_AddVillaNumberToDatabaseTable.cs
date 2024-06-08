using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVlla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToDatabaseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 51, 40, 913, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 51, 40, 913, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 51, 40, 913, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 51, 40, 913, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 51, 40, 913, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 51, 40, 913, DateTimeKind.Local).AddTicks(1901));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 48, 10, 180, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 48, 10, 180, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 48, 10, 180, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 48, 10, 180, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 48, 10, 180, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 11, 48, 10, 180, DateTimeKind.Local).AddTicks(7512));
        }
    }
}
