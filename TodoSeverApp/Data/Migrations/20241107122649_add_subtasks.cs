using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoSeverApp.Migrations
{
    /// <inheritdoc />
    public partial class add_subtasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subtask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TaskItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subtask_TaskItems_TaskItemId",
                        column: x => x.TaskItemId,
                        principalTable: "TaskItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 26, 49, 131, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 11, 7, 17, 26, 49, 131, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 26, 49, 131, DateTimeKind.Local).AddTicks(1072), new DateTime(2024, 11, 7, 17, 26, 49, 131, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 26, 49, 131, DateTimeKind.Local).AddTicks(1074), new DateTime(2024, 11, 7, 17, 26, 49, 131, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 26, 49, 131, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 11, 7, 17, 26, 49, 131, DateTimeKind.Local).AddTicks(1077) });

            migrationBuilder.CreateIndex(
                name: "IX_Subtask_TaskItemId",
                table: "Subtask",
                column: "TaskItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subtask");

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
    }
}
