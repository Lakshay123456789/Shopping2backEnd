using ShoppingCartDLL.Repositary.Interface;
using ShoppingCartModels.ModelDto;
using ShoppingCartModels.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartBLL.AccountServices
{
    public class AccountClass : IAccountClass
    {
        private readonly ILoginRepo _loginRepo;
        public AccountClass(ILoginRepo loginRepo)
        {
            _loginRepo = loginRepo;
        }
        public async Task<LoginResponse> LoginMethod(LoginModel login)
        {
            return await _loginRepo.LoginUser(login);
        }

        public async Task<SignUpResponse> SignUpMethod(SignUpModel signUp)
        {
            return await _loginRepo.SignUpUser(signUp);
        }
    }
}
