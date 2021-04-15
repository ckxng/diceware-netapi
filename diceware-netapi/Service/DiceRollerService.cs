using System;

namespace diceware_netapi.Service
{
    public class DiceRollerService : IDiceRollerService
    {
        private Random rand;

        public DiceRollerService()
        {
            rand = new Random();
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