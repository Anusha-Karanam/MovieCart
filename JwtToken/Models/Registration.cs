﻿namespace JwtToken.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }   
        public int Isactive { get; set; }
    }
}
