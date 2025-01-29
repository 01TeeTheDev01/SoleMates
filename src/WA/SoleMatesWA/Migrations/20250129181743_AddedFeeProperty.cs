using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoleMatesWA.Migrations
{
    /// <inheritdoc />
    public partial class AddedFeeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Fee",
                table: "Events",
                type: "numeric(9,2)",
                precision: 9,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d0e0a0b0-c0d0-4e0f-8a0b-0c0d0e0f0a0b"),
                column: "Fee",
                value: 150.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                column: "Fee",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                column: "Fee",
                value: 50.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                column: "Fee",
                value: 150.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                column: "Fee",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                column: "Fee",
                value: 60.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d6e6a6b6-c6d6-4e6f-8a6b-6c6d6e6f6a6b"),
                column: "Fee",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d7e7a7b7-c7d7-4e7f-8a7b-7c7d7e7f7a7b"),
                column: "Fee",
                value: 0.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d8e8a8b8-c8d8-4e8f-8a8b-8c8d8e8f8a8b"),
                column: "Fee",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("d9e9a9b9-c9d9-4e9f-8a9b-9c9d9e9f9a9b"),
                column: "Fee",
                value: 50.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e1e1a1b1-c1d1-4e1f-8a1b-1c1d1e1f1a1b"),
                column: "Fee",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e2e2a2b2-c2d2-4e2f-8a2b-2c2d2e2f2a2b"),
                column: "Fee",
                value: 60.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e3e3a3b3-c3d3-4e3f-8a3b-3c3d3e3f3a3b"),
                column: "Fee",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e4e4a4b4-c4d4-4e4f-8a4b-4c4d4e4f4a4b"),
                column: "Fee",
                value: 0.00m);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e5e5a5b5-c5d5-4e5f-8a5b-5c5d5e5f5a5b"),
                column: "Fee",
                value: 100.00m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "Events");
        }
    }
}
