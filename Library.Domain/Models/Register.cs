namespace Library.Domain.Models
{
    public class Register : BaseModel
    {
        public Register() {}

        public virtual Request Request { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Number { get; set; } = "";
        public string Address { get; set; } = "";
        public string Complement { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
    }
}