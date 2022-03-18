namespace game_rpg.src.Entities
{
    public class Mob : Hero
    {
        public Mob(string name, int level) : base (name, level)
        {
            this.Type = Enums.HeroType.Mob;
            
            int maxHp = level * 50;
            InitHP(maxHp);

            int maxMp = level * 50;
            InitMP(maxMp);

            AttackPower = level * 5;
            DefensePower = level * 5;
        }
    }
}