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
            Person a = new Person("Human", 10, 1, 5, 10);

            EnemyPerson rndA = new EnemyPerson("CPU", 10, 1, 5, 10);

            Battle.StartFight(a, rndA);

            Console.ReadKey();


        }
    }
}
