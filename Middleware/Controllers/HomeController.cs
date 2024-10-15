using Microsoft.AspNetCore.Mvc;
using Middleware.Services;

namespace Middleware.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBankAccountService _bankAccountService;
        public HomeController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }
        [HttpGet("/accounts")]
        public IActionResult Index()
        {
            var allAccounts = _bankAccountService.FindAllAccounts();
            return Ok(allAccounts);
        }
        [HttpGet("/accounts/{id}")]
        public IActionResult GetAccountById(int id)
        {
            var account = _bankAccountService.FindAccountById(id);
            return Ok(account);
        }
    }
}
