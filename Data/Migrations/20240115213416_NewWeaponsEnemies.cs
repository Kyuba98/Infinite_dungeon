using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infinite_dungeon.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewWeaponsEnemies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enemy",
                columns: new[] { "Id", "BaseDamage", "BaseHealthPoints", "HealthPoints", "Level", "Name" },
                values: new object[,]
                {
                    { 3, 150, 250, 2, 1, "Orc" },
                    { 4, 120, 180, 1, 1, "Skeleton" },
                    { 5, 120, 280, 2, 1, "Troll" },
                    { 6, 200, 180, 1, 1, "Witch" },
                    { 7, 150, 400, 4, 1, "Dragon" },
                    { 8, 80, 120, 1, 1, "Slime" },
                    { 9, 100, 350, 3, 1, "Cyclops" },
                    { 10, 200, 150, 1, 1, "Ghost" },
                    { 11, 120, 280, 2, 1, "Werewolf" },
                    { 12, 180, 200, 2, 1, "Harpy" },
                    { 13, 200, 180, 1, 1, "Mummy" },
                    { 14, 240, 160, 1, 1, "Banshee" },
                    { 15, 100, 320, 3, 1, "Minotaur" }
                });

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "DefenseBonus", "Name" },
                values: new object[] { 50, 15, "Iron Sword" });

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cost", "Name" },
                values: new object[] { 50, "Wooden Bow" });

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cost", "Name" },
                values: new object[] { 50, "Novice Staff" });

            migrationBuilder.InsertData(
                table: "Weapon",
                columns: new[] { "Id", "CharacterId", "Cost", "Damage", "DefenseBonus", "MagicPower", "Name", "Type" },
                values: new object[,]
                {
                    { 4, null, 250, 12, 25, 0, "Steel Sword", 0 },
                    { 5, null, 250, 25, 0, 12, "Reinforced Bow", 1 },
                    { 6, null, 250, 0, 12, 25, "Adept Staff", 2 },
                    { 7, null, 500, 25, 50, 0, "Golden Sword", 0 },
                    { 8, null, 500, 50, 0, 25, "Master Archer Bow", 1 },
                    { 9, null, 500, 0, 25, 50, "Enchanter's Staff", 2 },
                    { 10, null, 1000, 50, 100, 25, "Legendary Sword", 0 },
                    { 11, null, 1000, 100, 25, 50, "Dragon's Breath Bow", 1 },
                    { 12, null, 1000, 25, 50, 100, "Archmage's Staff", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enemy",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cost", "DefenseBonus", "Name" },
                values: new object[] { 5, 10, "Sword" });

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cost", "Name" },
                values: new object[] { 5, "Short Bow" });

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cost", "Name" },
                values: new object[] { 5, "Magic Staff" });
        }
    }
}
