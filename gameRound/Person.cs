using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Person : IPointGiver
    {
        public string Name { get; set; }
        public int MaxAttack { get; set; }
        public int MaxAttackPt { get; set; }
        public int Health { get; set; }
        public int HealthPt { get; set; }
        public int MaxBlock { get; set; }
        public int MaxBlockPt { get; set; }
        public int Dodge { get; set; }
        public int DodgePt { get; set; }
        public int StartLevel { get; set; }
        public int StartExp { get; set; }
        public Person(string name, int healthPt, int maxBlockPt, int dodgePt, int maxAttackPt)
        {
            Name = name;
            HealthPt = healthPt;
            MaxBlockPt = maxBlockPt;
            DodgePt = dodgePt;
            MaxAttackPt = maxAttackPt;
            StartLevel = 1;
            StartExp = 0;
        }
        public void HealthStats()
        {
            if (HealthPt <= 10)
            {
                Health = 10;
            }
            if (HealthPt > 10 && HealthPt <= 12)
            {
                Health = 15;
            }
            if (HealthPt > 12 && HealthPt <= 14)
            {
                Health = 20;
            }
            if (HealthPt > 14 && HealthPt <= 16)
            {
                Health = 25;
            }
            if (HealthPt > 16 && HealthPt <= 18)
            {
                Health = 30;
            }
            if (HealthPt > 18 && HealthPt <= 20)
            {
                Health = 35;
            }
            if (HealthPt > 20)
            {
                Health = 40;
            }

        }
        public void LevelUp()
        {
            Random rnd = new Random();
            int points = rnd.Next(2, 5);
            StartExp = StartExp + points;
            Console.WriteLine($"+ {points} exp!");

            if (StartExp >= 10)
            {
                Console.Clear();
                Console.WriteLine("Level Up!\n");
                StartExp = StartExp - 10;
                ++StartLevel;
                Console.WriteLine("You got 2 skill point to spend!\n");
                PrintPerson();
                int countP = 2;
                do
                {
                    Console.Write("Choose feature to increase: ");
                    int spendPoint = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (spendPoint <= 4)
                    {
                        switch (spendPoint)
                        {
                            case 1:
                                HealthUp();
                                PrintPerson();
                                countP--;
                                break;
                            case 2:
                                AttackUp();
                                PrintPerson();
                                countP--;
                                break;
                            case 3:
                                BlockUp();
                                PrintPerson();
                                countP--;
                                break;
                            case 4:
                                DodgeUp();
                                PrintPerson();
                                countP--;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No point added!");
                        PrintPerson();
                        Console.WriteLine("Make sure you click buttons from 1 to 4!\n");
                        Console.WriteLine($"You have {countP} more points");

                        continue;
                    }
                    Console.WriteLine($"You have {countP} more points");
                } while (countP != 0);
                Console.Clear();
                Console.WriteLine("You distribute all points!\n");
                PrintPerson();
                
            }
            else
                StartLevel = StartLevel;
        }
        public void AttackStats()
        {
            if (MaxAttackPt <= 10)
            {
                MaxAttack = 10;
            }
            if (MaxAttackPt > 10 && HealthPt <= 12)
            {
                MaxAttack = 15;
            }
            if (MaxAttackPt > 12 && HealthPt <= 14)
            {
                MaxAttack = 20;
            }
            if (MaxAttackPt > 14 && HealthPt <= 16)
            {
                MaxAttack = 25;
            }
            if (MaxAttackPt > 16 && HealthPt <= 18)
            {
                MaxAttack = 30;
            }
            if (MaxAttackPt > 18 && HealthPt <= 20)
            {
                MaxAttack = 35;
            }
            if (MaxAttackPt > 20)
            {
                MaxAttack = 40;
            }
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
            if (MaxAttack >= 35 && MaxAttack <= 40)
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
            if (MaxAttack > 40)
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
            return rnd.Next(1, MaxBlock);
        }
        public void BlockStats()
        {
            if (MaxBlockPt <= 10)
            {
                MaxBlock = 10;
            }
            if (MaxBlockPt > 10 && HealthPt <= 12)
            {
                MaxBlock = 15;
            }
            if (MaxBlockPt > 12 && HealthPt <= 14)
            {
                MaxBlock = 20;
            }
            if (MaxBlockPt > 14 && HealthPt <= 16)
            {
                MaxBlock = 25;
            }
            if (MaxBlockPt > 16 && HealthPt <= 18)
            {
                MaxBlock = 30;
            }
            if (MaxBlockPt > 18 && HealthPt <= 20)
            {
                MaxBlock = 35;
            }
            if (MaxBlockPt > 20)
            {
                MaxBlock = 40;
            }
        }
        public void DodgeStats()
        {
            if (DodgePt <= 10)
            {
                Dodge = 10;
            }
            if (DodgePt > 10 && HealthPt <= 12)
            {
                Dodge = 15;
            }
            if (DodgePt > 12 && HealthPt <= 14)
            {
                Dodge = 20;
            }
            if (DodgePt > 14 && HealthPt <= 16)
            {
                Dodge = 25;
            }
            if (DodgePt > 16 && HealthPt <= 18)
            {
                Dodge = 30;
            }
            if (DodgePt > 18 && HealthPt <= 20)
            {
                Dodge = 35;
            }
            if (DodgePt > 20)
            {
                Dodge = 40;
            }
        }
        

        string GetName = "";
        
        public void CreatePerson()
        {
            Console.Write("\nName your character: ");
            GetName = Console.ReadLine();
            Name = GetName;
            Console.Clear();
            Console.WriteLine("\nNow you have 10 points to distribute. \n");
            Console.WriteLine("Click from 1 to 4 to add one point to each fetures!\n");
            Console.WriteLine("If you want to remove 1 point click (-) and (number from 1 to 4)!\n");

            Console.WriteLine("Basic stats ->");
            PrintPerson();
            
            int count = 10;
            do
            {
                Console.WriteLine("Click from 1 to 4 to add one point to each fetures!\n");
                Console.WriteLine("If you want to remove 1 point click (-) and (number from 1 to 4)!\n");
                Console.Write("Choose: ");
                try
                {
                    int addPoint = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

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
                                    if (HealthPt != 10)
                                    {
                                        count++;
                                    }
                                    else { }
                                break;
                            case 2:
                                AttackUp();
                                PrintPerson();
                                count--;
                                break;
                            case -2:
                                AttackDown();
                                PrintPerson();
                                if (count < 10)
                                    if (MaxAttackPt != 10)
                                    {
                                        count++;
                                    }
                                    else { }
                                break;
                            case 3:
                                BlockUp();
                                PrintPerson();
                                count--;
                                break;
                            case -3:
                                BlockDown();
                                PrintPerson();
                                if (count < 10)
                                    if (MaxBlockPt != 10)
                                    {
                                        count++;
                                    }
                                    else { }
                                break;
                            case 4:
                                DodgeUp();
                                PrintPerson();
                                count--;
                                break;
                            case -4:
                                DodgeDown();
                                PrintPerson();
                                if (count < 10)
                                    if (DodgePt != 10)
                                    {
                                        count++;
                                    }
                                    else { }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No point added!");
                        PrintPerson();
                        Console.WriteLine("Make sure you click buttons from 1 to 4!\n");
                        Console.WriteLine($"You have {count} more points");
                        continue;
                    }
                    Console.WriteLine($"You have {count} more points");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Make sure you choose number form 1 to 4!");
                }
               
            } while (count != 0);
            Console.Clear();
            Console.WriteLine("You distributed all points!");
            PrintPerson();
        }

        public void PrintPerson()
        {
            Name = GetName;
            Console.WriteLine($"Name: {GetName}");

            
            Console.WriteLine($"Level: {StartLevel} (EXP: {StartExp}/10)");

            HealthStats();
            Console.WriteLine($"[1] Healt: {HealthPt} = {Health} HP.");

            AttackStats();
            Console.WriteLine($"[2] Attack: {MaxAttackPt} = {MaxAttack} Pt.");

            BlockStats();
            Console.WriteLine($"[3] Block: {MaxBlockPt} = {MaxBlock} Pt.");

            DodgeStats();
            Console.WriteLine($"[4] Dodge: {DodgePt} = {Dodge} Pt.\n");
        }

        public void AttackUp()
        {
            MaxAttackPt+=1;
            Console.WriteLine("Attack increas by 1 pt!\n");
        }

        public void AttackDown()
        {
            if (MaxAttackPt != 10)
            {
                MaxAttackPt-=1;
                Console.WriteLine("Healt decreas by 1 pt!\n");
            }
            else
            {
                Console.WriteLine("Attack cannot be lower then 10 pt!\n");
            }
        
        }

        public void HealthUp()
        {
            HealthPt += 1;
            Console.WriteLine("Health increas by 1 pt!\n");
        }

        public void HealthDown()
        {
            if (HealthPt != 10)
            {
                HealthPt -= 1;
                Console.WriteLine("Health decreas by 1 pt!\n");
            }
            else
            {
                Console.WriteLine("Healt cannot be lower then 10 pt!\n");
            }
            
        }

        public void BlockUp()
        {
            MaxBlockPt+=1;
            Console.WriteLine("Block increas by 1 pt!\n");
        }

        public void BlockDown()
        {
            if(MaxBlockPt != 10)
            {
                MaxBlockPt-=1;
                Console.WriteLine("Block decreas by 1 pt!\n");
            }
            else
            {
                Console.WriteLine("Block cannot be lower then 10 pt!\n");
            }
        }

        public void DodgeUp()
        {
            DodgePt+=1;
            Console.WriteLine("Dodge increas by 1 pt!\n");
        }

        public void DodgeDown()
        {
            if(DodgePt != 10)
            {
                DodgePt-=1;
                Console.WriteLine("Dodge decreas by 1 pt!\n");
            }
            else
            {
                Console.WriteLine("Dodge cannot be lower then 10 pt!\n");
            }

        }
    }
}
