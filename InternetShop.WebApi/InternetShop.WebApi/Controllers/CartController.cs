using InternetShop.WebApi.Data.Entities;
using InternetShop.WebApi.Services;
using InternetShop.WebApi.Servise.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace InternetShop.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;

        public CartController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int userId)
        {
            var cartItems = await _cartItemService.GetAllCartItemsAsync(userId);
            return Ok(cartItems);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cartItem = await _cartItemService.GetCartItemByIdAsync(id);
            return cartItem != null ? Ok(cartItem) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CartItem cartItem)
        {
            var createdCartItem = await _cartItemService.AddCartItemAsync(cartItem);
            return CreatedAtAction(nameof(GetById), new { id = createdCartItem.Id }, createdCartItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CartItem cartItem)
        {
            var updatedCartItem = await _cartItemService.UpdateCartItemAsync(id, cartItem);
            return updatedCartItem != null ? Ok(updatedCartItem) : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _cartItemService.DeleteCartItemAsync(id);
            return result ? NoContent() : NotFound();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] JsonPatchDocument<CartItem> patchDoc)
        {
            var updatedCartItem = await _cartItemService.PatchCartItemAsync(id, patchDoc);
            return updatedCartItem != null ? Ok(updatedCartItem) : NotFound();
        }
    }
}
