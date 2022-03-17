namespace game_rpg.src.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name, 1, 80, 30)
        {
            this.Attack = 12;
            this.MagicAtack = 5;
        }
    }
}