namespace game_rpg.src.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name, 1, 80, 30)
        {
            this.AttackPower = 10;
            this.DefensePower = 15;
        }

        public override void Attack(Hero hero){
            base.Attack(hero);

            Random random = new Random();
            if (random.Next(3) == 2) {
                Console.WriteLine("Ataque duplo!");
                base.Attack(hero);
            }
        }
    }
}