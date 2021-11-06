namespace OOP_Test3
{
    public class Robot : IPersonnel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public Robot(string name, string address, int age, string department)
        {
            this.Name = name; this.Address = address; this.Age = age;this.Department = department;
        }
        public void Info()
        {
            System.Console.WriteLine($"{this.Name} named personal address is {this.Address} and department {this.Department} and age {this.Age}");
        }
    }
}