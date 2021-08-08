using System;

namespace OOP_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insan i1= new Insan(2,"bdadsa",12);
            Ogrenci o1 = new Ogrenci(3,"a",4,"b","c1923");
            Teacher  t1 = new Teacher(1,"teach",123,"Math");
            //i1.Intro();
            o1.Intro();
            t1.Intro();
        }
    }
}
