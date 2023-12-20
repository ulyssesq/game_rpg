using System.Reflection.Metadata;
using System.Text;

namespace Game.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroType Type { get; set; }
        public int MaxHP {get; set;}
        public int HP { get; set; }
        public int MaxMP { get; set; }
        public int MP { get; set; }
        protected int Strength { get; set;}
        protected int Defense { get; set;}


        public Hero(string name, int level, HeroType type)
        {
            this.Name = name;
            this.Level = level;
            this.Type = type;
            this.MaxHP = level * 100;
            this.MaxMP = level * 50;
            this.HP = this.MaxHP;
            this.MP = this.MaxMP;
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine();
            text.AppendLine($"*************** {Name} ".PadRight(40, '*'));
            text.AppendLine($" Level: {Level} - Tipo: {Type}");
            text.AppendLine($" HP: {HP}/{MaxHP}".PadRight(30, ' '));
            text.AppendLine($" MP: {MP}/{MaxMP}");
            text.AppendLine("*".PadRight(40, '*'));
            return text.ToString();
        }

        public virtual bool Attack(Hero hero) {
            Console.WriteLine($"{Name} atacou {hero.Name}");

            int attackPoints = GetAttackPoints();
            bool defended = hero.Defend(attackPoints);
            bool successfulAttack = !defended;
            return successfulAttack;
        }

        public virtual bool SpecialAttack(Hero hero) {
            if (HasMPEnough()) {
                int attackPoints = GetSpecialAttackPoints();
                bool defended = hero.Defend(attackPoints);
                bool successfulAttack = !defended;
                return successfulAttack;
            }

            return false;
        }

        public bool RandomAttack(Hero hero) {
            var random = new Random();
            if (random.Next(2) == 2) {
                return SpecialAttack(hero);
            }
            else {
                return Attack(hero);
            }
        }

        public bool Defend(int attackPoints) {
            int damage = GetDamage(attackPoints);

            if (damage == 0) {
                Console.WriteLine($"{Name} defendeu o ataque!");
                return true;
            }

            ReduceHP(damage);      
            return false;
        }

        public bool IsAlive() {
            return this.HP > 0;
        }

        public void Heal(int healPoints) {
            int newHP = healPoints + this.HP;

            if (newHP > MaxHP) {
                healPoints = MaxHP - HP;
                HP = MaxHP;
            }
            else {
                HP = newHP;
            }

            Console.WriteLine($"{Name} foi curado em {healPoints} pontos");

        }

        private bool IsDefending() {
            var random = new Random();
            // Quanto maior o level maiores as chances de defender um ataque
            return random.Next(100) < this.Level;
        }

        private int GetDefensePoints(){
            var random = new Random();
            return this.Level + random.Next(this.Defense / 2);
        }        

        private int GetDamage(int attackPoints) {
            if (IsDefending()) {
                return 0;
            }

            int defensePoints = GetDefensePoints();

            if (attackPoints > defensePoints) {
                return attackPoints - defensePoints;
            }
            else {
                return 0;
            }
        }        

        private void ReduceHP(int damage) {
            if (damage > this.HP) {
                this.HP = 0;
            }
            else {
                this.HP -= damage;
                Console.WriteLine($"{Name} recebeu {damage} de dano!");
            }

            if (!IsAlive()) {
                Console.WriteLine($"{Name} morreu!");
            }
        }

        private bool HasMPEnough() {
            int MPCost = GetMPCost();
            bool hasMPEnough = MPCost <= this.MP;

            if (!hasMPEnough) {
                Console.WriteLine($"{Name} não possui MP suficiente para executar este ataque");
            }

            return hasMPEnough;
        }

        private int GetMPCost() {
            return this.Level * 2;
        }

        protected int GetAttackPoints() {
            var random = new Random();
            int attackPoints = this.Level + random.Next(this.Strength);

            if (IsCriticalAttack()) {
                Console.WriteLine("Ataque Critico!");
                attackPoints *= 2;
            }

            return attackPoints;    
        }

        private bool IsCriticalAttack() {
            var random = new Random();
            // Quanto maior o level maiores as chances de um ataque ser critico
            return random.Next(100) < this.Level;
        }

        protected int GetSpecialAttackPoints(){
            var random = new Random();
            int specialMultiplier = random.Next(3);
            return GetAttackPoints() * specialMultiplier;
        }

        public enum HeroType{
            Knight,
            WhiteWizard,
            BlackWizard,
            Ninja,
        }
    }
}