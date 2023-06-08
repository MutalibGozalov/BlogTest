namespace RNET102.UI.Models
{
	public class Category
	{
		public Category()
		{
			Products = new HashSet<Product>();
		}

		public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}