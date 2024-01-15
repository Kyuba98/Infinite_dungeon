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
                new Weapon("Sword", 5, 0, 10, 5, WeaponType.Sword) { Id = 1},
                new Weapon("Short Bow", 15, 5, 0, 5, WeaponType.Bow) { Id = 2},
                new Weapon("Magic Staff", 0, 15, 5, 5, WeaponType.Staff) { Id = 3}
            );

            modelBuilder.Entity<Enemy>().HasData(
                new Enemy("Goblin", 1, 200, 150) { Id = 1},
                new Enemy("Chimera",1,300,200) { Id = 2}
            );
        }
    }
}
