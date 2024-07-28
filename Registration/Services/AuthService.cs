using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Registration.Data;
using Registration.Dto;
using Registration.Models;
using RegistrationSystem.Dto;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using Registration.Migrations;
namespace Registration.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly JWT _jwt;
        private readonly AppDbContext dbcontext;
        public AuthService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<JWT> jwt, AppDbContext dbcontext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            this.dbcontext = dbcontext;
            _jwt = jwt.Value;
        }

        public async Task<AuthenModel> TokenAync(DtoLogin Model)
        {
            var AuthModel = new AuthenModel();

            var user = await _userManager.FindByIdAsync(Model.Id);
           
            if (user == null)
            {
                AuthModel.Message = "Id or Password Incorrect";

                return AuthModel;
            }
            var jwtsecuritytoken = await CreateJwtToken(user);

            var RoleList = await _userManager.GetRolesAsync(user);

            AuthModel.IsAuthenticated = true;
            AuthModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtsecuritytoken);
            AuthModel.Email = user.Email;
           
            AuthModel.Username = user.UserName;
          //  AuthModel.Expireon = jwtsecuritytoken.ValidTo;
            AuthModel.Roles = RoleList.ToList();

        
          
            return AuthModel;
        }
    private RefreshToken GenerateRefreshToken()
        {

            var randomNumber = new Byte[32];
            using var generator = new RNGCryptoServiceProvider();

            generator.GetBytes(randomNumber);

            return new RefreshToken
            {
                Token = Convert.ToBase64String(randomNumber),
                ExpireOn = DateTime.UtcNow.AddDays(10),
                CreateOn = DateTime.UtcNow
            };
        }
            
            
            
            
            private async Task<JwtSecurityToken> CreateJwtToken(IdentityUser user)
    {
        var userClaims = await _userManager.GetClaimsAsync(user );
        var roles = await _userManager.GetRolesAsync(user);
        var roleClaims = new List<Claim>();

        foreach (var role in roles)
            roleClaims.Add(new Claim("roles", role));

        var claims = new[]
        {
                new Claim(JwtRegisteredClaimNames.NameId, user.Id),
           
            }
        .Union(userClaims)
        .Union(roleClaims);

        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.key));
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        var jwtSecurityToken = new JwtSecurityToken(
            issuer: _jwt.Issuer,
            audience: _jwt.Audience,
            claims: claims,
            expires: DateTime.Now.AddDays(_jwt.DurationInDays),
            signingCredentials: signingCredentials);



        return jwtSecurityToken;


    }
}
}
