using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diceware_netapi
{
    public class Wordlist
    {
        /// <summary>
        /// Returns a single random word from the diceware list
        /// </summary>
        public string Word
        {
            get { return "word"; }
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
                yield return this.Word;
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
