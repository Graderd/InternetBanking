using InternetBanking.core.Interfaces;
using InternetBanking.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetBanking.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : Controller 
    {
        private readonly IAccountsService _accountsService;
        public AccountsController(IAccountsService accountsService) 
        {
            _accountsService = accountsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Accounts>>> GetAcountsAsync()
        {
            try
            {
                List<Accounts> accounts = await _accountsService.GetAccountsAsync();
                return Ok(accounts);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddAccountsAsync([FromBody] Accounts accounts)
        {
            try
            {
                bool isadd = await _accountsService.AddAccountsAsync(accounts);
                if (isadd) return Ok(accounts);

                return BadRequest();
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
