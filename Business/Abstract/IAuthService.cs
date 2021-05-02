using Core.Entities.Concrete;
using Core.Entities.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using static Core.Entities.Utilities.Results.IDataResult;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
