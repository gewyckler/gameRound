using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameRound
{
    interface IEnemyActions
    {
        void EnemyAttack();
        void EnemyBlock();
        void EnemyDodge();
        void EnemyHealing();
    }
}
