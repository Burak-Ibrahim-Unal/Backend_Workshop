namespace FluentValidationApp.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string FullProperty { get; set; }
        public string CreditCardNumber { get; set; }  // class name + property = automapper standart
        //public string CCNumber { get; set; }  // custom name = not automapper standart,it must me add into customerprofile formember
        public DateTime CreditCardValidDate{ get; set; } // class name + property = automapper standart
        //public DateTime CCValidDate { get; set; }  // custom name = not automapper standart,it must me add into customerprofile formember

    }
}
