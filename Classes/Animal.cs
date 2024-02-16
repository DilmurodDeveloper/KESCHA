namespace KESCHA.Classes
{
    public abstract class Animal : IAnimal
    {
        public abstract void Greet2(string userName);
        public string Name { get; set; }
        protected int Age { get; set; }
        internal int AgeDifference { get; set; }
        private string Password { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
            Password = "23;";
            CreatedDate = DateTimeOffset.Now;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            CreatedDate = DateTimeOffset.Now;
        }

        public Animal(
            string name, 
            int userAge, 
            int animalAge)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
            CreatedDate = DateTimeOffset.Now;
        }

        public void PrintAgeDifference()
        {
            Console.WriteLine($"Age difference between you and {Name}: {AgeDifference}");
        }

        public void CompareAges(int userAge)
        {
            if(userAge > Age)
            {
                Console.WriteLine("You are older!");
            }
            else if(userAge == Age)
            {
                Console.WriteLine("You are equal!");
            }
            else
            {
                Console.WriteLine("You are younger!");
            }
        }

        public void TellAboutFriends(string userName, int userAge)
        {
            Console.WriteLine("Let me tell you about my friends.");

             if(userName == "")
            {
                userName = "Unknown person";
            }
            string[] friendsName = new string[3];
            friendsName[0] = "Vasya";
            friendsName[1] = "Kasee";
            friendsName[2] = userName;
            int[] friendsAge = {1, 2, userAge};

            Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} year old!");
            Console.WriteLine($"{friendsName[1]} is {friendsAge[1]} year old!");
            Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} year old!");
        }

        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }

        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }

        public virtual void Greet(string userName)
        {
            if(userName == "")
            {
                userName = "Unknown person";
            }
            Console.WriteLine($"Hello, {userName}");
        }

        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}