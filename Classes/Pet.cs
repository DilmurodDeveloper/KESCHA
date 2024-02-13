namespace KESCHA.Classes
{
    public class Pet : Animal
    {
        public Pet(string name, int age)
            : base(name, age)
        {

        }
        public override void Greet(string userName)
        {
            Console.WriteLine($"Meow, {userName}");
        }
    }
}