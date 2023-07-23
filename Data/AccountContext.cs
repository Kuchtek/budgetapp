using Microsoft.EntityFrameworkCore;

namespace budgetapp.Data
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options)
            {

            }
        public DbSet<budgetapp.Models.Account>? Accounts { get; set; }
    }
}