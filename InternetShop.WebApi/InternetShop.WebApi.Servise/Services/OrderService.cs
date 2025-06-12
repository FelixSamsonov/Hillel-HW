using InternetShop.WebApi.Data.Entities;
using InternetShop.WebApi.Data.Repository;
using InternetShop.WebApi.Servise.Interfaces;
using Microsoft.AspNetCore.JsonPatch;

namespace InternetShop.WebApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Order>> GetUserOrdersAsync(int userId)
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            return await _orderRepository.AddAsync(order);
        }

        public async Task<Order?> UpdateOrderAsync(int id, Order order)
        {
            return await _orderRepository.UpdateAsync(order);
        }

        public async Task<bool> DeleteOrderAsync(int id)
        {
            return await _orderRepository.DeleteAsync(id);
        }

        public async Task<Order?> PatchOrderAsync(int id, JsonPatchDocument<Order> patchDoc)
        {
            return await _orderRepository.PatchAsync(id, patchDoc);
        }
    }
}
