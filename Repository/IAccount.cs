using ShoppingCartWebApp.Model;

namespace ShoppingCartWebApp.Repository
{
    public interface IAccount
    {
        Task<LoginModel> SignUp(Register model);
        Task<LoginModel> Login(Login model);
    }
}
