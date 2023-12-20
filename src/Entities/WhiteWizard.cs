namespace Game.Entities
{    
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string name, int level) : base(name, level, HeroType.WhiteWizard)
        {
            this.Defense = level * 5;
            this.Strength = level * 20;
        }

        public WhiteWizard(string name) : this(name, 1)
        {
            
        }

        public void Heal(Hero hero) {
            int totalHeal = this.MP / 2;
            hero.Heal(totalHeal);
        }
    }
}