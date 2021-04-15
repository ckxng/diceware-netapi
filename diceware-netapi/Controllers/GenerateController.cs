using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace diceware_netapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenerateController : ControllerBase
    {
        private readonly Models.WordlistDBContext _context;
        private readonly ILogger<GenerateController> _logger;
        private readonly Service.IDiceRollerService _roller;

        public GenerateController(ILogger<GenerateController> logger,
                                  Models.WordlistDBContext context,
                                  Service.IDiceRollerService diceRollerService)
        {
            _logger = logger;
            _context = context;
            _roller = diceRollerService;
        }

        /// <summary>
        /// Return a new passphrase as a string
        /// </summary>
        /// <param name="words">how many words to include in the passphrase</param>
        /// <param name="sep">the characters to place between words</param>
        /// <returns>a passphrase</returns>
        [HttpGet]
        public string Get(int words = 8, string sep = "-")
        {
            string passphrase = "";
            for (int i = 0; i < words; i++)
            {
                if (i != 0)
                {
                    passphrase += sep;
                }

                int roll = _roller.FullSet();
                if (!_roller.CheckDiceRolls(roll))
                {
                    throw new Exception("Invalid dice sequence, must be 11111-66666");
                }

                Models.Wordlist result = _context.Wordlist.Find(roll);
                if (result == null)
                {
                    throw new KeyNotFoundException("Dice entry missing from database");
                }
                passphrase += result.Word;
            }
            return passphrase;
        }
    }
}