using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diceware_netapi
{
    public class Wordlist
    {
        /// <summary>
        /// Returns a single word with a specified dice sequence from the diceware list
        /// </summary>
        /// <param name="dice">a number between 11111 and 66666 where each digit is in the range 1-6</param>
        /// <returns>a word from the diceware list</returns>
        /// <exception cref="KeyNotFoundException">when invalid dice are provided</exception>
        public string Word(int dice)
        {
            if(! Service.DiceRollValidatorService.Instance.CheckDiceRolls(dice))
            {
                throw new KeyNotFoundException("Invalid dice sequence, must be 11111-66666");
            }
            return "word";
        }

        /// <summary>
        /// Returns num random words from the diceware list
        /// </summary>
        /// <param name="num">the number of words to return</param>
        /// <returns>enumerable list of strings from the wordlist</returns>
        public IEnumerable<string> Words(int num)
        {
            for(int i = 0; i < num; i++)
            {
                yield return Word(Service.DiceRoller.Instance.FullSet());
            }
        }

        /// <summary>
        /// generate a passphrase with num words
        /// </summary>
        /// <param name="words">the number of words in the passphrase</param>
        /// <param name="sep">the string to place between words</param>
        /// <returns>a passphrase with num words</returns>
        public string Password(int words, string sep)
        {
            return String.Join(sep, Words(words));
        }
    }
}
