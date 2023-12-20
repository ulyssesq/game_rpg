// See https://aka.ms/new-console-template for more information
using Game.Entities;

namespace Game
{
    public static class Program
    {
        public static void Main(string[] args) {
            Knight arus = new Knight("Arus", 23);
            WhiteWizard wizard = new WhiteWizard("Jennica", 23);
            Console.WriteLine(arus.Attack());    
            Console.WriteLine(wizard.Attack()); 
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
