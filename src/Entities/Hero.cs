namespace game_rpg.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }

        public Hero(string name, int hp)
        {
            this.Name = name;
            this.HP = hp;
            this.Level = 1;
        }
    }
}