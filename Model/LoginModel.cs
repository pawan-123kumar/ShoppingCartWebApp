﻿namespace ShoppingCartWebApp.Model
{
    public class LoginModel
    {
        public bool IsSuccess { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
