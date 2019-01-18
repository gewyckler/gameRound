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
            
            Person a = new Person("Human", 100, 100, 100, 100);
            
            Person rndA = new Person("Enemy", 100, 100, 100, 100);

            Battle.StartFight(a, rndA);

            
        }
    }
}
