using System;

namespace Lab_5
{
    class Course
    {
        public string cName;
        public int cIDnumber;
        
        public Student[] eNrolled;

        public void createCourse()
        {
            Course myClass = new Course();
            Console.WriteLine("Please enter course name");
            myClass.cName = Console.ReadLine();
            Console.WriteLine("Please enter course number");
            myClass.cIDnumber = int.Parse(Console.ReadLine());
            
            myClass.eNrolled = new Student [clasSize];
            for ( eNrolled X = 0 ; X < eNrolled.Length;  eNrolled++)
            {
                Student.CreateStudent();
            }



           
            
        }

            
            



    }
}
