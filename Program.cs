using KESCHA.Classes;

// string password = "";
// do
// {
//     System.Console.Write("Parolni kiriting: ");
//     password = Console.ReadLine();
// }while(password != "Dilmurod");

Animal Kescha = new Animal(name: "Kescha", age: 5);

Console.Write("Ismingzni kiriting: ");
string userName = Console.ReadLine();
Kescha.Greet(userName);

Console.Write("Yoshingizni kiriting: ");
string ageAsString = Console.ReadLine();

Console.WriteLine("Konvertatsiya qilinmoqda...");
int userAge =  Convert.ToInt32(ageAsString);
Console.WriteLine($"Muvaffaqiyatli konvertatsiya qilindi! {userAge}");

Kescha.CalculateAgeDifferenceWithNoReturn(userAge);
Kescha.PrintAgeDifference();
Kescha.CompareAges(userAge);
Kescha.TellAboutFriends(userName, userAge);