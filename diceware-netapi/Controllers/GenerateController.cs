using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diceware_netapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenerateController : ControllerBase
    {

        private readonly ILogger<GenerateController> _logger;

        public GenerateController(ILogger<GenerateController> logger)
        {
            _logger = logger;
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
            return new Wordlist().Password(words, sep);
        }
    }
}
