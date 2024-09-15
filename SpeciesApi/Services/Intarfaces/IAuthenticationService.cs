using SpeciesApi.Models;

namespace SpeciesApi.Services.Interfaces
{
    public interface IAuthenticationService
    {
        string GenerateJwtToken(string username);
        bool ValidateUserCredentials(User login);
    }
}
