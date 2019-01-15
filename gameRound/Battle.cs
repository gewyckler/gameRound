using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Battle
    {
        public static void StartFight(Person playerA, Person playerB)
        {
            while (true)
            {
                if (GetAttackResoult(playerA, playerB) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResoult(playerB, playerA) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

            }
        }
        public static string GetAttackResoult(Person player1, Person player2)
        {
            Console.WriteLine($"{player1.Name}'s round!");
            Console.WriteLine("Chose what you want to do:");
            Console.WriteLine($"[1] Attack {player2.Name}");
            int chose = Convert.ToInt32(Console.ReadLine());
            switch (chose)
            {
                case 1:
                    AttackComand attackComand = new AttackComand(player1);
                    attackComand.Execute();
                    break;
                default:
                    Console.WriteLine("You chose wrong option!");
                    break;
            }
            return ("");
        }

    }
}
