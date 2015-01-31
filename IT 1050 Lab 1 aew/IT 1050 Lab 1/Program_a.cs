using System;
namespace IT_1050_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Alvin";
            char middleInitial = 'E';
            string lastName = "williams";
            string fullName = firstName +" " + middleInitial +". " + lastName;
            int age = 61;
            bool isCitizen = true;
            
            int heightFeet = 5;
            double heightInches = 9.5;
            double totalHeightCM = ((heightFeet *12) + heightInches) * 2.54;
            bool canVote = age >= 21 && isCitizen;
            
        }
    }
}
