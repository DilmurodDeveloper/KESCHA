namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public Bird(string name, int age)
            : base(name, age)
        {

        }

        public override void Greet(string userName)
        {
            Console.WriteLine($"Hello, {userName}");
        }
    }
}