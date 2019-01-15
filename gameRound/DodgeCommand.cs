using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class DodgeCommand : IBattleCommands
    {
        IWhatToDo GoDodge;
        public DodgeCommand (IWhatToDo goDodge)
        {
            GoDodge = goDodge;
        }
        public void Execute()
        {
            GoDodge.DoDodge();
        }
    }
}
