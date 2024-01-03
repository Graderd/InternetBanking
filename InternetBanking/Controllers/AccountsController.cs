using InternetBanking.core.Dtos;
using InternetBanking.core.Interfaces;
using InternetBanking.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetBanking.Controllers
{


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

        [HttpGet("GetById/{id:int}")]
        public async Task<ActionResult<Accounts>> GetByIdAsync(int id)
        {
            try
            {
                Accounts accounts = await _accountsService.GetAccountsByIdAsync(id);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddAccountsAsync([FromBody] AccountsInsertDto accounts)
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
