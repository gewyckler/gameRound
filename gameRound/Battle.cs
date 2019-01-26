﻿using System;
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

            int p1Attack = player1.Attack();
            int p2Attack = player2.Attack();
            int p1Block = player1.Block();
            int p2Block = player2.Block();
            int p1Health = player1.Health;
            int p2Health = player2.Health;

            Console.WriteLine(player1.Health);
            Console.WriteLine(player2.Health);

            Console.WriteLine("Your turn!");

            Console.WriteLine($"\n{player1.Name} Chose what you want to do:\n");
            Console.WriteLine($"[1] Attack {player2.Name}.");
            Console.WriteLine($"[2] Block -> nothing to block");
            Console.WriteLine($"[3] Dodge -> nothing to dodge");
            Console.WriteLine($"[4] Healing -> +10 HP");
            Console.WriteLine($"    Your healt = {player1.Health}.");
            Console.WriteLine($"    {player2.Name} health = {player2.Health}.");
            int choose;
            do
            {
                Console.Write("Do: ");
                choose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //Player attack CPU
                if (choose == 1)
                {
                    Console.WriteLine($"{player1.Name} attack {player2.Name} and deals {p1Attack} damage pt.");
                    Random cpuDo = new Random();
                    double action = cpuDo.NextDouble();
                    Console.WriteLine(action);
                    //CPU Block
                    if (action <= 0.50) 
                    {
                        int dmgTop2 = p1Attack - p2Block;
                        if (dmgTop2 <= 0)
                        {
                            dmgTop2 = 1;
                            p2Block = 0;
                        }
                        Console.WriteLine($"{player2.Name} block your attack by {p2Block} pt.");
                        Console.WriteLine($"Damage deals to {player2.Name} = {dmgTop2} pt.");
                        player2.Health = player2.Health - dmgTop2;
                        Console.WriteLine($"{player2.Name} health = {player2.Health} pt.\n");
                    }
                    //CPU Dodge
                    if (action > 0.50 && action <= 0.75)
                    {
                        Console.WriteLine($"{player2.Name} try to dodge your attack.");
                        Random random = new Random();
                        if (player2.Dodge >= 10 && player2.Dodge < 20)
                        {
                            double value = random.NextDouble();
                            if (value > 0.10)
                            {
                                Console.WriteLine($"{player2.Name} fail dodging and get hit by {p1Attack}.");
                                player2.Health = player2.Health - p1Attack;
                                Console.WriteLine($"{player2.Name} health = {player2.Health}");
                            }
                            else
                            {
                                Console.WriteLine($"{player2.Name} dodge the attack.");
                            }
                        }
                        if (player2.Dodge >= 20 && player2.Dodge < 30)
                        {
                            double value = random.NextDouble();
                            if (value > 0.20)
                            {
                                Console.WriteLine($"{player2.Name} fail dodging and get hit by {p1Attack}.");
                                player2.Health = player2.Health - p1Attack;
                                Console.WriteLine($"{player2.Name} health = {player2.Health}");
                            }
                            else
                            {
                                Console.WriteLine($"{player2.Name} dodge the attack.");
                            }
                        }
                        if (player2.Dodge >= 30 && player2.Dodge < 40)
                        {
                            double value = random.NextDouble();
                            if (value > 0.30)
                            {
                                Console.WriteLine($"{player2.Name} fail dodging and get hit by {p1Attack}.");
                                player2.Health = player2.Health - p1Attack;
                                Console.WriteLine($"{player2.Name} health = {player2.Health}");
                            }
                            else
                            {
                                Console.WriteLine($"{player2.Name} dodge the attack.");
                            }
                        }
                        if (player2.Dodge >= 40 && player2.Dodge < 50)
                        {
                            double value = random.NextDouble();
                            if (value > 0.40)
                            {
                                Console.WriteLine($"{player2.Name} fail dodging and get hit by {p1Attack}.");
                                player2.Health = player2.Health - p1Attack;
                                Console.WriteLine($"{player2.Name} health = {player2.Health}");
                            }
                            else
                            {
                                Console.WriteLine($"{player2.Name} dodge the attack.");
                            }
                        }
                        if (player2.Dodge >= 50)
                        {
                            double value = random.NextDouble();
                            if (value > 0.50)
                            {
                                Console.WriteLine($"{player2.Name} fail dodging and get hit by {p1Attack}.");
                                player2.Health = player2.Health - p1Attack;
                                Console.WriteLine($"{player2.Name} health = {player2.Health}");
                            }
                            else
                            {
                                Console.WriteLine($"{player2.Name} dodge the attack.");
                            }
                        }
                    }
                    //CPU Healing
                    if (action >= 0.75 || player2.Health <= p2Health / 2) 
                    {
                        Console.WriteLine("zycie");

                    }
                }
                //Player Healing
                if (choose == 4)
                {
                    if(player1.Health == p1Health)
                    {
                        Console.WriteLine("Health alredy max");
                    }
                    if (player1.Health != p1Health )
                    {
                        player1.Health = player1.Health + 10;
                        Console.WriteLine($"Your health = {player1.Health}.");
                    }
                    else
                    {
                        Console.WriteLine("Your health is not low enought to be increased by 10.");
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
            //CPU attack Player
            if (cpuAction == 1) 
            {
                
                Console.WriteLine($"{player2.Name} attack {player1.Name}.");

                Console.WriteLine($"\n{player1.Name} Chose what you want to do:\n");
                Console.WriteLine($"[1] Attack {player2.Name} -> you are under attack!");
                Console.WriteLine($"[2] Block");
                Console.WriteLine($"[3] Dodge");
                Console.WriteLine($"[4] Healing -> +10 HP");
                Console.WriteLine($"    Your healt = {player1.Health}.");
                Console.WriteLine($"    {player2.Name} health = {player2.Health}.");
                int choose2;
                do
                {
                    
                    Console.Write("Do: ");
                    choose2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    //Player Block
                    if (choose2 == 2) 
                    {
                        int dmgTop1 = p2Attack - p1Block;
                        Console.WriteLine($"{player2.Name} deal {p2Attack} damage to you.");
                        if(dmgTop1 <= 0)
                        {
                            dmgTop1 = 1;
                            p1Block = 0;
                        }
                        Console.WriteLine($"You try to block it by {p1Block} block pt.");
                        Console.WriteLine($"You take {dmgTop1} damage.");
                        player1.Health = player1.Health - dmgTop1;
                        Console.WriteLine($"Your heath = {player1.Health} pt.\n");
                    }
                    //Player Dodge
                    else if (choose2 == 3) 
                    {
                        Random random = new Random();
                        if (player1.Dodge >= 10 && player1.Dodge < 20)
                        {
                            double value = random.NextDouble();
                            if (value > 0.10)
                            {
                                Console.WriteLine($"You fail dodging and get hit by {p2Attack}.");
                                player1.Health = player1.Health - p2Attack;
                                Console.WriteLine($"Your health = {player1.Health}");
                            }
                            else
                            {
                                Console.WriteLine("You dodge the attack.");
                            }
                        }
                        if (player1.Dodge >= 20  && player1.Dodge < 30)
                        {
                            double value = random.NextDouble();
                            if (value > 0.20)
                            {
                                Console.WriteLine($"You fail dodging and get hit by {p2Attack}.");
                                player1.Health = player1.Health - p2Attack;
                                Console.WriteLine($"Your health = {player1.Health}");
                            }
                            else
                            {
                                Console.WriteLine("You dodge the attack.");
                            }
                        }
                        if (player1.Dodge >= 30 && player1.Dodge < 40)
                        {
                            double value = random.NextDouble();
                            if (value > 0.30)
                            {
                                Console.WriteLine($"You fail dodging and get hit by {p2Attack}.");
                                player1.Health = player1.Health - p2Attack;
                                Console.WriteLine($"Your health = {player1.Health}");
                            }
                            else
                            {
                                Console.WriteLine("You dodge the attack.");
                            }
                        }
                        if (player1.Dodge >= 40 && player1.Dodge < 50)
                        {
                            double value = random.NextDouble();
                            if (value > 0.40)
                            {
                                Console.WriteLine($"You fail dodging and get hit by {p2Attack}.");
                                player1.Health = player1.Health - p2Attack;
                                Console.WriteLine($"Your health = {player1.Health}");
                            }
                            else
                            {
                                Console.WriteLine("You dodge the attack.");
                            }
                        }
                        if (player1.Dodge >= 50)
                        {
                            double value = random.NextDouble();
                            if (value > 0.50)
                            {
                                Console.WriteLine($"You fail dodging and get hit by {p2Attack}.");
                                player1.Health = player1.Health - p2Attack;
                                Console.WriteLine($"Your health = {player1.Health}");
                            }
                            else
                            {
                                Console.WriteLine("You dodge the attack.");
                                continue;
                            }
                        }
                        
                    }
                    //Player Healing
                    else if (choose2 == 4) 
                    {
                                           
                    }
                    else
                    {
                        Console.WriteLine("This option is pointless!");
                        continue;
                    }
                } while (choose2 == 1);
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

    

