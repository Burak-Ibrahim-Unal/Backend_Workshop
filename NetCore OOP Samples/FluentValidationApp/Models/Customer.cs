namespace FluentValidationApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
        public DateTime? Birthday { get; set; }
        public IList<Address> Addresses { get; set; } // one to many
        public Gender Gender { get; set; }
        public CreditCard CreditCard { get; set; }


        public string GetFullProperty(){ //automap naming standart...it must have Get at begining
            return $"{Name}-{Mail}-{Age}";
        }

        public string TestFullProperyMethod()
        {
            return $"{Name}-{Mail}-{Age} from TestMethod";

        }
    }
}
