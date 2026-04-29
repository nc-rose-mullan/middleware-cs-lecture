using Microsoft.AspNetCore.Mvc;
using Middleware.Services;

namespace Middleware.Controllers
{
    [Route("/accounts")]
    public class AccountsController : ControllerBase
    {
        private readonly IBankAccountService _bankAccountService;

        public AccountsController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var allAccounts = _bankAccountService.FindAllAccounts();
            return Ok(allAccounts);
        }

        [HttpGet("{id}")]
        public IActionResult GetAccountById(int id)
        {
            var account = _bankAccountService.FindAccountById(id);
            return Ok(account);
        }
    }
}
