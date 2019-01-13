using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a name of a character: ");
            string GetName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Now you have 10 points to distribute. \n");


            Person man1 = new Person(GetName, 1, 1, 1, 1);
            
            Console.WriteLine("Basic stats ->");
            man1.PrintPerson();
            Console.WriteLine("Click from 1 to 4 to add one point to each fetures!");

            int count = 0;
            while (count != 10)
            {
                count++;
                int addPoint = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You have {10 - count} more points");

                switch (addPoint)
                {
                    case 1:
                        man1.Health++;
                        man1.PrintPerson();
                        break;
                    case 2:
                        man1.Block++;
                        man1.PrintPerson();
                        break;
                    case 3:
                        man1.Dodge++;
                        man1.PrintPerson();
                        break;
                    case 4:
                        man1.MaxAttack++;
                        man1.PrintPerson();
                        break;

                }
            }
            Console.WriteLine("You distributed all points!");
            

            

            Console.ReadKey();
        }
    }
}
