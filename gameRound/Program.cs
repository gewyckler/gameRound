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

            Person a = new Person("Player", 10, 10, 10, 10);
            a.CreatePerson();
            Console.WriteLine("Press a ENTER.. to fight with your enemy!");
            Console.Read();
            Console.WriteLine("FIGHT NOW!!!");
            

            while (a.Health > 0)
            {
                EnemyPerson rndA = new EnemyPerson("Undead", 10, 10, 10, 10);
                rndA.CreatePerson();
                a.PrintPerson();
                rndA.PrintPerson();
                Battle.StartFight(a, rndA);
                Console.WriteLine("Undead rise again!\nPress ENTER...");
                Console.ReadKey();
            }
            Console.WriteLine("BUT YOU ARE DEAD!     x___x GAME OVER x___x");
            Console.ReadKey();
        }
    }
}
