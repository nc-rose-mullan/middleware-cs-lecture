using Middleware.Models;

namespace Middleware.Services
{
    public interface IBankAccountService
    {
        public IEnumerable<BankAccount> FindAllAccounts();
        public BankAccount FindAccountById(int id);
    }
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        public BankAccountService(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }
        public IEnumerable<BankAccount> FindAllAccounts()
        {
            return _bankAccountRepository.FindAllAccounts();
        }
        public BankAccount FindAccountById(int id)
        {
            return _bankAccountRepository.FindAccountById(id);
        }
    }
}
