using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class editOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerId",
                table: "Tasks",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Owners_OwnerId",
                table: "Tasks",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Owners_OwnerId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_OwnerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
