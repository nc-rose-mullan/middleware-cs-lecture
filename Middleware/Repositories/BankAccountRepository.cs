using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Middleware;

namespace Middleware.Models
{
    public interface IBankAccountRepository
    {
        public IEnumerable<BankAccount> FindAllAccounts();
        public BankAccount FindAccountById(int id);
    }
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly TerribleBankDatabaseContext _dbContext;
        public BankAccountRepository(TerribleBankDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<BankAccount> FindAllAccounts()
        {
            if (!Utils.IsLucky()) throw new Exception("Database is down :(");
            var bankAccounts = _dbContext.BankAccounts.ToList();
            return bankAccounts;
        }
        public BankAccount FindAccountById(int id)
        {   
            if (!Utils.IsLucky()) throw new Exception("Database is down :(");
            var bankAccount = _dbContext.BankAccounts.FirstOrDefault(b => b.Id == id);
            return bankAccount;
        }
    }
}
