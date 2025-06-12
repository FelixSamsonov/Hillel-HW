

using InternetShop.WebApi.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace InternetShop.WebApi.Servise.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(User user);
        Task<User?> UpdateUserAsync(int id, User user);
        Task<bool> DeleteUserAsync(int id);
        Task<User?> GetUserByIdAsync(int id);
        Task<User?> PatchAsync(int id, JsonPatchDocument<User> patchDoc);
    }
}
