using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoSeverApp.Migrations
{
    /// <inheritdoc />
    public partial class addRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 19, 4, 50, 78, DateTimeKind.Local).AddTicks(2619), new DateTime(2024, 10, 10, 19, 4, 50, 78, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 19, 4, 50, 78, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 10, 10, 19, 4, 50, 78, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 19, 4, 50, 78, DateTimeKind.Local).AddTicks(2635), new DateTime(2024, 10, 10, 19, 4, 50, 78, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 10, 10, 19, 4, 50, 78, DateTimeKind.Local).AddTicks(2637), new DateTime(2024, 10, 10, 19, 4, 50, 78, DateTimeKind.Local).AddTicks(2637) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2544), new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2559), new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2563), new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2563) });
        }
    }
}
