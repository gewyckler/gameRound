using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class HealthPointBtn : ICommands
    {
        IPointGiver HPoint;
        public HealthPointBtn(IPointGiver Hpoint)
        {
            this.HPoint = Hpoint;
        }

        public void PointDown()
        {
            HPoint.HealtDown();
        }

        public void PointUp()
        {
            HPoint.HealtUp();
        }
    }
}
