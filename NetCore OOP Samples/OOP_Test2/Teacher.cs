namespace OOP_Test2
{
    public class Teacher : Insan
    {
        public string Course { get; set; }

        public Teacher(int id,string name,int age,string c) : base(id,name,age)
        {
            this.Course=c;
        }

        public override void Intro(){
            System.Console.WriteLine($"Id: {this.Id}, Name: {this.Name} , Age : {this.Age} , Lecture: {this.Course}");
        }
    }
    
}