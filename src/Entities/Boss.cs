namespace game_rpg.src.Entities
{
    public class Boss : Hero
    {
        public Boss(string name, int level) : base (name, level)
        {
            this.Type = Enums.HeroType.Boss;
            int maxHp = level * 200;
            this.InitHP(maxHp);

            int maxMp = level * 150;
            this.InitMP(maxMp);
            
            this.AttackPower = level * 10;
            this.DefensePower = level * 5;
        }
    }
}