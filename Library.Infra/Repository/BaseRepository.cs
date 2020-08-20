using Library.Domain.Models;
using Library.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Infra.Repository
{
    public abstract class BaseRepository<T> where T: BaseModel
    {
        protected  readonly DbSet<T> dbSet;
        protected readonly StoreContext _context;

        public BaseRepository(StoreContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
    }
}