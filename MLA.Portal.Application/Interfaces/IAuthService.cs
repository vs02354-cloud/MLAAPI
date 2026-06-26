using MLA.Portal.Application.DTOs;

namespace MLA.Portal.Application.Interfaces;

public interface IAuthService
{
    Task<AuthResponse?> LoginAsync(LoginRequest request);
}
