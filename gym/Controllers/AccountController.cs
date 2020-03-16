using gym.Services;
using Microsoft.AspNetCore.Mvc;

namespace gym.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class AccountController : Controller
    {
        private BalanceService service;
        public AccountController(BalanceService service)
        {
            this.service = service;
        }


        [HttpGet("{id}/balance")]
        public ActionResult<Balance> GetBalance(int id)
        {
            if(service.IsPresent(id))
            {
                return Ok(service.GetBalance(id));
            }
            else
            {
                return NotFound();
            }
        }
        
    }
}