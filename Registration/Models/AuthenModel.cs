﻿namespace Registration.Models
{
    public class AuthenModel
    {
       
            public string Message { get; set; }
            public bool IsAuthenticated { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public List<string> Roles { get; set; }
            public string Token { get; set; }
        //  public DateTime Expireon { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }

    }
}
