namespace KESCHA.Classes
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(string name, int userAge, int animalAge)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
        }

        public void PrintAgeDifference()
        {
            Console.WriteLine($"Siz va {Name} o'rtasidagi yosh farqi: {AgeDifference}");
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

        public void Greet(string userName)
        {
            if(userName == "")
            {
                userName = "Unknown person";
            }
            Console.WriteLine($"Salom, {userName}");
        }

        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}