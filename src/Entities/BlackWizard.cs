namespace Game.Entities
{    
    public class BlackWizard : Hero
    {
        public BlackWizard(string name, int level) : base(name, level, HeroType.BlackWizard)
        {
            this.Defense = level * 5;
            this.Strength = level * 20;
        }

        public BlackWizard(string name) : this(name, 1)
        {
            
        }


        public override bool SpecialAttack(Hero hero)
        {
            Console.WriteLine($"{Type} invocou as chamas da gambiarra suprema! while(1==1); if(false); goto GoHorse udpate from table [sem where]");
            return base.SpecialAttack(hero);
        }
    }
}