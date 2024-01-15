using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Infinite_dungeon.Data;
using Infinite_dungeon.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Infinite_dungeon.Controllers
{
    [Authorize]
    public class CharactersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CharactersController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Characters
        public async Task<IActionResult> Index()
        {
            IdentityUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var aplicationDbContext = _context.Character.Where(c => c.User.Id == user.Id).Include(c => c.User).Include(c => c.Weapon);
            return View(await _context.Character.ToListAsync());
        }

        // GET: Characters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Characters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string Name)
        {
            if (Name != null)
            {
                IdentityUser currentUser = _userManager.FindByNameAsync(User.Identity.Name).Result;

                Character newCharacter = new Character(Name) {User = currentUser, Weapon = null };

                _context.Character.Add(newCharacter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Characters/Play/5
        public async Task<IActionResult> Play(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Character.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            HttpContext.Session.SetInt32("CurrentCharacterId", character.Id);
            return View(character);
        }

        public async Task<IActionResult> Inventory()
        {
            int? characterId = HttpContext.Session.GetInt32("CurrentCharacterId");
            Character character = _context.Character.Find(characterId);
            return View(character);
        }

        // GET: Characters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Character
                .FirstOrDefaultAsync(m => m.Id == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var character = await _context.Character
                .Include(c => c.Inventory)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (character == null)
            {
                return NotFound();
            }

            // Remove the character
            _context.Character.Remove(character);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool CharacterExists(int id)
        {
            return _context.Character.Any(e => e.Id == id);
        }
    }
}
