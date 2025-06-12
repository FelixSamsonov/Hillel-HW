using InternetShop.WebApi.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;


namespace InternetShop.WebApi.Servise.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetUserOrdersAsync(int id);

        Task<Order> CreateOrderAsync(Order order);
        Task<Order?> UpdateOrderAsync(int id, Order order);
        Task<bool> DeleteOrderAsync(int id);
        Task<Order?> PatchOrderAsync(int id, JsonPatchDocument<Order> patchDoc);
    }
}
