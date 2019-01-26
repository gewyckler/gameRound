using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class EnemyPerson : IEnemyActions
    {
        public string Name { get; set; }
        public int MaxAttack { get; set; }
        public int Health { get; set; }
        public int MaxBlock { get; set; }
        public int Dodge { get; set; }



        public EnemyPerson(string name, int healt, int maxBlock, int dodge, int maxAttack)
        {
            Console.WriteLine("tworze postac");
            Name = name;
            Health = healt;
            MaxBlock = maxBlock;
            Dodge = dodge;
            MaxAttack = maxAttack;
        }

        public int Attack()
        {
            Random rnd = new Random();
            return (rnd.Next(1, MaxAttack));
        }
        public int Block()
        {
            Random rnd = new Random();
            return (rnd.Next(1, MaxBlock));
        }

        public void EnemyAttack()
        {
            int pAttack = Attack();
            Console.WriteLine($"{Name} attack by {pAttack} pt.\n");
            Health = Health - pAttack;
        }

        public void EnemyBlock()
        {
            int pBlock = Block();
            Console.WriteLine($"{Name} block opponent's attack by {pBlock} pt.\n");
            int pHealth = Health;
            int pAttack = Attack();
            Console.WriteLine($"{Name}'s health is {pHealth - pAttack + pBlock} pt.\n");
        }

        public void EnemyDodge()
        {
            Console.WriteLine($"Dodge or not\n");
        }

        public void EnemyHealing()
        {
            Health = Health + 5;
            Console.WriteLine($"Healt increas + 5 pt.");
        }
    }
}
