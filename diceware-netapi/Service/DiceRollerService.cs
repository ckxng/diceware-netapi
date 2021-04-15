using System;

namespace diceware_netapi.Service
{
    public class DiceRollerService : IDiceRollerService
    {
        private static DiceRollerService _instance;

        private Random rand;

        private DiceRollerService()
        {
            rand = new Random();
        }

        public static DiceRollerService Instance
        {
            get { return _instance ??= new DiceRollerService(); }
        }
        public int FullSet()
        {
            int rolls = 0;
            for (int i = 1; i <= 10000; i *= 10)
            {
                rolls += Single() * i;
            }
            return rolls;
        }

        public int Single()
        {
            return rand.Next(1, 6);
        }
    }
}