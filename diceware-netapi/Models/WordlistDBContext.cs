using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace diceware_netapi.Models
{
    public class WordlistDBContext : DbContext
    {
        public WordlistDBContext(DbContextOptions<WordlistDBContext> options) : base(options)
        {

        }

        public DbSet<Wordlist> Wordlist { get; set; }

    }
}
