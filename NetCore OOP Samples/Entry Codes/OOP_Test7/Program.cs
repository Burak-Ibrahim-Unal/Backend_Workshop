using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            gamerManager1.Add(new Gamer
            {
                Id = 1,
                Name = "Burak",
                Surname = "Unal",
                IdentityNo = "12345",
                BirthYear=1947
            });


            Console.WriteLine("------------------------------------");
            Console.WriteLine("Updated new validation service...");

            GamerManager gamerManager2 = new GamerManager(new UpdatedUserValidationManager());
            gamerManager2.Add(new Gamer
            {
                Id = 1,
                Name = "Burak",
                Surname = "Unal",
                IdentityNo = "12345",
                BirthYear = 1947
            });

        }
    }
}
