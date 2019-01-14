using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class DodgeRandom
    {
        Person playerA = new Person("nameA", 10, 10, 10, 10);
        Person playerB = new Person("nameB", 10, 10, 10, 10);
        public DodgeRandom()
        {
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
