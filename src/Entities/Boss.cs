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
            
            this.Attack = level * 10;
            this.MagicAtack = level * 10;
            this.Defense = level * 5;
            this.MagicDefense = level * 5;
        }
    }
}