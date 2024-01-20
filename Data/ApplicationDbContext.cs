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
                new Weapon("Iron Sword", 25, 25, 50, 50, WeaponType.Sword) { Id = 1 },
                new Weapon("Wooden Bow", 50, 25, 25, 50, WeaponType.Bow) { Id = 2 },
                new Weapon("Novice Staff", 25, 50, 25, 50, WeaponType.Staff) { Id = 3 },
            
                // Weapons costing 250
                new Weapon("Steel Sword", 25, 25, 250, 250, WeaponType.Sword) { Id = 4 },
                new Weapon("Reinforced Bow", 250, 125, 125, 250, WeaponType.Bow) { Id = 5 },
                new Weapon("Adept Staff", 125, 250, 125, 250, WeaponType.Staff) { Id = 6 },
            
                // Weapons costing 500
                new Weapon("Golden Sword", 250, 250, 500, 500, WeaponType.Sword) { Id = 7 },
                new Weapon("Master Archer Bow", 500, 25, 250, 500, WeaponType.Bow) { Id = 8 },
                new Weapon("Enchanter's Staff", 250, 500, 25, 500, WeaponType.Staff) { Id = 9 },
            
                // Weapons costing 1000
                new Weapon("Legendary Sword", 500, 250, 1000, 1000, WeaponType.Sword) { Id = 10 },
                new Weapon("Dragon's Breath Bow", 1000, 500, 250, 1000, WeaponType.Bow) { Id = 11 },
                new Weapon("Archmage's Staff", 250, 1000, 500, 1000, WeaponType.Staff) { Id = 12 }
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
