using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class AttackComand : IBattleCommands
    {
        IWhatToDo GoAttack;
        public AttackComand (IWhatToDo goAttack)
        {
            GoAttack = goAttack;
        }
        public void Execute()
        {
            GoAttack.DoAttack();
        }
    }

}
