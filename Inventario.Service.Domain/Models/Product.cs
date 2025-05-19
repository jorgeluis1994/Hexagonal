namespace Inventario.Service.Domain.Models
{
    public class Product
    {  
        /// <summary>
        /// Represents a product in the inventory system.
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public string ImageUrl { get; set; } = string.Empty;

        public Product(string name, string description, string category, decimal price, int stock, string imageUrl)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            Stock = stock;
            ImageUrl = imageUrl;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }


        
    }
}