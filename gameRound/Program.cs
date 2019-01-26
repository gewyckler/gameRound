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
            Person a = new Person("", 100, 4, 10, 15);

            EnemyPerson rndA = new EnemyPerson("CPU", 100, 4, 10, 35);
            a.CreatePerson();
            Battle.StartFight(a, rndA);

            Console.ReadKey();


        }
    }
}
