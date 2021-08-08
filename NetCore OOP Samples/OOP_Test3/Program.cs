using System;

namespace OOP_Test3
{
    class Program
    {
        static void Main(string[] args)
        {

            var personnels = new IPersonnel[4];
            personnels[0] = new Chief("a","a",0,"a",5000);
            personnels[1] = new Worker("b","b",1,"b",1000);
            personnels[2] = new Chief("c","c",2,"c",1250);
            personnels[3] = new Robot("Robo2020","r00",400,"All");

            foreach (IPersonnel personnel in personnels)
            {
                personnel.Info();
            }
        }
    }
}
