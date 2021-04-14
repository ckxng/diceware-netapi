using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diceware_netapi.Service
{
    public class WordLookupService : IWordLookupService
    {
        static WordLookupService _instance;

        public static WordLookupService Instance
        {
            get { return _instance ??= new WordLookupService(); }
        }

        private WordLookupService()
        {

        }

        public string WordFromDiceRoll(int dice)
        {
            return "word";
        }
    }
}
