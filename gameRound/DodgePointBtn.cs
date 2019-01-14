using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class DodgePointBtn : ICommands
    {
        IPointGiver DPoint;
        public DodgePointBtn (IPointGiver Dpoint)
        {
            DPoint = Dpoint;
        }
        public void PointDown()
        {
            DPoint.DodgeDown();
        }

        public void PointUp()
        {
            DPoint.DodgeUp();
        }
    }
}
