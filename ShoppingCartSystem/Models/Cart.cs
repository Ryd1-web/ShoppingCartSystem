namespace ShoppingCartSystem.Models
{
	public class Cart
	{
		public List<CartItem> Items { get; set; }
		public decimal TotalPrice { get; set; }
	}
}
