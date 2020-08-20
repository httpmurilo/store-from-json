using Library.Domain.Models;
using Library.Domain.Repository;
using Library.Infra.Context;

namespace Library.Infra.Repository
{
    public class RequestRepository : BaseRepository<Request>, IRequestRepository
    {
        public RequestRepository(StoreContext context) : base(context)
        {
            
        }
        public void AddItem(string code)
        {
            
        }

        public Request GetRedquest()
        {
            throw new System.NotImplementedException();
        }
    }
}