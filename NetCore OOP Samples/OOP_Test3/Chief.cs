namespace OOP_Test3
{
    public class Chief : IPersonnel,IHuman
    {
        public string Name { get; set ; }
        public string Address { get; set ; }        
        public int Age { get; set ; }
        public string Department { get; set ; }
        public int Salary { get; set; }

        public Chief(string name,string address,int age,string department,int salary)
        {
            this.Name=name;this.Address=address;this.Age=age;this.Department=department;this.Salary=salary;
        }
        public void Info()
        {
           System.Console.WriteLine($"{this.Name} named personal address is {this.Address} and department {this.Department} and age {this.Age} and salary:2500$");        }
    }
}