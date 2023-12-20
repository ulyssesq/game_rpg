namespace Game.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level) : base(name, level, HeroType.Ninja)
        {
            
        }

        public Ninja(string name) : this(name, 1)
        {
            
        }
    }
}