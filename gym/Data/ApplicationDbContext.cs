using gym;
using Microsoft.EntityFrameworkCore;

namespace context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set;}
        public DbSet<Transaction> Transactions { get; set;}
    }
}