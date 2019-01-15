using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Person : IPointGiver, IWhatToDo
    {

        
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
            Random rnd = new Random();
            return (rnd.Next(1, MaxAttack));
        }
        public int Block()
        {
            Random rnd = new Random();
            return (rnd.Next(1, MaxBlock));
        }

        string GetName = "";
        Person player1 = new Person("", 10, 10, 10, 10);
        Person player2 = new Person("", 10, 10, 10, 10);

        public void CreatePerson()
        {
            Console.Write("Type a name of a character: ");
            GetName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Now you have 10 points to distribute. \n");
            Console.WriteLine("Click from 1 to 4 to add one point to each fetures!\n");
            Console.WriteLine("If you want to remove 1 point click (-) and (number from 1 to 4)!\n");

            
            Console.WriteLine("Basic stats ->");
            player1.PrintPerson();

            int count = 10;
            do
            {
                int addPoint = Convert.ToInt32(Console.ReadLine());

                AttackPointBtn ABtn = new AttackPointBtn(player1);
                HealthPointBtn HBtn = new HealthPointBtn(player1);
                BlockPointBtn BBtn = new BlockPointBtn(player1);
                DodgePointBtn DBtn = new DodgePointBtn(player1);
                if (addPoint <= 4)
                {

                    switch (addPoint)
                    {
                        case 1:
                            HBtn.PointUp();
                            player1.PrintPerson();
                            count--;
                            break;
                        case -1:
                            HBtn.PointDown();
                            player1.PrintPerson();
                            if (count < 10)
                                count++;
                            break;
                        case 2:
                            BBtn.PointUp();
                            player1.PrintPerson();
                            count--;
                            break;
                        case -2:
                            BBtn.PointDown();
                            player1.PrintPerson();
                            if (count < 10)
                                count++;
                            break;
                        case 3:
                            DBtn.PointUp();
                            player1.PrintPerson();
                            count--;
                            break;
                        case -3:
                            DBtn.PointDown();
                            player1.PrintPerson();
                            if (count < 10)
                                count++;
                            break;
                        case 4:
                            ABtn.PointUp();
                            player1.PrintPerson();
                            count--;
                            break;
                        case -4:
                            ABtn.PointDown();
                            player1.PrintPerson();
                            if (count < 10)
                                count++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("No point added!");
                    Console.WriteLine("Make sure you click buttons from 1 to 4!\n");
                    player1.PrintPerson();
                    Console.WriteLine($"You have {count} more points");
                    continue;
                }
                Console.WriteLine($"You have {count} more points");
            } while (count != 0);
            Console.WriteLine("You distributed all points!");
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Name: {player1.GetName}");
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

        //Person man1 = new Person("nameA", 0, 0, 0, 0);
        //Person man2 = new Person("nameB", 0, 0, 0, 0);


        public void DoAttack()
        {
            int dmgToPlayerB = player1.Attack();
            int playerBHealth = player2.Health - dmgToPlayerB;
            Console.WriteLine($"{player1.Name} attack {player2.Name}, hit him and deals {dmgToPlayerB} pt.");
            Console.WriteLine($"{player2.Name} health is now {playerBHealth}.");
        }

        public void DoBlock()
        {
            int playerAHealth = player2.Attack() - player1.Block();
            int playerABlock = player1.Block();

            Console.WriteLine($"{player1.Name} try to block {player2.Name}'s attack. {player1.Name} get {playerABlock} less damage.");
            Console.WriteLine($"{player1.Name} health is now {playerAHealth}.");
        }

        public void DoDodge()
        {
            Console.WriteLine($"{player1.Name} dodge {player2.Name}'s attack.");
        }
    }
}
