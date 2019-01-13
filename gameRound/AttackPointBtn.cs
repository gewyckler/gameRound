using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class AttackPointBtn : ICommands
    {
        IPointGiver point; 
        public AttackPointBtn (IPointGiver point)
        {
            this.point = point;
        }

        public void PointDown()
        {
            point.AttackDown();
        }

        public void PointUp()
        {
            point.AttackUp();
        }
    }
}
