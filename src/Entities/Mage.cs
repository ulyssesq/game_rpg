namespace game_rpg.src.Entities
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name, 1, 50, 100)
        {
            this.Type = Enums.HeroType.Mage;
            this.AttackPower = 15;
            this.DefensePower = 8;        
        }
    }
}