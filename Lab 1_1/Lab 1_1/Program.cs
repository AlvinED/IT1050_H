using System;
namespace Lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input lines
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your middle initial");
            Char middleInitial = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Voting Eligibility"); Console.WriteLine("please enter the following informtion");
            Console.WriteLine("Age");
            int age = Console.Read();
            Console.WriteLine("Are your a citizen, please enter y or n");
            char CitizenYayNay = Console.ReadKey(Equals('y', 'n')).KeyChar;
            bool canVote = CitizenYayNay == 'y'; Console.WriteLine(" ");
            Console.WriteLine("What is your hieght in feet?");
            int heightFeet = (Console.Read());
            Console.ReadKey();
            Console.WriteLine("What is your hieght in inches?");
            double heightInches = Console.Read();
            Console.ReadKey();
            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;
            //Format Output lines
            string fullName = firstName +" "+ middleInitial +". "+ lastName;
            // Output
            Console.WriteLine();
            Console.WriteLine(fullName); Console.WriteLine();
            Console.WriteLine(totalHeightCM);
            /// this need more work can't spend any more time will resubmit aew
           
        }
    }
}
