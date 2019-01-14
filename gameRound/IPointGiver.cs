using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    interface IPointGiver
    {
        void HealtUp();
        void HealtDown();
        void BlockUp();
        void BlockDown();
        void DodgeUp();
        void DodgeDown();
        void AttackUp();
        void AttackDown();

    }
}
