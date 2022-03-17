using game_rpg.src.Enums;

namespace game_rpg.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int MP { get; set; }
        public int MaxMP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MagicAtack { get; set; }
        public int MagicDefense { get; set; }
        public HeroType Type { get; set; } 

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
    }
}