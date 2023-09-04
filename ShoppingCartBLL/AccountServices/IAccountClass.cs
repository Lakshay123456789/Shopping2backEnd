using ShoppingCartModels.ModelDto;
using ShoppingCartModels.ResponseModel;

namespace ShoppingCartBLL.AccountServices
{
    public interface IAccountClass
    {
        Task<LoginResponse> LoginMethod(LoginModel login);
        Task<SignUpResponse> SignUpMethod(SignUpModel signUp);
    }
}