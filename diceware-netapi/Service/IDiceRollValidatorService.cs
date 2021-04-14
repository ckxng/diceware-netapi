using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diceware_netapi.Service
{
    interface IDiceRollValidatorService
    {
        bool CheckDiceRolls(int dice);
    }
}
