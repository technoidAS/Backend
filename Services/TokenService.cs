<<<<<<< HEAD
﻿using Microsoft.IdentityModel.Tokens;
=======
using Microsoft.IdentityModel.Tokens;
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace Backend.Services
{
    public class TokenService
    {
        private readonly string _Secret;
        public TokenService(IConfiguration configuration)
        {
            _Secret = configuration["Jwt:Secret"]
                ?? throw new ArgumentNullException("Jwt:Secret is not configured");
        }

<<<<<<< HEAD
        public string GenerateToken(int UserId, string Email, string UserName, bool isAdmin)
=======
        public string GenerateToken(int UserId, string Email, string UserName)
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("id",UserId.ToString()),
                    new Claim("email",Email),
<<<<<<< HEAD
                    new Claim("userName",UserName),
                    new Claim("isAdmin", isAdmin.ToString())
=======
                    new Claim("userName",UserName)
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
                }),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public int? ValidateToken(string token)
        {
            try
            {
                var tokenhandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_Secret);
                tokenhandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);
                var jwtToken = (JwtSecurityToken)validatedToken;
                var UserStr = jwtToken.Claims.First(x => x.Type == "id").Value;
                if (int.TryParse(UserStr, out int UserId))
                {
                    return UserId;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }


    }
}