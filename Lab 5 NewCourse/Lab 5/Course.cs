using System;

namespace Lab_5
{
    class Course
    {
        public string cName;
        public int cIDnumber;
        public int classSize;
        public Student[] eNrolled;

        public Course createCourse(string cName,int cIDnumber,Student[] eNrolled)
        {
            Console.WriteLine("Please enter course name");
            this.cName = Console.ReadLine(); 
            Course myClass = new Course(); 
            Console.WriteLine("Please enter course number"); 
            cIDnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Max number of students");
            classSize = int.Parse(Console.ReadLine());
            //instantiate new array
            eNrolled = new Student[this.classSize];
            for (int i = 0; i < eNrolled.Length; i++)
            {
                Student.CreateStudent();
                eNrolled[i] =  makeStudent;
            }
            return myClass;
        }
        
            



    }
}
