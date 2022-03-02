// See https://aka.ms/new-console-template for more information


Mediator mediator = new Mediator();
Teacher burak = new Teacher(mediator);
Student ibrahim = new Student(mediator);
Student unal = new Student(mediator);
Student ahmet = new Student(mediator);

burak.Name = "Burak";
mediator.Teacher = burak;

mediator.Students = new List<Student>();
ibrahim.Name = "ibrahim";
mediator.Students.Add(ibrahim);
unal.Name = "unal";
mediator.Students.Add(unal);
ahmet.Name = "ahmet";
mediator.Students.Add (ahmet);

burak.ShowPresentation("slide 1");
Console.WriteLine("-----------------------------------------");

burak.GetQuestion("How are you?", ibrahim);


Console.ReadLine();








abstract class CourseMember
{
    protected Mediator Mediator; // protected props have to use Pascal case...

    public CourseMember(Mediator mediator)
    {
        Mediator = mediator;
    }
}

class Teacher : CourseMember
{
    public string Name { get; set; }

    public Teacher(Mediator mediator) : base(mediator)
    {

    }

    public void GetQuestion(string question, Student student)
    {
        Console.WriteLine($" '{student}' asked this '{question}' to teacher  and teach got question...Teacher...");
    }


    public void ShowPresentation(string url)
    {
        Console.WriteLine($"Teacher showed slide {url} ");
        Mediator.UpdateImage(url);
    }

    public void AnswerQuestion(string answer, Student student)
    {
        Console.WriteLine($"Teacher's answer is {answer} to student: {student} ");
    }

}

class Student : CourseMember
{
    public string Name { get; set; }

    public Student(Mediator mediator) : base(mediator)
    {

    }

    public void GetImage(string url)
    {
        Console.WriteLine($"Students received the image {url}");
    }

    public void GetAnswer(string answer)
    {
        Console.WriteLine($"Student got the answer {answer}");
    }


}

class Mediator
{
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }

    public void UpdateImage(string url)
    {
        foreach (var student in Students)
        {
            student.GetImage(url);
        }
    }

    public void AskQuestion(string question, Student student)
    {
        Teacher.GetQuestion(question, student);
    }

    public void Question(string answer, Student student)
    {
        student.GetAnswer(answer);
    }

}

