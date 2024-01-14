using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infinite_dungeon.Data.Migrations
{
    /// <inheritdoc />
    public partial class enemyModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HealthPoints",
                table: "Enemy",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 1,
                column: "HealthPoints",
                value: 2);

            migrationBuilder.InsertData(
                table: "Enemy",
                columns: new[] { "Id", "BaseDamage", "BaseHealthPoints", "HealthPoints", "Level", "Name" },
                values: new object[] { 2, 200, 300, 3, 1, "Chimera" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "HealthPoints",
                table: "Enemy");
        }
    }
}
