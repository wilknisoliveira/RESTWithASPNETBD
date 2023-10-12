namespace RESTWithASPNETBD.Data.VO
{
    public class RefreshTokenVO
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public RefreshTokenVO(string accessToken, string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
    }
}
