using MagicVlla_VillaAPI.Data;
using MagicVlla_VillaAPI.Models;
using MagicVlla_VillaAPI.Models.Dto;
using MagicVlla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MagicVlla_VillaAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _db;
        private string secretKey;
        //first create a constructor 
        public UserRepository(ApplicationDBContext db,IConfiguration configuration) 
        {

            _db = db;
            secretKey = configuration.GetValue<string>("ApiSettings:Secret");
        }

        public bool IsUniqueUser(string username)
        {
            var user = _db.LocalUsers.Any(x=>x.userName== username);
            if (user == false)
            {
                return true;
            }
            return false;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDto)
        {
            // Await the result of FirstOrDefaultAsync to get the actual user
            var user = await _db.LocalUsers.FirstOrDefaultAsync(u => u.userName.ToLower() == loginRequestDto.userName.ToLower() &&
                                                                     u.password == loginRequestDto.password);
            if (user == null)
            {
                return new LoginResponseDTO()
                {
                    Token = "",
                    User = null
                };
            }


            // JWT token for secure login
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.Name, user.Id.ToString()),
                }),
                Expires = DateTime.UtcNow.AddDays(10),
                //SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            LoginResponseDTO loginResponseDTO = new LoginResponseDTO()
            {
                Token = tokenHandler.WriteToken(token),
                User = user
            };

            return loginResponseDTO;
        }

        public async  Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDto)
        {
            LocalUser user = new LocalUser()
            {
                userName= registrationRequestDto.userName,
                password= registrationRequestDto.password,
                Name=registrationRequestDto.Name,
                Role=registrationRequestDto.Role

            };
            _db.LocalUsers.Add(user);
           await _db.SaveChangesAsync();
            user.password = "";
            return user;

        }

       
    }
}
