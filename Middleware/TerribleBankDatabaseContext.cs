using Microsoft.EntityFrameworkCore;

namespace Middleware
{
    public class TerribleBankDatabaseContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public TerribleBankDatabaseContext(DbContextOptions<TerribleBankDatabaseContext> options)
        : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().HasData(
                new BankAccount() { Id = 1, Name= "Rose", Balance = -1000, AccountNumber = 10101010, SortCode = 101010},
                new BankAccount() { Id = 2, Name = "Chris", Balance = 8000000, AccountNumber = 64872091, SortCode = 100002 },
                new BankAccount() { Id = 3, Name = "Lewis", Balance = 500, AccountNumber = 44444444, SortCode = 130002 },
                new BankAccount() { Id = 4, Name = "Jim", Balance = 100, AccountNumber = 11112222, SortCode = 404040 },
                new BankAccount() { Id = 5, Name = "David", Balance = 50000, AccountNumber = 33334444, SortCode = 989898 },
                new BankAccount() { Id = 6, Name = "Tufty", Balance = 9000, AccountNumber = 23232323, SortCode = 134761 },
                new BankAccount() { Id = 7, Name = "Ginger Cheeks", Balance = 50000, AccountNumber = 19876543, SortCode = 225588 }
            );
        }
    }
}
