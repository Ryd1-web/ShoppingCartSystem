namespace ShoppingCartSystem.Models
{
	public abstract class CartService
	{
		public abstract decimal GetTotalPrice(IEnumerable<CartItem> cartItems);
	}
}
