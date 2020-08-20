using Library.Domain.Models;
using Library.Domain.Repository;
using Library.Infra.Context;

namespace Library.Infra.Repository
{
    public class RegisterRepository : BaseRepository<Register>, IRegisterRepository
    {
        public RegisterRepository(StoreContext context) : base(context)
        {
        }
    }
}