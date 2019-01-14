using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class BlockPointBtn : ICommands
    {
        IPointGiver BPoint;
        public BlockPointBtn (IPointGiver Bpoint)
        {
            BPoint = Bpoint;
        }
        public void PointDown()
        {
            BPoint.BlockDown();
        }

        public void PointUp()
        {
            BPoint.BlockUp();
        }
    }
}
