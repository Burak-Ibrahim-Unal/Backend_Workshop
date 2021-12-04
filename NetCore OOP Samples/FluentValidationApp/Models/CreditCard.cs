namespace FluentValidationApp.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
