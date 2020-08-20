namespace Library.Domain.Models
{
    public class ItemRequest : BaseModel
    {
        public ItemRequest(){}

        public ItemRequest(Request request, Product product, int amount, decimal unitPrice)
        {
            Request = request;
            Product = product;
            Amount = amount;
            UnitPrice = unitPrice;
        }

        public Request Request { get; private set; }
        public Product Product { get; private set; }
        public int Amount { get; private set; }
        public decimal UnitPrice { get; private set; }
    }
}