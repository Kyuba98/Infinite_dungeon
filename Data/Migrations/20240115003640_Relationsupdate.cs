using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infinite_dungeon.Data.Migrations
{
    /// <inheritdoc />
    public partial class Relationsupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weapon",
                columns: new[] { "Id", "CharacterId", "Cost", "Damage", "DefenseBonus", "MagicPower", "Name", "Type" },
                values: new object[] { 3, null, 5, 0, 5, 15, "Magic Staff", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
