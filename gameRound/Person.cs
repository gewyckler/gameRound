using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Person : IPointGiver
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

        public void AttackUp()
        {
            MaxAttack++;
            Console.WriteLine("Attack increas by 1 pt!");
        }

        public void AttackDown()
        {
            if (MaxAttack != 1)
            {
                MaxAttack--;
                Console.WriteLine("Healt decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Attack cannot be lower then 1 pt!");
            }
        
        }

        public void HealtUp()
        {
            Health++;
            Console.WriteLine("Health increas by 1 pt!");
        }

        public void HealtDown()
        {
            if (Health != 1)
            {
                Health--;
                Console.WriteLine("Health decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Healt cannot be lower then 1 pt!");
            }
            
        }

        public void BlockUp()
        {
            Block++;
            Console.WriteLine("Block increas by 1 pt!");
        }

        public void BlockDown()
        {
            if(Block != 1)
            {
                Block--;
                Console.WriteLine("Block decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Block cannot be lower then 1 pt!");
            }
        }

        public void DodgeUp()
        {
            Dodge++;
            Console.WriteLine("Dodge increas by 1 pt!");
        }

        public void DodgeDown()
        {
            if(Dodge != 1)
            {
                Dodge--;
                Console.WriteLine("Dodge decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Dodge cannot be lower then 1 pt!");
            }

        }
    }
}
