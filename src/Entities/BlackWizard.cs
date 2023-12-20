namespace Game.Entities
{    
    public class BlackWizard : Hero
    {
        public BlackWizard(string name, int level) : base(name, level, HeroType.BlackWizard)
        {

        }

        public BlackWizard(string name) : this(name, 1)
        {
            
        }

        public override string Attack() {
            return this.Name + " lançou magia";
        }

        public string Attack(int bonus) {
            if (bonus > 6) {
                return this.Name + " lançou uma magia super efetiva com bonus de " + bonus;
            }
            else {
                return this.Name + " lançou uma magia com força fraca com bonus de " + bonus;
            }
        }
    }
}