using System.Collections.Generic;
using System.Linq;
using Library.Domain.Models;
using Library.Domain.Repository;
using Library.Infra.Context;

namespace Library.Infra.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StoreContext context) : base(context)
        {
            
        }
        public IList<Product> GetProducts()
        {
            return dbSet.ToList();
        }

        public void SaveProducts(List<Book> books)
        {
            foreach (var book in books)
            {
             if (!dbSet.Where(p => p.Code == book.Code).Any())
                {
                    dbSet.Add(new Product(book.Code, book.Name, book.Price));
                }
            }

            _context.SaveChanges();
        }
    }
}