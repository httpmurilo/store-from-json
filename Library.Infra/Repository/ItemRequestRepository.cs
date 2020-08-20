using Library.Domain.Models;
using Library.Domain.Repository;
using Library.Infra.Context;

namespace Library.Infra.Repository
{
    public class ItemRequestRepository : BaseRepository<ItemRequest>, IItemRequestRepository
    {
        public ItemRequestRepository(StoreContext context) : base(context)
        {
            
        }
    }
}
    