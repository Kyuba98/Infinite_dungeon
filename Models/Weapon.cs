namespace Infinite_dungeon.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Damage { get; set; }
        public int MagicPower { get; set; }
        public int DefenseBonus { get; set; }
        public int Cost { get; set; }
        public WeaponType Type { get; set; }

        public Weapon(string Name, int Damage, int MagicPower, int DefenseBonus, int Cost, WeaponType Type) 
        {
            this.Name = Name;
            this.Damage = Damage;
            this.MagicPower = MagicPower;
            this.DefenseBonus = DefenseBonus;
            this.Cost = Cost;
            this.Type = Type;
        }
    }

    public enum WeaponType
    {
        Sword,
        Bow,
        Staff,
    }
}
