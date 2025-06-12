using InternetShop.WebApi.Data.Entities;
using InternetShop.WebApi.Data.Repository;
using InternetShop.WebApi.Servise.Interfaces;
using Microsoft.AspNetCore.JsonPatch;

namespace InternetShop.WebApi.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly IRepository<CartItem> _cartItemRepository;

        public CartItemService(IRepository<CartItem> cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<IEnumerable<CartItem>> GetAllCartItemsAsync(int userId)
        {
            return await _cartItemRepository.GetAllAsync();
        }

        public async Task<CartItem?> GetCartItemByIdAsync(int id)
        {
            return await _cartItemRepository.GetByIdAsync(id);
        }

        public async Task<CartItem> AddCartItemAsync(CartItem cartItem)
        {
            return await _cartItemRepository.AddAsync(cartItem);
        }

        public async Task<CartItem?> UpdateCartItemAsync(int id, CartItem cartItem)
        {
            var existingCartItem = await _cartItemRepository.GetByIdAsync(id);
            if (existingCartItem is null) return null;

            existingCartItem.Quantity = cartItem.Quantity;
            existingCartItem.ProductId = cartItem.ProductId;  
            await _cartItemRepository.UpdateAsync(existingCartItem);
            return existingCartItem;
        }

        public async Task<bool> DeleteCartItemAsync(int id)
        {
            return await _cartItemRepository.DeleteAsync(id);
        }

        public async Task<CartItem?> PatchCartItemAsync(int id, JsonPatchDocument<CartItem> patchDoc)
        {
            return await _cartItemRepository.PatchAsync(id, patchDoc);
        }
    }
}
