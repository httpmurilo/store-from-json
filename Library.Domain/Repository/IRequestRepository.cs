using Library.Domain.Models;

namespace Library.Domain.Repository
{
    public interface IRequestRepository
    {
        Request GetRequest();
        void AddItem(string code);
    }
}