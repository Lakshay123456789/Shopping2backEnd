using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ShoppingCartDLL.Repositary.Interface;
using ShoppingCartModels.EntityModels;
using ShoppingCartModels.ModelDto;
using ShoppingCartModels.ResponseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDLL.Repositary
{
    public class LoginRepo : ILoginRepo
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public LoginRepo(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        public async Task<LoginResponse> LoginUser(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return new LoginResponse
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Status = true,
                    Role = userRoles[0].ToString(),
                    UserName = model.UserName
                };


            }
            return new LoginResponse
            {
                Status = false,

            };

        }

        public async Task<SignUpResponse> SignUpUser(SignUpModel model)
        {
            var userExist = await _userManager.FindByEmailAsync(model.UserName);
            if (userExist != null)
            {
                // return StatusCode(statusCode.Status403Forbidden, new Response { Status="Error",Message= "User already Exist" }) return NotFound(new Response { Status = "Error", Message = "User already Exist" });
                return new SignUpResponse { Status = false, Message = "User already Exist" };

            }
            //add user into DB
            var user = new User
            {
                UserName = model.UserName,
                FirstName = model.FirstName, LastName = model.LastName,
                Email = model.EmailId
            };
           
                var result = await _userManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    return new SignUpResponse { Status = false, Message = "User Failed to Create" };
            }
            return new SignUpResponse { Status = true, Message = "Inserted succesfully!!" };

        }
    }
}
