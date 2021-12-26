using BezaoWallet.Entities.Dtos;
using System.Threading.Tasks;

namespace BezaoWallet.Api.Authentication
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
