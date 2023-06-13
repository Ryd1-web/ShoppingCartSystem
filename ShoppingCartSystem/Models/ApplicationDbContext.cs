using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ShoppingCartSystem.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
		{ 

		}

		public DbSet<CartItem> CartItems { get; set; }
	}
}
