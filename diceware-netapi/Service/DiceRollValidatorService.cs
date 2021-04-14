using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diceware_netapi.Service
{
    public class DiceRollValidatorService : IDiceRollValidatorService
    {
        static DiceRollValidatorService _instance;

        public static DiceRollValidatorService Instance
        {
            get { return _instance ??= new DiceRollValidatorService(); }
        }

        private DiceRollValidatorService()
        {

        }

        public bool CheckDiceRolls(int dice)
        {
            for (int i = 1; i <= 10000; i *= 10)
            {
                int place = (int)(dice / i) % 10;
                if (place < 1 && place > 6)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
