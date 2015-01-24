using System;
namespace Lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your middle initial");
            string middleInitial = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            string fullName = firstName + middleInitial + lastName;
            int age = 61;
            bool isCitizen = true;

            int heightFeet = 5;
            double heightInches = 9.5;
            Console.WriteLine(firstName +" "+ middleInitial +" " + lastName);
            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;
            bool canVote = age >= 21 && isCitizen;
        }
    }
}
