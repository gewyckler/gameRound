using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Battle : IWhatToDo
    {
        public static void StartBattle(PersonCreator player1, PersonCreator player2)
        {
            while(true)
            {
                if (GetAttackResoult(player1, player2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResoult(player2, player1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        public static string GetAttackResoult(PersonCreator playerA, PersonCreator playerB)
        {
            int playerAAttack = playerA.Attack();
            int playerBDamage = playerB.Health - playerAAttack;
            playerB.Health = playerB.Health - playerBDamage;

            Console.WriteLine($"{playerA.Name} attack {playerB.Name} by {playerAAttack} and deal {playerBDamage} to {playerB.Name}");
            Console.WriteLine($"{playerB.Name} block");
            return "";
        }
        Person playerA = new Person("nameA", 10, 10, 10, 10);
        Person playerB = new Person("nameB", 10, 10, 10, 10);
        public void DoAttack()
        {
            int dmgToPlayerB = playerA.Attack();
            int playerBHealth = playerB.Health - dmgToPlayerB;
            Console.WriteLine($"{playerA.Name} attack {playerB.Name}, hit him by {playerA.Attack()} and deal {dmgToPlayerB}.");
            Console.WriteLine($"{playerB.Name} health is now {playerBHealth}.");
        }

        public void DoBlock()
        {
            int playerBHealth = playerA.Attack() - playerB.Block();
            int playerBBlock = playerB.Block();

            Console.WriteLine($"{playerB.Name} try to block {playerA.Name}'s attack. {playerB.Name} get {playerBBlock} less damage.");
            Console.WriteLine($"{playerB.Name} health is now {playerBHealth}.");
            
        }

        public void DoDodge()
        {
            Person playerA = new Person("nameA", 10, 10, 10, 10);
            Person playerB = new Person("nameB", 10, 10, 10, 10);
            Console.WriteLine($"{playerB.Name} try to dodge {playerA.Name}'s attack.");

            Random chance = new Random();
            int dmgToPlayerB = playerA.Attack();
            if (playerB.Dodge == 10)
            {
                int r = chance.Next(1, 100);
                if (r <= 20)
                {
                    Console.WriteLine($"{playerB.Name} dodge {playerA.Name}'s attack.");
                    Console.WriteLine($"{playerB.Name} health is {playerB.Health}.");
                }
                else
                {
                    Console.WriteLine($"{playerB.Name} fail dodge and get hit by {playerA.Name} by {dmgToPlayerB}.");
                }
            }
            else if (playerB.Dodge > 10 && playerB.Dodge <= 20)
            {
                int r = chance.Next(1, 100);
                if (r <= 30)
                {
                    Console.WriteLine($"{playerB.Name} dodge {playerA.Name}'s attack.");
                    Console.WriteLine($"{playerB.Name} health is {playerB.Health}.");
                }
                else
                {
                    Console.WriteLine($"{playerB.Name} fail dodge and get hit by {playerA.Name} by {dmgToPlayerB}.");
                }
            }
            else if (playerB.Dodge > 20 && playerB.Dodge <= 30)
            {
                int r = chance.Next(1, 100);
                if (r <= 40)
                {
                    Console.WriteLine($"{playerB.Name} dodge {playerA.Name}'s attack.");
                    Console.WriteLine($"{playerB.Name} health is {playerB.Health}.");
                }
                else
                {
                    Console.WriteLine($"{playerB.Name} fail dodge and get hit by {playerA.Name} by {dmgToPlayerB}.");
                }
            }
            else if (playerB.Dodge > 30 && playerB.Dodge <= 40)
            {
                int r = chance.Next(1, 100);
                if (r <= 45)
                {
                    Console.WriteLine($"{playerB.Name} dodge {playerA.Name}'s attack.");
                    Console.WriteLine($"{playerB.Name} health is {playerB.Health}.");
                }
                else
                {
                    Console.WriteLine($"{playerB.Name} fail dodge and get hit by {playerA.Name} by {dmgToPlayerB}.");
                }
            }
            else if (playerB.Dodge > 40 && playerB.Dodge <= 50)
            {
                int r = chance.Next(1, 100);
                if (r <= 50)
                {
                    Console.WriteLine($"{playerB.Name} dodge {playerA.Name}'s attack.");
                    Console.WriteLine($"{playerB.Name} health is {playerB.Health}.");
                }
                else
                {
                    Console.WriteLine($"{playerB.Name} fail dodge and get hit by {playerA.Name} by {dmgToPlayerB}.");
                }
            }
            else if (playerB.Dodge > 50)
            {
                int r = chance.Next(1, 100);
                if (r <= 55)
                {
                    Console.WriteLine($"{playerB.Name} dodge {playerA.Name}'s attack.");
                    Console.WriteLine($"{playerB.Name} health is {playerB.Health}.");
                }
                else
                {
                    Console.WriteLine($"{playerB.Name} fail dodge and get hit by {playerA.Name} by {dmgToPlayerB}.");
                }
            }
        }

    }
    
}
