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