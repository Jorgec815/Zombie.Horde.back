
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ZombieHorde.Core.Helpers
{
    public static class JwtHelper
    {
        private static IConfiguration _configuration;

        public static void Configure(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
        public static string GenerateToken(string email, string role)
        {
            var key = _configuration.GetSection("JwtAuth:Key").Value;
            var audicence = _configuration.GetSection("JwtAuth:Audience").Value;
            var issuer = _configuration.GetSection("JwtAuth:Issuer").Value;
            // Define the security key
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            // Create the signing credentials
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Define the claims
            var claims = new[]
            {
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Role, role)    
            };

            // Create the token
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audicence,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: signingCredentials
            );

            // Generate the token string
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenString;
        }
    }
}
