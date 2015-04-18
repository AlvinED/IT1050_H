using System;
namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To create a new course. Enter Y if you done enter - N");
            {
                string courseNew = Console.ReadLine();
            }
            
            Console.WriteLine("Please enter Max number of students");
            int clasSize = int.Parse(Console.ReadLine());
            Course.createCourse();

            
        }
    }
}
