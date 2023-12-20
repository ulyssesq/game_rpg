namespace Game.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level) : base(name, level, HeroType.Knight)
        {
            this.Defense = level * 15;
            this.Strength = level * 10;
        }

        public Knight(string name) : this(name, 1)
        {
            
        }
    }
}