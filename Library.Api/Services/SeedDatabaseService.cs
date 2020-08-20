using System.Collections.Generic;
using System.IO;
using Library.Api.Interfaces;
using Library.Domain.Models;
using Library.Domain.Repository;
using Library.Infra.Context;
using Newtonsoft.Json;

namespace Library.Api.Services
{
    class SeedDatabaseService : ISeedDatabaseService
    {
        private readonly StoreContext _context;
        private readonly IProductRepository _productRepository;

        public SeedDatabaseService(StoreContext context, IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }
        public void startDatabase()
        {
            _context.Database.EnsureCreated();
            List<Book> books = GetBooks();
            _productRepository.SaveProducts(books);
        }

        private static List<Book> GetBooks()
        {
            var json = File.ReadAllText("books.json");
            var books = JsonConvert.DeserializeObject<List<Book>>(json);
            return books;
        }


    }

}