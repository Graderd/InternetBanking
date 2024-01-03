using InternetBanking.core.Dtos.Customers;
using InternetBanking.core.Interfaces;
using InternetBanking.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetBanking.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomersService _customersService;

        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customers>>> GetCustomersAsync()
        {
            try
            {
                List<Customers> customers = await _customersService.GetCustomersAsync();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        public async Task<ActionResult<bool>> AddCustomerAsync([FromBody] CustomersInsertDto customers)
        {
            try
            {
                bool isAdded = await _customersService.AddCustomersAsync(customers);
                if (isAdded) return Ok(customers);

                return BadRequest();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
