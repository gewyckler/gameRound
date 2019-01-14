using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Person : IPointGiver, IWhatToDo
    {

        Random rnd = new Random();
        public string Name { get; set; }
        public int MaxAttack { get; set; }
        public int Health { get; set; }
        public int MaxBlock { get; set; }
        public int Dodge { get; set; }
        public Person(string name, int healt, int maxBlock, int dodge, int maxAttack)
        {
            Name = name;
            Health = healt;
            MaxBlock = maxBlock;
            Dodge = dodge;
            MaxAttack = maxAttack;
        }
        public int Attack()
        {
            return (rnd.Next(1, MaxAttack));
        }
        public int Block()
        {
            return (rnd.Next(1, MaxBlock));
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"[1] Healt: {Health}");
            Console.WriteLine($"[2] Block: {MaxBlock}");
            Console.WriteLine($"[3] Dodge: {Dodge}");
            Console.WriteLine($"[4] Attack: {MaxAttack}\n");

        }

        public void AttackUp()
        {
            MaxAttack+=5;
            Console.WriteLine("Attack increas by 1 pt!");
        }

        public void AttackDown()
        {
            if (MaxAttack != 1)
            {
                MaxAttack-=5;
                Console.WriteLine("Healt decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Attack cannot be lower then 1 pt!");
            }
        
        }

        public void HealtUp()
        {
            Health+= 5;
            Console.WriteLine("Health increas by 1 pt!");
        }

        public void HealtDown()
        {
            if (Health != 1)
            {
                Health-=5;
                Console.WriteLine("Health decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Healt cannot be lower then 1 pt!");
            }
            
        }

        public void BlockUp()
        {
            MaxBlock+=5;
            Console.WriteLine("Block increas by 1 pt!");
        }

        public void BlockDown()
        {
            if(MaxBlock != 1)
            {
                MaxBlock-=5;
                Console.WriteLine("Block decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Block cannot be lower then 1 pt!");
            }
        }

        public void DodgeUp()
        {
            Dodge+=5;
            Console.WriteLine("Dodge increas by 1 pt!");
        }

        public void DodgeDown()
        {
            if(Dodge != 1)
            {
                Dodge-=5;
                Console.WriteLine("Dodge decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Dodge cannot be lower then 1 pt!");
            }

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
            int playerAHealth = playerB.Attack() - playerA.Block();
            int playerABlock = playerA.Block();

            Console.WriteLine($"{playerA.Name} try to block {playerB.Name}'s attack. {playerA.Name} get {playerABlock} less damage.");
            Console.WriteLine($"{playerA.Name} health is now {playerAHealth}.");
        }

        public void DoDodge()
        {
            Console.WriteLine($"{playerA.Name} dodge {playerB.Name}'s attack.");
        }
    }
}
