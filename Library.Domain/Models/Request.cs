using System.Collections.Generic;

namespace Library.Domain.Models
{
    public class Request : BaseModel
    {
        public Request()
        {
            Register = new Register();
        }

        public Request(Register register)
        {
            Register = register;
        }

        public List<ItemRequest> Itens { get; private set; } = new List<ItemRequest>();
        public virtual Register Register { get; private set; }
    }
}