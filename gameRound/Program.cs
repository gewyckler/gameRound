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
            PersonCreator player1 = new PersonCreator();
            //Console.Write("Type a name of a character: ");
            //string GetName = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("Now you have 10 points to distribute. \n");


            //Person man1 = new Person(GetName, 1, 1, 1, 1);
            
            //Console.WriteLine("Basic stats ->");
            //man1.PrintPerson();
            //Console.WriteLine("Click from 1 to 4 to add one point to each fetures!");

            //int count = 10;
            //do
            //{
            //    int addPoint = Convert.ToInt32(Console.ReadLine());
              
            //    AttackPointBtn ABtn = new AttackPointBtn(man1);
            //    HealthPointBtn HBtn = new HealthPointBtn(man1);
            //    BlockPointBtn BBtn = new BlockPointBtn(man1);
            //    DodgePointBtn DBtn = new DodgePointBtn(man1);
            //    if (addPoint <= 4)
            //    {
            //        count--;
            //        switch (addPoint)
            //        {
            //            case 1:
            //                HBtn.PointUp();
            //                man1.PrintPerson();
            //                break;
            //            case 2:
            //                BBtn.PointUp();
            //                man1.PrintPerson();
            //                break;
            //            case 3:
            //                DBtn.PointUp();
            //                man1.PrintPerson();
            //                break;
            //            case 4:
            //                ABtn.PointUp();
            //                man1.PrintPerson();
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("No point added!");
            //        Console.WriteLine("Make sure you click buttons from 1 to 4!\n");
            //        man1.PrintPerson();
            //        Console.WriteLine($"You have {count} more points");
            //        continue;
            //    }
            //    Console.WriteLine($"You have {count} more points");
            //} while (count != 0);
            //Console.WriteLine("You distributed all points!");
            

            

            Console.ReadKey();
        }
    }
}
