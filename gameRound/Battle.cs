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

        public int WhoStart()
        {
            Random whoStart = new Random();
            
            return whoStart.Next(0, 1);
        }

        public static string GetAttackResoult(Person player1, Person player2)
        {
            
                Console.WriteLine($"\n{player1.Name} Chose what you want to do:\n");
                Console.WriteLine($"[1] Attack {player2.Name}.");
                Console.WriteLine($"[2] Block {player2.Name}'s next attack.");
                Console.WriteLine($"[3] Try to dodge {player2.Name}'s next attack");
                Console.WriteLine($"[4] Heal yourself (+5 HP).");

                int chose = Convert.ToInt32(Console.ReadLine());

                int p1Attack = player1.Attack();
                int p1Health = player1.Health - player2.Attack();
                int p2Health = player2.Health - player1.Attack();

            switch (chose)
            {
                case 1:
                    do
                    {
                        player1.DoAttack();
                        Console.WriteLine($"{player1.Name} attack {player2.Name} by {p1Attack}");
                        Console.WriteLine($"{player2.Name} health = {p2Health}");
                    } while (p2Health <= 0);
                    
                    break;
                case 2:
                    player1.DoBlock();
                    Console.WriteLine($"{player1.Name} health is now {p1Health} + {player1.Block()} = {p1Health + player1.Block()}");
                    break;
                case 3:
                    player1.DoDodge();
                    Console.WriteLine("You dodge or not");
                    break;
                case 4:
                    player1.DoHealing();
                    break;
            }
            if (player2.Health <= 0)
            {
                Console.WriteLine($"{player2.Name} die!");
            }
            return "Fight again";
            
           
            
            
        }

    }
}
