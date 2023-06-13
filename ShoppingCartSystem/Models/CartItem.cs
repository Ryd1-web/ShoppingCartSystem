namespace ShoppingCartSystem.Models
{
	public class CartItem
	{
		public int Id { get; set; }
		public int productId { get; set; }
		public int quantity { get; set; }
		public decimal price { get; set; }
	}
}
//productId (int), quantity (int), and price (decimal).