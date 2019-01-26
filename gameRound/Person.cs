using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Person : IPointGiver, IPersonActions
    {

        
        public string Name { get; set; }
        public int MaxAttack { get; set; }
        public int Health { get; set; }
        public int MaxBlock { get; set; }
        public int Dodge { get; set; }
        
        
        
        public Person(string name, int healt, int maxBlock, int dodge, int maxAttack)
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

        string GetName = "";

        public void CreatePerson()
        {
            Console.Write("Type a name of a character: ");
            GetName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Now you have 10 points to distribute. \n");
            Console.WriteLine("Click from 1 to 4 to add one point to each fetures!\n");
            Console.WriteLine("If you want to remove 1 point click (-) and (number from 1 to 4)!\n");

            Console.WriteLine("Basic stats ->");
            PrintPerson();

            int count = 10;
            do
            {
                int addPoint = Convert.ToInt32(Console.ReadLine());

                if (addPoint <= 4)
                {

                    switch (addPoint)
                    {
                        case 1:
                            HealthUp();
                            PrintPerson();
                            count--;
                            break;
                        case -1:
                            HealthDown();
                            PrintPerson();
                            if (count < 10)
                                count++;
                            break;
                        case 2:
                            BlockUp();
                            PrintPerson();
                            count--;
                            break;
                        case -2:
                            BlockDown();
                            PrintPerson();
                            if (count < 10)
                                count++;
                            break;
                        case 3:
                            DodgeUp();
                            PrintPerson();
                            count--;
                            break;
                        case -3:
                            DodgeDown();
                            PrintPerson();
                            if (count < 10)
                                count++;
                            break;
                        case 4:
                            AttackUp();
                            PrintPerson();
                            count--;
                            break;
                        case -4:
                            AttackDown();
                            PrintPerson();
                            if (count < 10)
                                count++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("No point added!");
                    Console.WriteLine("Make sure you click buttons from 1 to 4!\n");
                    PrintPerson();
                    Console.WriteLine($"You have {count} more points");
                    continue;
                }
                Console.WriteLine($"You have {count} more points");
            } while (count != 0);
            Console.WriteLine("You distributed all points!");
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

        public void HealthUp()
        {
            Health+= 5;
            Console.WriteLine("Health increas by 1 pt!");
        }

        public void HealthDown()
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
        
        public void DoAttack()
        {
            int pAttack = Attack();
            Console.WriteLine($"{Name} attack by {pAttack} pt.\n");
            Health = Health - pAttack;

        }

        public void DoBlock()
        {
            int pBlock = Block();
            Console.WriteLine($"{Name} block opponent's attack by {pBlock} pt.\n");
            int pHealth = Health;
            int pAttack = Attack();
            Console.WriteLine($"{Name}'s health is {pHealth - pAttack + pBlock} pt.\n");
        }

        public void DoDodge()
        {
            
        }
        public void DoHealing()
        {
          
        }
    }
}
