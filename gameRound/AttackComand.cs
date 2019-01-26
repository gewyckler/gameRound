using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    class AttackComand : IBattleCommands
    {
        IPersonActions GoAttack;
        public AttackComand (IPersonActions goAttack)
        {
            GoAttack = goAttack;
        }
        public void Execute()
        {
            GoAttack.DoAttack();
        }
    }

}
