using InternetShop.WebApi.Data.Context;
using InternetShop.WebApi.Data.Entities;
using InternetShop.WebApi.Data.Repository;
using InternetShop.WebApi.Servise.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.WebApi.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _userRepository.AddAsync(user);
            return user;
        }

        public async Task<User?> UpdateUserAsync(int id, User user)
        {
            var existing = await _userRepository.GetByIdAsync(id);
            if (existing is null) return null;

            await _userRepository.UpdateAsync(user);
            return existing;
        }

        public async  Task<bool> DeleteUserAsync(int id)
        {
            var entity = await _userRepository.GetByIdAsync(id);
            if (entity is null) return false;
            return true;
        }
        public async Task<User?> PatchAsync(int id, JsonPatchDocument<User> patchDoc)
        {
            return await _userRepository.PatchAsync(id, patchDoc);
        }

    }
}
