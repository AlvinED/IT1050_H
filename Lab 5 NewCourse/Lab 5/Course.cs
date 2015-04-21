using System;

namespace Lab_5
{
    class Course
    {
        public string cName;
        public int cIDnumber;
        public int classSize;
        public Student[] eNrolled;

        public Course createCourse()
        {
            Console.WriteLine("Please enter course name");
            string cName = Console.ReadLine(); 
            Course myClass = new Course(); 
            Console.WriteLine("Please enter course number"); 
            cIDnumber = int.Parse(Console.ReadLine()); 
            //instantiate new array
            eNrolled = new Student[clasSize];
            for (int i = 0; i < eNrolled.Length; i++)
            {
                eNrolled[i] = Student.CreateStudent();
            }
            return myClass;
        }
        
            



    }
}
