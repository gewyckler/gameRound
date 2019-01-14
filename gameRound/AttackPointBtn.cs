﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class AttackPointBtn : ICommands
    {
        IPointGiver APoint; 
        public AttackPointBtn (IPointGiver Apoint)
        {
            this.APoint = Apoint;
        }

        public void PointDown()
        {
            APoint.AttackDown();
        }

        public void PointUp()
        {
            APoint.AttackUp();
        }
    }
}
