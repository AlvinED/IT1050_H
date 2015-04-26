using System;
namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool courseNew = false;
            Course.createCourse();
            Console.Write("course creation complete enter Y or N:");  
            courseNew = Console.ReadLine().StartsWith("y");
            if (bool.Parse(courseNew = ("y")))
            {
                courseNew = true;
            }
            while (!courseNew) ;

            
        }
    }
}
