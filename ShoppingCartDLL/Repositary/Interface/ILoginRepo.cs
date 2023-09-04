using ShoppingCartModels.ModelDto;
using ShoppingCartModels.ResponseModel;

namespace ShoppingCartDLL.Repositary.Interface
{
    public interface ILoginRepo
    {
        Task<LoginResponse> LoginUser(LoginModel model);
        Task<SignUpResponse> SignUpUser(SignUpModel model);
    }
}