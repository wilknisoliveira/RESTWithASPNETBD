namespace RESTWithASPNETBD.Data.VO
{
    //This class will generate the response JSON with token
    public class TokenVO
    {
        public bool Authenticated { get; set; }
        public string Created { get; set; } 
        public string Expiration { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public TokenVO(bool authenticated, string created, string expiration, string accessToken, string refreshToken)
        {
            Authenticated = authenticated;
            Created = created;
            Expiration = expiration;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
    }
}
