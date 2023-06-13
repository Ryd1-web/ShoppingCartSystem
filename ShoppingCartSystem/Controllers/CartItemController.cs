using Microsoft.AspNetCore.Mvc;
using ShoppingCartSystem.Models;

namespace ShoppingCartSystem.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CartItemController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly CartService _cartService;

		public CartItemController(ApplicationDbContext context, CartService cartService)
		{
			_context = context;
			_cartService = cartService;
		}

		[HttpGet("id")]
		//[Route("[api/cart/{id}]")]
		public IActionResult GetItems(int id) 
		{
			var cart = new Cart
			{
				Items = _context.CartItems.ToList(),
				TotalPrice = _cartService.GetTotalPrice(_context.CartItems)
			};
			return Ok(cart);
		}

		[HttpPost]
		//[Route("[/api/cart]")]
		public IActionResult AddCartItems([FromBody] List<CartItem> cartItems)
		{
			foreach(var item in cartItems)
			{
				item.price = _cartService.GetTotalPrice(new List<CartItem> { item });
				
			}
			_context.AddRange(cartItems);
			_context.SaveChanges();

			return Ok();
		}

	}
}
