using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diceware_netapi.Service
{
    public class DiceRollerService : IDiceRollerService
    {
        static DiceRollerService _instance;

        private Random rand;

        public static DiceRollerService Instance
        {
            get { return _instance ??= new DiceRollerService(); }
        }

        private DiceRollerService()
        {
            rand = new Random();
        }

        public int Single()
        {
            return rand.Next(1, 6);
        }

        public int FullSet()
        {
            int rolls = 0;
            for(int i = 1; i <= 10000; i*=10)
            {
                rolls += Single() * i;
            }
            return rolls;

        }
    }
}
