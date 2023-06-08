namespace RNET102.UI.Models
{
	public class Product
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public Category? Category { get; set; } //this will create CategoryId for DataBase
        public int CategoryId { get; set; } //for C#
        public string? ImageURL { get; set; }
        public string? Rating { get; set; }
    }
}
