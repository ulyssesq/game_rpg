namespace Game.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroType Type { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }


        public Hero(string name, int level, HeroType type)
        {
            this.Name = name;
            this.Level = level;
            this.Type = type;
        }

        public override string ToString()
        {
           return this.Name + " " + this.Level + " " + this.Type;
        }

        public virtual string Attack() {
            return this.Name + " atacou com a sua espada!";
        }

        public virtual string Attack(int bonus) {
            return this.Name + " atacou com bonus " + bonus;
        }

        public enum HeroType{
            Knight,
            WhiteWizard,
            BlackWizard,
            Ninja,
        }
    }
}