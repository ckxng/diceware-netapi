namespace diceware_netapi.Service
{
    public interface IDiceRollerService
    {
        /// <summary>
        /// verify that the integer specified correct represents a sequence of 5 dice rolls
        /// </summary>
        /// <param name="dice">the value to test</param>
        /// <returns>true if the number is between 11111-66666 with all digits between 1-6 inclusive, otherwise false</returns>
        bool CheckDiceRolls(int dice);

        /// <summary>
        /// roll 5 dice, returning an integer value between 11111-66666
        /// </summary>
        /// <returns>an integer between 11111-66666 with all digits between 1-6 inclusive</returns>
        int FullSet();

        /// <summary>
        /// Returns a single dice roll between 1-6 inclusive
        /// </summary>
        /// <returns>a single integer between 1-6 inclusive</returns>
        int Single();
    }
}