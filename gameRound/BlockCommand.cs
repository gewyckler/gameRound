using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class BlockCommand : IBattleCommands
    {
        IWhatToDo GoBlock;
        public BlockCommand(IWhatToDo goBlock)
        {
            GoBlock = goBlock;
        }
        public void Execute()
        {
            GoBlock.DoBlock();
        }
    }
}
