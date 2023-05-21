using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWebApp.Model;
using ShoppingCartWebApp.Repository;

namespace ShoppingCartWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _accountRepository;
        public AccountController(IAccount accountRepository)
        {
            this._accountRepository = accountRepository;
        }
        [HttpPost("signup")]
        public IActionResult SignUp(Register model)
        {
            if (ModelState.IsValid)
            {
                var result = _accountRepository.SignUp(model);
                if (result.Result != null)
                {
                    if (result.Result.IsSuccess) { return Ok(); }
                    return NotFound();
                }
            }
            return NotFound();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(Login model)
        {
            var result = await _accountRepository.Login(model);
            if (result != null)
            {
                if (result.IsSuccess) { return Ok(result); }
                return Unauthorized();
            }
            return Unauthorized();
        }
    }
}
