using MagicVlla_VillaAPI.Models;
using MagicVlla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Identity.Data;

namespace MagicVlla_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDto);
        Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDto);
    }
}
