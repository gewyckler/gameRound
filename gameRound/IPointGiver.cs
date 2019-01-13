using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    interface IPointGiver
    {
        void Healt();
        void Block();
        void Dodge();
        void AttackUp();
        void AttackDown();

    }
}
