using Microsoft.EntityFrameworkCore;
using RNET102.UI.Models;

namespace RNET102.UI.Data
{
	public class RNET102DbContext : DbContext
	{
		public RNET102DbContext(DbContextOptions<RNET102DbContext> options) : base(options)
		{

		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Blog> Blogs { get; set; }
	}
}

