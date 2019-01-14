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
            PersonCreator player2 = new PersonCreator();
            Battle.StartBattle(player1, player2);
            Console.ReadKey();
        }
    }
}
