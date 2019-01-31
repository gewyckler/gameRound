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
            //zmienic w PRINT PERSON z NAME na GETNAME
            Person a = new Person("Human", 10, 10, 10, 10);
            EnemyPerson rndA = new EnemyPerson("CPU", 1, 1, 1, 1);




            ////a.CreatePerson();
            //Console.WriteLine("Click button to creat enemy");
            //Console.ReadKey();
            ////rndA.CreatePerson();
            //a.PrintPerson();
            //rndA.PrintPerson();

            Battle.StartFight(a, rndA);

            Console.ReadKey();


        }
    }
}
