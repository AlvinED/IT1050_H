using System;
namespace Lab_5_Do_Over
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createNew = true;
            Console.WriteLine("Create a new course? Y for Yes");
            while (createNew)
            {
                Course newCourse(string courseName,int numberCourse,Student[] numberStudent); //// Add new students to course
                Console.Writeline("Are you done? Enter Y fo no to start over");
                string done = Console.readline();
                if (done = "Y")
                {
                    createNew = false;
                }
            }
            
        }
    }
}
