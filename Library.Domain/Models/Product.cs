namespace Library.Domain.Models
{
    public class Product : BaseModel
    {
        public Product() {}

        public Product(string code, string name, decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public string Code { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
}