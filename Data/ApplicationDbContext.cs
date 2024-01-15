using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Infinite_dungeon.Models;

namespace Infinite_dungeon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Infinite_dungeon.Models.Character> Character { get; set; } = default!;
        public DbSet<Infinite_dungeon.Models.Weapon> Weapon { get; set; } = default!;
        public DbSet<Infinite_dungeon.Models.Enemy> Enemy { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data here
            SeedInitialData(modelBuilder);
        }

        private void SeedInitialData(ModelBuilder modelBuilder)
        {
            // Seed weapons
            modelBuilder.Entity<Weapon>().HasData(
                // Weapons costing 50
                new Weapon("Iron Sword", 5, 0, 15, 50, WeaponType.Sword) { Id = 1 },
                new Weapon("Wooden Bow", 15, 5, 0, 50, WeaponType.Bow) { Id = 2 },
                new Weapon("Novice Staff", 0, 15, 5, 50, WeaponType.Staff) { Id = 3 },
            
                // Weapons costing 250
                new Weapon("Steel Sword", 12, 0, 25, 250, WeaponType.Sword) { Id = 4 },
                new Weapon("Reinforced Bow", 25, 12, 0, 250, WeaponType.Bow) { Id = 5 },
                new Weapon("Adept Staff", 0, 25, 12, 250, WeaponType.Staff) { Id = 6 },
            
                // Weapons costing 500
                new Weapon("Golden Sword", 25, 0, 50, 500, WeaponType.Sword) { Id = 7 },
                new Weapon("Master Archer Bow", 50, 25, 0, 500, WeaponType.Bow) { Id = 8 },
                new Weapon("Enchanter's Staff", 0, 50, 25, 500, WeaponType.Staff) { Id = 9 },
            
                // Weapons costing 1000
                new Weapon("Legendary Sword", 50, 25, 100, 1000, WeaponType.Sword) { Id = 10 },
                new Weapon("Dragon's Breath Bow", 100, 50, 25, 1000, WeaponType.Bow) { Id = 11 },
                new Weapon("Archmage's Staff", 25, 100, 50, 1000, WeaponType.Staff) { Id = 12 }
            );


            modelBuilder.Entity<Enemy>().HasData(
                new Enemy("Goblin", 1, 200, 150) { Id = 1 },
                new Enemy("Chimera", 1, 300, 200) { Id = 2 },
                new Enemy("Orc", 1, 250, 150) { Id = 3 },
                new Enemy("Skeleton", 1, 180, 120) { Id = 4 },
                new Enemy("Troll", 1, 280, 120) { Id = 5 },
                new Enemy("Witch", 1, 180, 200) { Id = 6 },
                new Enemy("Dragon", 1, 400, 150) { Id = 7 },
                new Enemy("Slime", 1, 120, 80) { Id = 8 },
                new Enemy("Cyclops", 1, 350, 100) { Id = 9 },
                new Enemy("Ghost", 1, 150, 200) { Id = 10 },
                new Enemy("Werewolf", 1, 280, 120) { Id = 11 },
                new Enemy("Harpy", 1, 200, 180) { Id = 12 },
                new Enemy("Mummy", 1, 180, 200) { Id = 13 },
                new Enemy("Banshee", 1, 160, 240) { Id = 14 },
                new Enemy("Minotaur", 1, 320, 100) { Id = 15 }
            );

        }
    }
}
