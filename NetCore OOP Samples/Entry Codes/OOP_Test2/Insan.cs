namespace OOP_Test2
{
    public abstract class Insan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Insan(int id,string name,int age)
        {
            this.Id=id;
            this.Name=name;
            this.Age=age;
        }
        public abstract void Intro(){};
        /*
        public virtual void Intro(){
            System.Console.WriteLine($"Id: {this.Id}, Name: {this.Name} , Age : {this.Age}");
        }*/
    }
}