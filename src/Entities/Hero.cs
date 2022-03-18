using game_rpg.src.Enums;

namespace game_rpg.src.Entities
{
    public class Hero
    {
        public string Name { get; protected set; }
        public int Level { get; protected set; }
        public int HP { get; protected set; }
        public int MaxHP { get; protected set; }
        public int MP { get; protected set; }
        public int MaxMP { get; protected set; }
        public int AttackPower { get; set; }
        public int DefensePower { get; set; }
        protected HeroType Type { get; set; } 

        public Hero(string name)
        {
            this.Name = name;
        }

        public Hero(string name, int level) : this (name)
        {
            this.Level = level;
        }        

        public Hero(string name, int level, int maxHp, int maxMp) : this (name, level)
        {
            InitHP(maxHp);
            InitMP(maxMp);
        }

        protected void InitHP(int maxHp){
            this.HP = maxHp;
            this.MaxHP = maxHp;
        }

        protected void InitMP(int maxMp){
            this.MP = maxMp;
            this.MaxMP = maxMp;
        }

        public virtual void Attack(Hero target){
            Console.WriteLine($"{this.Name} ataca {target.Name}");
            int damage = GetDamage(this, target);

            Console.WriteLine($"{target.Name} recebeu {damage} de dano");
        }

        protected int GetDamage(Hero attacker, Hero target){
            int damage = attacker.AttackPower - target.DefensePower;

            if (damage < 0) {
                damage = 0;
            }

            target.HP -= damage;

            if (target.HP < 0) {
                target.HP = 0;
            }

            return damage;
        }

        public override string ToString()
        {
            string heroInfo = $"\n{this.Name}";
            heroInfo += $"\n{this.Type} Level {this.Level}";
            heroInfo += $"\nHP: {this.HP} / {this.MaxHP}";
            heroInfo += $"\nMP: {this.MP} / {this.MaxMP}\n";
            
            return heroInfo;
        }
    }
}