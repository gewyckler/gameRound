using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fight with udead enemy until you die!");

            Person player = new Person("Player", 10, 10, 10, 10);
            player.CreatePerson();
            Console.WriteLine("Press a ENTER.. to fight with your enemy!");
            Console.Read();
            Console.WriteLine("FIGHT NOW!!!");


            EnemyPerson rndA = new EnemyPerson("Undead", 10, 10, 10);
            rndA.CreatePerson();
            int lvlCounter = 0;
            while (player.Health > 0)
            {
                Console.Clear();
                rndA.PrintPerson();
                player.PrintPerson();
                Battle.StartFight(player, rndA);

                Console.WriteLine("Undead is rising!");
                Console.WriteLine("Press ENTER... to fight again!\n");
                Console.ReadKey();
                rndA.Resurrection();
                lvlCounter++;
            }
            Console.WriteLine("\nBUT YOU ARE DEAD!     x___x GAME OVER x___x");
            Console.WriteLine($"You die in {lvlCounter} round!");
            Console.WriteLine($"You win: {lvlCounter - 1} times!");
            Console.ReadKey();
        }
    }
}
