using Infinite_dungeon.Data;
using Infinite_dungeon.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace Infinite_dungeon.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public GameController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Shop()
        {
            // Get the current user
            IdentityUser currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

            // Get the current character for the user
            Character currentCharacter = GetCharacter;

            // Get the list of weapons available in the shop
            List<Weapon> weaponsInShop = await _context.Weapon.ToListAsync();

            // Pass both the current character and the weapons to the view
            var viewModel = new ShopViewModel
            {
                Character = currentCharacter,
                WeaponsInShop = weaponsInShop
            };

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy(int weaponId)
        {
            // Get the current user
            IdentityUser currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

            // Get the selected weapon from the database
            Weapon selectedWeapon = await _context.Weapon.FindAsync(weaponId);

            Character currentCharacter = GetCharacter;

            if (selectedWeapon != null && currentCharacter != null)
            {
                if (currentCharacter.Coins >= selectedWeapon.Cost)
                {
                    currentCharacter.Coins -= selectedWeapon.Cost;

                    // If Inventory is a navigation property in Character, ensure it's loaded
                    await _context.Entry(currentCharacter)
                        .Collection(c => c.Inventory)
                        .LoadAsync();

                    currentCharacter.Inventory.Add(selectedWeapon);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Shop));
                }
            }

            // Redirect to the shop or another appropriate page if the purchase fails
            return RedirectToAction(nameof(Shop));
        }

        public IActionResult Dungeon()
        {
            // Get current character from session
            var currentCharacter = GetCharacter;

            // Generate a random enemy based on character's level
            var enemyLevel = 1;
            var enemy = GenerateRandomEnemy(enemyLevel);

            // Store current enemy and enemy level in session
            HttpContext.Session.SetString("CurrentEnemy", JsonConvert.SerializeObject(enemy));
            HttpContext.Session.SetInt32("EnemyLevel", enemyLevel);

            return View(enemy);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Battle(BattleViewModel viewModel)
        {
            // Get data from session
            var enemyJson = HttpContext.Session.GetString("CurrentEnemy");
            var character = GetCharacter;
            bool actionDone = false;
            // Deserialize the enemy from JSON
            var enemy = JsonConvert.DeserializeObject<Enemy>(enemyJson);

            actionDone = false;

            // Perform battle logic (you can customize this based on your game's design)
            
            switch (viewModel.Option)
            {
                case 1: // Attack
                    enemy.HealthPoints -= character.Attack;
                    actionDone = true;
                    break;

                case 2: // Heal
                    if(character.Mana > 2)
                    {
                        character.HealthPoints += character.Magic;
                        if (character.HealthPoints > character.MaxHealthPoints)
                        {
                            character.HealthPoints = character.MaxHealthPoints;
                        }
                        actionDone = true;
                    }
                    break;

                case 3: 
                    if(character.Weapon!=null)
                    {
                        switch(character.Weapon.Type)
                        {
                            case WeaponType.Sword:
                                // Logic for Sword
                                break;

                            case WeaponType.Bow:
                                // Logic for Bow
                                break;

                            case WeaponType.Staff:
                                // Logic for Staff
                                break;
                        }
                    }
                    break;

                case 4:
                    if (character.Weapon != null)
                    {
                        switch (character.Weapon.Type)
                        {
                            case WeaponType.Sword:
                                // Logic for Sword
                                break;

                            case WeaponType.Bow:
                                // Logic for Bow
                                break;

                            case WeaponType.Staff:
                                // Logic for Staff
                                break;
                        }
                    }
                    break;
            }
            if (actionDone)
            {
                //Handle victory
                if (enemy.HealthPoints <= 0) 
                {
                    character.ExperiencePoints += enemy.ExperienceReward;
                    character.Coins += enemy.Level;
                    character.LevelUp();
                    enemy.Level++;
                    HttpContext.Session.SetInt32("EnemyLevel", enemy.Level);
                    enemy = GenerateRandomEnemy(enemy.Level);
                    HttpContext.Session.SetString("CurrentEnemy", JsonConvert.SerializeObject(enemy));
                    viewModel = new BattleViewModel
                    {
                        Character = character,
                        Enemy = enemy
                    };
                    return View(viewModel);
                }
            }

            HttpContext.Session.SetString("CurrentEnemy", JsonConvert.SerializeObject(enemy));
            viewModel = new BattleViewModel
            {
                Character = character,
                Enemy = enemy
            };
            return View(viewModel);
        }


        private Enemy GenerateRandomEnemy(int level)
        {
            var random = new Random();
            var Enemy = _context.Enemy
                .OrderBy(e => Guid.NewGuid())  // Order randomly
                .FirstOrDefault();

            return new Enemy(Enemy.Name, level, Enemy.BaseHealthPoints, Enemy.BaseDamage);
        }

        private Character GetCharacter
        {
            get
            {
                int? currentCharacterId = HttpContext.Session.GetInt32("CurrentCharacterId");

                if (currentCharacterId.HasValue)
                {
                    // Fetch the character from the database based on the retrieved ID
                    return _context.Character.Find(currentCharacterId.Value);
                }
                else
                {
                    // Handle the case where the current character is not found in the session
                    return null; // Or throw an exception, log an error, or handle it as appropriate for your application
                }
            }
        }

        public class ShopViewModel
        {
            public Character Character { get; set; }
            public List<Weapon> WeaponsInShop { get; set; }
        }

        public class BattleViewModel
        {
            public Character Character { get; set;}
            public Enemy Enemy { get; set;}
            public int Option { get; set;}
        }

    }
}
