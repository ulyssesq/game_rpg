// See https://aka.ms/new-console-template for more information
using Game.Entities;

namespace Game
{
    public static class Program
    {
        public static void Main(string[] args) {
            Knight arus = new Knight("Arus", 23);
            BlackWizard wizard = new BlackWizard("Jennica", 23);
            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("*********** Inicio ***********");
            Console.WriteLine("******************************");

            for (int turn = 1; arus.IsAlive() && wizard.IsAlive(); turn++) {
                // A cada turno um ataca
                if (turn % 2 == 0) {
                    wizard.RandomAttack(arus);
                }
                else {
                    arus.RandomAttack(wizard);
                }
                
                Console.WriteLine(arus);
                Console.WriteLine(wizard);
            }

            if (arus.IsAlive()) {
                Console.WriteLine($"{arus.Name} venceu!");
            }
            else {
                Console.WriteLine($"{wizard.Name} venceu!");
            }
        }
    }
}
