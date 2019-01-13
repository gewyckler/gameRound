using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Person
    {

        Random rnd = new Random();
        public string Name { get; set; }
        public int MaxAttack { get; set; }
        public int Health { get; set; }
        public int Block { get; set; }
        public int Dodge { get; set; }
        public Person(string name, int healt, int block, int dodge, int maxAttack)
        {
            Name = name;
            Health = healt;
            Block = block;
            Dodge = dodge;
            MaxAttack = maxAttack;
        }
        public int Attack()
        {
            return (rnd.Next(1, MaxAttack));
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"[1] Healt: {Health}");
            Console.WriteLine($"[2] Block: {Block}");
            Console.WriteLine($"[3] Dodge: {Dodge}");
            Console.WriteLine($"[4] Attack: {MaxAttack}\n");

        }


    }
}
