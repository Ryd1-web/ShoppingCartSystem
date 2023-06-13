namespace ShoppingCartSystem.Models
{
	public class CartImplementation : CartService
	{
		public override decimal GetTotalPrice(IEnumerable<CartItem> cartItems)
		{
			decimal totalPrice = 0;

			foreach (var item in cartItems)
			{
				totalPrice += item.price * item.quantity;
			}
			return totalPrice;
		}
	}
}
