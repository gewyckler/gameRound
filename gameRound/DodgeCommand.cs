using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class DodgeCommand : IBattleCommands
    {
        IPersonActions GoDodge;
        public DodgeCommand (IPersonActions goDodge)
        {
            GoDodge = goDodge;
        }
        public void Execute()
        {
            GoDodge.DoDodge();
        }
    }
}
