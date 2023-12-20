namespace Game.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level) : base(name, level, HeroType.Ninja)
        {
            this.Defense = level * 10;
            this.Strength = level * 15;
        }

        public Ninja(string name) : this(name, 1)
        {
            
        }
    }
}