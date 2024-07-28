using Registration.Models;
using RegistrationSystem.Dto;

namespace Registration.Services
{
    public interface IAuthService
    {
        public Task<AuthenModel> TokenAync(DtoLogin dtoLogin);
    }
}
