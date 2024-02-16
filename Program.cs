using KESCHA.Classes;
using KESCHA.Enums;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            try
            {
                Animal kescha = new Bird(name: "Kescha", age: 5);
                Pet kasee = new Pet(name: "Kasee", age: 3);
                kasee.Type = PetType.Cat;

                Console.WriteLine("Kescha was created: " + kescha.CreatedDate);
                Console.WriteLine("Kasee was created: " + kasee.CreatedDate);
                Console.WriteLine(kasee.Type);

                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Kescha says: ");
                kescha.Greet(userName);
                Console.WriteLine("Kasee says: ");
                kasee.Greet(userName);
                Console.Write("Enter your age: ");
                string ageAsString = Console.ReadLine();
                        
                Console.WriteLine("Converting...");
                int userAge =  Convert.ToInt32(ageAsString);
                Console.WriteLine($"Successfully converted! {userAge}");
                kescha.PrintAgeDifference();
                kescha.CompareAges(userAge);
                kescha.CalculateAgeDifferenceWithNoReturn(userAge);
                kescha.TellAboutFriends(userName, userAge);
            }
            catch(FormatException formatException)
            {
                Console.WriteLine($"Error was thrown. Message: {formatException.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error was thrown. Type is not known");
            }
            Console.WriteLine("Program ended... ");
        }
    }
}