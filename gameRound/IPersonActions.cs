﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    interface IPersonActions
    {
        void DoAttack();
        void DoBlock();
        void DoDodge();
        void DoHealing();
    }
}