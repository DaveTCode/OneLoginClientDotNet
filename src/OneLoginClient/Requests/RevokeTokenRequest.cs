﻿
namespace OneLogin.Requests
{
    /// <summary>
    /// https://developers.onelogin.com/api-docs/1/oauth20-tokens/revoke-tokens
    /// </summary>
    public class RevokeTokenRequest
    {
        public string access_token { get; set; }
    }
}
