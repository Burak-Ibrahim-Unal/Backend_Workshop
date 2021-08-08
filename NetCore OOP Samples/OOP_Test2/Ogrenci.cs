namespace OOP_Test2
{
    public class Ogrenci : Insan
    {   
        public string No { get; set; }
        public string School { get; set; }

        public Ogrenci(int id,string name,int age,string no,string school) : base(id,name,age)
        {
            this.No=no;
            this.School=school;
        }
        public override void Intro(){
            System.Console.WriteLine($"Id: {this.Id} , Name: {this.Name} , Age: {this.Age}, OgrNo: {this.No}, School: {this.School}");
        }
    }
}