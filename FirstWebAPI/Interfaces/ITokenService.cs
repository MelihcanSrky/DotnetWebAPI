using FirstWebAPI.Models;

namespace FirstWebAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
