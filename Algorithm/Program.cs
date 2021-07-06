using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> listOfUsers = new()
            {
                new User() { Login = "Wrrchan", Name = "Никита", IsPremium = true },
                new User() { Login = "Flir", Name = "Артём", IsPremium = false },
                new User() { Login = "Mitrmare", Name = "Глеб", IsPremium = true }
            };

            foreach (var user in listOfUsers)
            {
                Console.WriteLine("Привет, {0}!", user.Name);

                if (!user.IsPremium)
                {
                    Advertising.ShowAds();
                }

                Console.WriteLine();
            }
        }
    }
}
