// See https://aka.ms/new-console-template for more information
using game_rpg.src.Entities;

Warrior player1 = new Warrior("Hercules");
Mob mob1 = new Mob("Mob 1", 1);

Console.WriteLine(mob1.ToString());


Console.WriteLine(player1.ToString());

player1.Attack(mob1);
Console.WriteLine(mob1);
