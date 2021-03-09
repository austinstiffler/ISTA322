namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Category { get; set; } = "Watersports";
        public Product Related { get; set; }
        public bool InStock { get; } = true;
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Boat",
                Price = 275M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            Product laptop = new Product
            {
                Name = "Laptop"
            };
            kayak.Related = lifejacket;
            return new Product[] { kayak, lifejacket, laptop, null };
        }
    }
}