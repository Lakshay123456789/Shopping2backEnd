using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ShoppingCartBLL.AccountServices;
using ShoppingCartModels.EntityModels;
using ShoppingCartModels.ModelDto;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAccountClass _accountClass;

        public AuthenticateController(IAccountClass accountClass)
        {
           _accountClass= accountClass;
        }

        [HttpPost("login")]
        //[Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
           var result=  await _accountClass.LoginMethod(model);
            if (result.Status==true)
            {
                return Ok(result);
            }
            return Unauthorized();
        }
        [HttpPost("SignUp")]
        //[Route("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel model)
        {
            var result = await _accountClass.SignUpMethod(model);
            if (result.Status == true)
            {
                return Ok(result);
            }
            return BadRequest();
        }

    }
}
