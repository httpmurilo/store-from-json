using System.Collections.Generic;
using Library.Domain.Models;

namespace Library.Domain.Repository
{
    public interface IProductRepository
    {
        void SaveProducts(List<Book> books);
        IList<Product> GetProducts();
    }
}