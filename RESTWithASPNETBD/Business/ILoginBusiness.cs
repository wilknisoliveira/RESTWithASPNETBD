using RESTWithASPNETBD.Data.VO;

namespace RESTWithASPNETBD.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);

        TokenVO ValidateCredentials(RefreshTokenVO refreshTokenVO);

        bool RevokeToken(string userName);
    }
}
