using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVlla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sqft",
                table: "Villas",
                newName: "sqft");

            migrationBuilder.CreateTable(
                name: "VillaNumber",
                columns: table => new
                {
                    villaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetailes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumber", x => x.villaNo);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumber");

            migrationBuilder.RenameColumn(
                name: "sqft",
                table: "Villas",
                newName: "Sqft");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 5, 16, 43, 47, 524, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 5, 16, 43, 47, 524, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 5, 16, 43, 47, 524, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 5, 16, 43, 47, 524, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 5, 16, 43, 47, 524, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 5, 16, 43, 47, 524, DateTimeKind.Local).AddTicks(1296));
        }
    }
}
