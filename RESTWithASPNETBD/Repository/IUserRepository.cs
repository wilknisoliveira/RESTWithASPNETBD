using RESTWithASPNETBD.Data.VO;
using RESTWithASPNETBD.Models;

namespace RESTWithASPNETBD.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);
    }
}
