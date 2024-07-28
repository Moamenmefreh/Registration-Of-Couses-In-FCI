using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registration.Data;
using Registration.Dto;
using Registration.Models;
using Registration.Services;
using RegistrationSystem.Dto;

namespace Registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthService _authenService;
        private readonly AppDbContext dbContext;
        public LoginController(IAuthService authenService)
        {
            _authenService = authenService;
        }
        [HttpPost("Token")]
        public async Task<IActionResult> GetTokenAsync([FromBody] DtoLogin Model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authenService.TokenAync(Model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);
            
            return Ok(result);
        }
    }
}
