using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVlla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForignKeyrelationTovillaNumberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "villaID",
                table: "VillaNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 16, 26, 29, 403, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 16, 26, 29, 403, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 16, 26, 29, 403, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 16, 26, 29, 403, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 16, 26, 29, 403, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 16, 26, 29, 403, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumber_villaID",
                table: "VillaNumber",
                column: "villaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumber_Villas_villaID",
                table: "VillaNumber",
                column: "villaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumber_Villas_villaID",
                table: "VillaNumber");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumber_villaID",
                table: "VillaNumber");

            migrationBuilder.DropColumn(
                name: "villaID",
                table: "VillaNumber");

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
    }
}
