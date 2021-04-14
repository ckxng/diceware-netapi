using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diceware_netapi.Service
{
    interface IWordLookupService
    {
        string WordFromDiceRoll(int dice);

    }
}
