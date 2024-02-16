namespace KESCHA.Classes
{
    public interface IAnimal
    {
        void PrintAgeDifference();
        void CompareAges(int userAge);
        void TellAboutFriends(string userName, int userAge);
        void CalculateAgeDifferenceWithNoReturn(int userAge);
        int CalculateAgeDifference(int userAge, int animalAge);
        void Greet(string userName);
    }
}