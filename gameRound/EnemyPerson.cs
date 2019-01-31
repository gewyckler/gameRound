using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class EnemyPerson : IPointGiver
    {
        public string Name { get; set; }
        public int MaxAttack { get; set; }
        public int Health { get; set; }
        public int MaxBlock { get; set; }
        public int Dodge { get; set; }
        public int Level { get; set; }

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
            Random dblRnd = new Random();
            double atk = dblRnd.NextDouble();

            if (MaxAttack == 10)
            {
                return rnd.Next(1, MaxAttack);
            }
            if (MaxAttack >= 15 && MaxAttack < 25)
            {
                if (atk <= 0.50)
                {
                    int MinAttack = MaxAttack - 10;
                    return rnd.Next(MinAttack, MaxAttack);
                }
                else
                {
                    return rnd.Next(1, MaxAttack);
                }
            }
            if (MaxAttack >= 25 && MaxAttack < 35)
            {
                if (atk <= 0.55)
                {
                    int MinAttack = MaxAttack - 15;
                    return rnd.Next(MinAttack, MaxAttack);
                }
                else
                {
                    return rnd.Next(1, MaxAttack);
                }
            }
            if (MaxAttack >= 35 && MaxAttack < 45)
            {
                if (atk <= 0.60)
                {
                    int MinAttack = MaxAttack - 15;
                    return rnd.Next(MinAttack, MaxAttack);
                }
                else
                {
                    return rnd.Next(1, MaxAttack);
                }
            }
            if (MaxAttack >= 45)
            {
                if (atk <= 0.65)
                {
                    int MinAttack = MaxAttack - 15;
                    return rnd.Next(MinAttack, MaxAttack);
                }
                else
                {
                    return rnd.Next(1, MaxAttack);
                }
            }
            else
                return rnd.Next(1, MaxAttack);
        }
        public int Block()
        {
            Random rnd = new Random();
            return (rnd.Next(1, MaxBlock));
        }
        public void CreatePerson()
        {
            Random pRnd = new Random();
            int count = 10;
            do
            {
                double skillPt = pRnd.NextDouble();
                if (skillPt <= 0.40)
                {
                    HealthUp();
                    PrintPerson();
                    count--;
                }
                if (skillPt > 0.40 && skillPt <= 0.80)
                {
                    AttackUp();
                    PrintPerson();
                    count--;
                }
                if (skillPt > 0.80 && skillPt <= 0.89)
                {
                    BlockUp();
                    PrintPerson();
                    count--;
                }
                if (skillPt > 0.89 && skillPt <= 1.00)
                {
                    DodgeUp();
                    PrintPerson();
                    count--;
                }
               
            } while (count != 0);
            Console.Clear();
            
        }
        public void PrintPerson()
        {
            Console.WriteLine($"Name: {Name}");
           
            Console.WriteLine($"[1] Healt: {Health}");
            Console.WriteLine($"[4] Attack: {MaxAttack}");
            Console.WriteLine($"[2] Block: {MaxBlock}");
            Console.WriteLine($"[3] Dodge: {Dodge}\n");
            

        }

        public void AttackUp()
        {
            MaxAttack += 5;
            Console.WriteLine("Attack increas by 1 pt!");
        }

        public void AttackDown()
        {
            if (MaxAttack != 1)
            {
                MaxAttack -= 5;
                Console.WriteLine("Healt decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Attack cannot be lower then 1 pt!");
            }

        }

        public void HealthUp()
        {
            Health += 5;
            Console.WriteLine("Health increas by 1 pt!");
        }

        public void HealthDown()
        {
            if (Health != 1)
            {
                Health -= 5;
                Console.WriteLine("Health decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Healt cannot be lower then 1 pt!");
            }

        }

        public void BlockUp()
        {
            MaxBlock += 5;
            Console.WriteLine("Block increas by 1 pt!");
        }

        public void BlockDown()
        {
            if (MaxBlock != 1)
            {
                MaxBlock -= 5;
                Console.WriteLine("Block decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Block cannot be lower then 1 pt!");
            }
        }

        public void DodgeUp()
        {
            Dodge += 5;
            Console.WriteLine("Dodge increas by 1 pt!");
        }

        public void DodgeDown()
        {
            if (Dodge != 1)
            {
                Dodge -= 5;
                Console.WriteLine("Dodge decreas by 1 pt!");
            }
            else
            {
                Console.WriteLine("Dodge cannot be lower then 1 pt!");
            }

        }
    }
}
