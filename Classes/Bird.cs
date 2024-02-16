namespace KESCHA.Classes
{
    public class Bird : Animal, IBird
    {
        public Bird(string name, int age)
            : base(name, age)
        {

        }

        public override void Greet(string userName)
        {
            Console.WriteLine($"Hello, {userName}");
        }

        public override void Greet2(string userName)
        {
            Age = 2;
        }
    }
}