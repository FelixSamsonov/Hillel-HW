using InternetShop.WebApi.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace InternetShop.WebApi.Servise.Interfaces
{
    public interface ICartItemService
    {
        Task<IEnumerable<CartItem>> GetAllCartItemsAsync(int userId);    
        Task<CartItem?> GetCartItemByIdAsync(int id);                     
        Task<CartItem> AddCartItemAsync(CartItem cartItem);              
        Task<CartItem?> UpdateCartItemAsync(int id, CartItem cartItem);  
        Task<bool> DeleteCartItemAsync(int id);                          
        Task<CartItem?> PatchCartItemAsync(int id, JsonPatchDocument<CartItem> patchDoc);  
    }
}
