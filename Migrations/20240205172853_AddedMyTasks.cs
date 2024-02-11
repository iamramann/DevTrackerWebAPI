using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevTrackerWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedMyTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    associated_with = table.Column<int>(type: "int", nullable: false),
                    task_type = table.Column<int>(type: "int", nullable: false),
                    time_taken = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyTasks_Associates_associated_with",
                        column: x => x.associated_with,
                        principalTable: "Associates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyTasks_TaskTypes_task_type",
                        column: x => x.task_type,
                        principalTable: "TaskTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyTasks_associated_with",
                table: "MyTasks",
                column: "associated_with");

            migrationBuilder.CreateIndex(
                name: "IX_MyTasks_task_type",
                table: "MyTasks",
                column: "task_type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyTasks");
        }
    }
}
