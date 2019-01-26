using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Battle
    {
        public static void StartFight(Person playerA, EnemyPerson playerB)
        {
            while (true)
            {
                if (GetAttackResoult(playerA, playerB) == "You win")
                {
                    Console.WriteLine("You Win.");
                    break;
                }
                if (GetAttackResoult(playerA, playerB) == "You lose")
                {
                    Console.WriteLine("You Lose.");
                    break;
                }
            }
        }

        public static string GetAttackResoult(Person player1, EnemyPerson player2)
        {
            if (player2.Health <= 0)
            {
                return "You win";
            }
            if (player1.Health <= 0)
            {
                return "You lose";
            }
            int p2Attack = player2.Attack();
            int p1Block = player1.Block();
            int p2Block = player2.Block();
            
            Console.WriteLine(player1.Health);
            Console.WriteLine(player2.Health);

            Console.WriteLine("Your turn!");

            Console.WriteLine($"\n{player1.Name} Chose what you want to do:\n");
            Console.WriteLine($"[1] Attack {player2.Name}.");
            Console.WriteLine($"[2] Block - nothing to block");
            Console.WriteLine($"[3] Dodge - nothing to dodge");
            Console.WriteLine($"[4] Healing.");
            int choose;
            do
            {
                Console.Write("Do: ");
                choose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (choose == 1) //Player attack CPU
                {
                    int p1Attack = player1.Attack();
                    int dmgTop2 = p1Attack - p2Block;
                    Console.WriteLine($"{player1.Name} attack {player2.Name} and deals {p1Attack} damage pt.");
                    Random cpuDo = new Random();
                    int action = 2;
                    if (action == 2 || action == 5 || action == 6) //CPU Block
                    {
                        Console.WriteLine($"{player2.Name} block your attack by {p2Block} pt.");
                        Console.WriteLine($"Damage deals to {player2.Name} = {dmgTop2} pt.");
                        player2.Health = player2.Health - dmgTop2;
                        Console.WriteLine($"{player2.Name} health = {player2.Health} pt.\n");
                    }
                    if (action == 3) //CPU Dodge
                    {
                        Console.WriteLine("jescze nic tu nie ma");
                    }
                    if (action == 4) //CPU Healing
                    {
                        //if (p2Health == player2.Health)
                        //{
                        //    Console.WriteLine("CPU cannot health himself!");
                        //}
                        //if 
                        //{
                        //    Console.WriteLine($"{player2.Name} heal himself by +5 pt.");
                        //    player2.EnemyHealing();
                        //    //Console.WriteLine($"= {p2Health} + {5} = {p2Health + 5}.");

                        //}
                        //else
                        //{
                        //    Console.WriteLine("This option is pointles");
                        //    continue;
                        //}
                    }
                }
                if (choose == 4)
                {
                    int p1H = player1.Health;
                    if(player1.Health == p1H)
                    {
                        Console.WriteLine("max");
                    }
                    if(player1.Health < p1H)
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            player1.Health++;
                        }
                    }
                }
            } while (choose != 1 && choose != 4) ;

        if (player2.Health <= 0)
        {
            return "You win";
        }
        if (player1.Health <= 0)
        {
                        return "You lose";
        }
            Console.WriteLine("CPU turn! \n");
            Random cpuDo2 = new Random();

            int cpuAction = cpuDo2.Next(1, 2);

            if (cpuAction == 1) //CPU attack Player
            {                    
                Console.WriteLine($"{player2.Name} attack {player1.Name}.");

                Console.WriteLine($"\n{player1.Name} Chose what you want to do:\n");
                Console.WriteLine($"[1] Attack {player2.Name} -> unavalibe!");
                Console.WriteLine($"[2] Block");
                Console.WriteLine($"[3] Dodge");
                Console.WriteLine($"[4] Healing.");
                int choose2;
                do
                {
                    int dmgTop1 = p2Attack - p1Block;
                    Console.Write("Do: ");
                    choose2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (choose2 == 2) //Player Block
                    {
                        Console.WriteLine($"{player2.Name} deal {p2Attack} damage to you.");
                        Console.WriteLine($"You try to block it by {p1Block} block pt.");
                        Console.WriteLine($"You take {dmgTop1} damage.");
                        player1.Health = player1.Health - dmgTop1;
                        Console.WriteLine($"Your heath = {player1.Health} pt.\n");
                    }
                    else if (choose2 == 3) //Player Dodge
                    {
                        player1.DoDodge();
                    }
                    else if (choose2 == 4) //Player Healing
                    {
                                           
                    }
                    else
                    {
                        Console.WriteLine("This option is pointless!");
                        continue;
                    }
                } while (choose2 != 2 && choose != 3 && choose != 4);
            }

            else if (cpuAction == 2) //CPU Healing
            {
                
            }
            if (player2.Health <= 0)
            {
                return "You win";
            }
            if (player1.Health <= 0)
            {
                return "You lose";
            }
            else
                return "nothing";
                    
        }
    }
}

    

