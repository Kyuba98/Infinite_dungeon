namespace Infinite_dungeon.Models
{
    public class Enemy
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int BaseHealthPoints { get; set; }
        public int BaseDamage { get; set; }

        public Enemy(string? name, int level, int baseHealthPoints, int baseDamage)
        {
            Name = name;
            Level = level;
            BaseHealthPoints = baseHealthPoints;
            BaseDamage = baseDamage;
            HealthPoints = MaxHealthPoints;
        }

        public int MaxHealthPoints
        {
            get { return (int)(BaseHealthPoints * (Level * 0.01)); }
        }

        public int Damage
        {
            get { return (int)(BaseDamage * (Level * 0.01)); }
        }

        public int ExperienceReward
        {
            get { return (int)((BaseHealthPoints + BaseDamage) * (Level * 0.01)); } 
        }
    }
}
