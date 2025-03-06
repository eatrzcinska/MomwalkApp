using API.Entities;

namespace API;

public interface ITokenSerivce
{
    string CreateToken(AppUser appUser);
}