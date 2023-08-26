using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirtYear = 19855,
                FirstName = "Ali",
                LastName = "Veli",
                IdentityNumber = 12345
            });
            Console.WriteLine("Hello World!");
        }
    }
}
