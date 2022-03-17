namespace game_rpg.src.Entities
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name, 1, 50, 100)
        {
            this.Type = Enums.HeroType.Mage;
            this.Attack = 4;
            this.MagicAtack = 12;        
        }
    }
}