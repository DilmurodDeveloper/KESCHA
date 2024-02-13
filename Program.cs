﻿using KESCHA.Classes;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            Animal Kescha = new Bird(name: "Kescha", age: 5);
            Animal Kasee = new Pet(name: "Kasee", age: 3);

            Console.Write("Ismingzni kiriting: ");
            string userName = Console.ReadLine();
            Kescha.Greet(userName);
            Kasee.Greet(userName);

            Console.Write("Yoshingizni kiriting: ");
            string ageAsString = Console.ReadLine();

            Console.WriteLine("Konvertatsiya qilinmoqda...");
            int userAge =  Convert.ToInt32(ageAsString);
            Console.WriteLine($"Muvaffaqiyatli konvertatsiya qilindi! {userAge}");

            Kescha.CalculateAgeDifferenceWithNoReturn(userAge);
            Kescha.PrintAgeDifference();
            Kescha.CompareAges(userAge);
            Kescha.TellAboutFriends(userName, userAge);
        }
    }
}