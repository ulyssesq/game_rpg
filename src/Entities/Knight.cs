namespace Game.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level) : base(name, level, HeroType.Knight)
        {
            
        }

        public Knight(string name) : this(name, 1)
        {
            
        }
    }
}