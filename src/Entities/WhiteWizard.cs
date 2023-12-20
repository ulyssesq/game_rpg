namespace Game.Entities
{    
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string name, int level) : base(name, level, HeroType.WhiteWizard)
        {

        }

        public WhiteWizard(string name) : this(name, 1)
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