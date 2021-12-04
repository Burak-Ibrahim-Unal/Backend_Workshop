namespace FluentValidationApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public virtual Customer Customer { get; set; } // one to many
    }
}
