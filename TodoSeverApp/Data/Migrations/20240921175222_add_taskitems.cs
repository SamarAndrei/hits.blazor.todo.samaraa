using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoSeverApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedDate", "Description", "FinishedDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2544), "Описание 1", new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2557), "Заголовок 1" },
                    { 2, new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2559), "Описание 2", new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2559), "Заголовок 2" },
                    { 3, new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2561), "Описание 3", new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2561), "Заголовок 3" },
                    { 4, new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2563), "Описание 4", new DateTime(2024, 9, 21, 22, 52, 21, 460, DateTimeKind.Local).AddTicks(2563), "Заголовок 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
