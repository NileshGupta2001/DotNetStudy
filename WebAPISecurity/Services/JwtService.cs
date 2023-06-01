using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPISecurity.Model;

namespace WebAPISecurity.Services
{
    public class JwtService
    {
        private const int EXPIRATION_MINUTES = 1;
        private readonly IConfiguration _configuration;
        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AuthenticationResponse CreateToken(IdentityUser user)
        {
            var expiration = DateTime.UtcNow.AddMinutes(EXPIRATION_MINUTES);
            var token = CreateJwtToken(
                CreateClaims(user),
                CreateSigningCredentials(),
                expiration
            );
            var tokenHandler = new JwtSecurityTokenHandler();

            return new AuthenticationResponse
            {
                Token = tokenHandler.WriteToken(token),
                Expiration = expiration
            };

        }

        private SigningCredentials CreateSigningCredentials()
        {
            return new SigningCredentials(
                new SymmetricSecurityKey(
                    //Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])
                    Encoding.UTF8.GetBytes("this is the secret key for the jwt, it must be kept secure")

                ),
                SecurityAlgorithms.HmacSha256
            );
        }

        private JwtSecurityToken CreateJwtToken(Claim[] claims, SigningCredentials credentials, DateTime expiration)
        {

            return new JwtSecurityToken(
                //_configuration["Jwt:Issuer"],
                "WebAPISecurity.endpointdev.com",
                //_configuration["Jwt:Audience"],
                "WebAPISecurity.endpointdev.com",
                claims,
                expires: expiration,
                signingCredentials: credentials
                );
        }


        //a claim is essentially a statement about the entity for which the token is generated,
        //some data that identifies it
        private Claim[] CreateClaims(IdentityUser user) 
        {
          return  new[] {
                //new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                new Claim(JwtRegisteredClaimNames.Sub, "JWT for WebAPISecurity.endpointdev.com"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
            };
        }
    }
}
