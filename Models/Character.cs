using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinite_dungeon.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; } = 1;
        public int ExperiencePoints { get; set; } = 0;
        public int HealthPoints { get; set; }
        public int BaseMaxHealthPoints { get; set; } = 500;
        public int BaseAttack { get; set; } = 100;
        public int BaseMagic { get; set; } = 100;
        public int BaseDefense { get; set; } = 100;
        public int Mana {  get; set; }
        public int BaseMaxMana { get; set; } = 400;
        public int Coins { get; set; } = 0;
        public virtual IdentityUser? User { get; set; }
        public virtual Weapon? Weapon { get; set; }
        public virtual List<Weapon>? Inventory { get; set; } = new List<Weapon>();

        public Character(string Name)
        {
            this.HealthPoints = MaxHealthPoints;
            this.Mana = MaxMana;
            this.Name = Name;
        }

        public int MaxHealthPoints
        {
            get { return (int)(BaseMaxHealthPoints * (Level * 0.01)); }
        }

        public int MaxMana
        {
            get { return (int)(BaseMaxMana * (Level * 0.01)); }
        }

        public int Attack
        {
            get
            {
                if (Weapon == null)
                {
                    return (int)(BaseAttack * (Level * 0.01));
                }
                else
                {
                    return (int)((BaseAttack + Weapon.Damage) * (Level * 0.01));
                }
            }
        }

        public int Magic
        {
            get
            {
                if (Weapon == null)
                {
                    return (int)(BaseMagic * (Level * 0.01));
                }
                else
                {
                    return (int)((BaseMagic + Weapon.MagicPower) * (Level * 0.01));
                }
            }
        }

        public int Defense
        {
            get
            {
                if (Weapon == null)
                {
                    return (int)(BaseDefense * (Level * 0.01));
                }
                else
                {
                    return (int)((BaseDefense + Weapon.DefenseBonus) * (Level * 0.01));
                }
            }
        }

        public int MaxExperiencePoints
        {
            get { return (int)(2000 * (Level * 0.01)); }
        }

        public void LevelUp()
        {
            while (ExperiencePoints >=  MaxExperiencePoints)
            {
                ExperiencePoints -= MaxExperiencePoints;
                Level++;
            }
        }
    }

}
