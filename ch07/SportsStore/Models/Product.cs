namespace SportsStore.Models
{
    public class Product
    {
        public Product ( int id, string name, string description, string category, decimal price )
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}